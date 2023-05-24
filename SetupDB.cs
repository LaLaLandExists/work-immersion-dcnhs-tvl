using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace NoteView
{
  public partial class SetupDB : Form
  {
    // Connect DB Set-up
    private bool sd_hasEmphasizedRequiredFields = false;

    public SetupDB()
    {
      InitializeComponent();
    }


    private void SDShowMessage(string msg)
    {
      lbl_ErrorInfo.Hide();
      lbl_ConnectOutput.ForeColor = Color.White;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
    }
    private void SDShowError(string msg, string info = null)
    {
      lbl_ConnectOutput.ForeColor = Color.Red;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
      if (info != null)
      {
        lbl_ErrorInfo.Text = info;
        lbl_ErrorInfo.Show();
      }
    }

    private void btn_Connect_Click(object sender, EventArgs e)
    {
      SDShowMessage("Connecting to database..");

      string server = txt_Server.Text,
             port = txt_Port.Text,
             username = txt_Username.Text,
             password = txt_Password.Text,
             db = txt_DB.Text;

      if (Util.HasEmpty(server, username, password, db))
      {
        SDShowError("Missing field/s");
        if (!sd_hasEmphasizedRequiredFields)
        {
          Util.EmphasizeRequiredFields(lbl_Server, lbl_user, lbl_password, lbl_datab);
          sd_hasEmphasizedRequiredFields = true;
        }
        return;
      }

      btn_Connect.Enabled = false;

      string connString = $"server={server};{(Util.HasEmpty(port) ? "" : $"port={port};")}uid={username};pwd={password};database={db};";
      bwork_Connection.RunWorkerAsync(connString);
    }

    private void bwork_Connection_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (e.ProgressPercentage == 50)
      {
        SDShowMessage($"Checking {e.UserState}..");
      }
    }

    private void bwork_Connection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      object res = e.Result;

      if (res is MySqlConnection connection)
      {
        Session.conn = connection;
        SDShowMessage("Connected");

        if (CountAccounts() == 0)
        {
          SUSwapBoxes();
        }
        else
        {
          bwork_Staller.RunWorkerAsync((StallerDone)(() => Close()));
        }
      }
      else
      {
        btn_Connect.Enabled = true;
      }

      switch (res)
      {
        case int err when err == 0:
          SDShowError("Cannot connect to database");
          break;
        case int err when err == 1:
          SDShowError("Invalid value in fields");
          break;
        case string err:
          SDShowError("Invalid database", err + ". Please check your database configuration");
          break;
      }
    }

    private void bwork_Connection_DoWork(object sender, DoWorkEventArgs e)
    {
      try
      {
        string connString = (string) e.Argument;
        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        string dbName = conn.Database;
        bwork_Connection.ReportProgress(50, dbName);
        new DatabaseChecker(dbName, conn);
        e.Result = conn;
      }
      catch (MySqlException)
      {
        e.Result = 0;
      }
      catch (ArgumentException)
      {
        e.Result = 1;
      }
      catch (InvalidProgramException exc)
      {
        e.Result = exc.Message;
      }
    }

    // First Account Set-up
    private delegate void StallerDone();
    private bool su_hasEmphasizedRequiredFields = false;

    private const string AccountCounterSQL = "SELECT COUNT(id) AS numAccounts FROM UserInfo;";

    private static int CountAccounts()
    {
      Session.AssertConnection();

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = AccountCounterSQL;
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          rd.Read();
          return rd.GetInt32(0);
        }
      }
    }

    private void SUShowMessage(string msg)
    {
      lbl_SignUpOutput.Text = msg;
      lbl_SignUpOutput.ForeColor = Color.White;
      lbl_SignUpOutput.Show();
    }

    private void SUShowError(string msg)
    {
      lbl_SignUpOutput.Text = msg;
      lbl_SignUpOutput.ForeColor = Color.Red;
      lbl_SignUpOutput.Show();
    }

    private void SUSwapBoxes()
    {
      gbx_FASetup.Visible = !gbx_FASetup.Visible;
      gb_dbcnnct.Visible = !gb_dbcnnct.Visible;
    }

    private void cb_ShowPass_CheckedChanged(object sender, EventArgs e)
    {
      txt_SU_Pword.UseSystemPasswordChar = !txt_SU_Pword.UseSystemPasswordChar;
    }

    private void cb_ShowPass2_CheckedChanged(object sender, EventArgs e)
    {
      txt_SU_Pword2.UseSystemPasswordChar = !txt_SU_Pword2.UseSystemPasswordChar;
    }

    private void cmd_SignUp_Click(object sender, EventArgs e)
    {
      if (Util.HasEmpty(txt_SU_Username.Text, txt_SU_Fname.Text, txt_SU_Lname.Text, txt_SU_Pword.Text, txt_SU_Pword2.Text))
      {
        SUShowError("Missing required field/s");
        if (!su_hasEmphasizedRequiredFields)
        {
          Util.EmphasizeRequiredFields(lbl_SU_Uname, lbl_SU_Fname, lbl_SU_Lname, lbl_SU_Pword, lbl_SU_Pword2);
          su_hasEmphasizedRequiredFields = true;
        }
        return;
      }
      
      string uname = txt_SU_Username.Text;
      string fname = txt_SU_Fname.Text;
      string lname = txt_SU_Lname.Text;
      string pword = txt_SU_Pword.Text;
      
      if (txt_SU_Pword2.Text != pword)
      {
        SUShowError("Password does not match");
        return;
      }

      cmd_SignUp.Enabled = false;
      bwork_SignUp.RunWorkerAsync(new object[] { true, uname, pword, fname, lname });
    }

    private void bwork_SignUp_DoWork(object sender, DoWorkEventArgs e)
    {
      object[] args = (object[]) e.Argument;
      Session.RegisterAccount((bool)args[0], (string)args[1], (string)args[2], (string)args[3], (string)args[4]);
    }

    private void bwork_SignUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        if (e.Error is ArgumentException || e.Error is InvalidOperationException)
        {
          SUShowError(e.Error.Message);
        }
      }
      else
      {
        SUShowMessage("Account added");
        bwork_Staller.RunWorkerAsync((StallerDone) (() => Close()));
        return;
      }

      cmd_SignUp.Enabled = true;
    }

    private void bwork_Staller_DoWork(object sender, DoWorkEventArgs e)
    {
      Thread.Sleep(500);
      e.Result = e.Argument;
    }

    private void bwork_Staller_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null && e.Result != null)
      {
        ((StallerDone) e.Result)(); 
      }
    }
  }
}
