using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Text;

namespace NoteView
{
  public partial class SetupDB : Form
  {
    internal struct ConnectionArgs
    {
      public readonly string server;
      public readonly string port;
      public readonly string username;
      public readonly string password;
      public readonly string database;

      public ConnectionArgs(string server, string port, string username, string password, string database = null)
      {
        this.server = server;
        this.port = port;
        this.username = username;
        this.password = password;
        this.database = database;
      }

      public string ConnectionString(bool includeDB)
      {
        StringBuilder sb = new StringBuilder();
        sb.Append($"server={server};");
        if (port != null)
        {
          sb.Append($"port={port};");
        }
        sb.Append($"uid={username};");
        sb.Append($"pwd={password};");
        if (includeDB)
        {
          sb.Append($"database={database};");
        }
        return sb.ToString();
      }
    };

    private readonly struct CreateOrConnectDBResult
    {
      public readonly bool hasAccount;
      public readonly MySqlConnection conn;

      public CreateOrConnectDBResult(bool hasAccount, MySqlConnection conn)
      {
        this.hasAccount = hasAccount;
        this.conn = conn;
      }
    }

    private delegate void CreateOrConnectProgressReporter(int percent, object indicator);

    private CreateOrConnectDBResult CreateOrConnectDB(ConnectionArgs args, CreateOrConnectProgressReporter progress = null)
    {
      // Test if db exists first.
      var conn = new MySqlConnection(args.ConnectionString(false));
      conn.Open();
      progress?.Invoke(20, "Checking database");

      if (cb_ForceConnect.Checked || conn.DBExists(args.database))
      {
        // DB exists. Validate and connect
        conn.ChangeDatabase(args.database);
        progress?.Invoke(50, $"Found '{args.database}'. Validating database");
        DatabaseChecker.Check(conn);
      }
      else
      {
        // DB does not exist. Create db
        progress?.Invoke(30, "No database found. Creating database");
        using (MySqlCommand cmd = conn.CreateCommand())
        {
          cmd.CommandText = $"CREATE DATABASE {args.database};";
          cmd.ExecuteNonQuery();
          cmd.CommandText = $"USE {args.database};";
          cmd.ExecuteNonQuery();
        }
        progress?.Invoke(40, "Database created. Creating tables");

        int percent = 40;
        int step = 60 / Util.tableOrder.Length;
        using (MySqlCommand cmd = conn.CreateCommand())
        {
          foreach (Util.TableInfo info in Util.tableOrder)
          {
            progress?.Invoke(percent, $"Creating {info.name}");
            percent += step;
            cmd.CommandText = info.schema;
            cmd.ExecuteNonQuery();
          }
        }
      }

      using (MySqlCommand cmd = conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT COUNT(id) AS numAcc FROM UserInfo;";
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          rd.Read();
          return new CreateOrConnectDBResult(rd.GetInt32(0) != 0, conn);
        }
      }
    }

    // Connect DB Set-up
    private bool sd_hasEmphasizedRequiredFields = false;

    public SetupDB()
    {
      InitializeComponent();
    }

    private void SDShowMessage(string msg)
    {
      lbl_ConnectOutput.ForeColor = Color.White;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
    }
    private void SDShowError(string msg)
    {
      lbl_ConnectOutput.ForeColor = Color.Red;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
    }

    private void btn_Connect_Click(object sender, EventArgs e)
    {
      SDShowMessage("Connecting to database..");

      ConnectionArgs cargs = new ConnectionArgs(
        txt_Server.Text, string.IsNullOrEmpty(txt_Port.Text) ? null : txt_Port.Text,
        txt_Username.Text, txt_Password.Text, txt_DB.Text
      );

      if (Util.HasEmpty(cargs.server, cargs.username, cargs.password, cargs.database))
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
      bwork_Connection.RunWorkerAsync(cargs);
    }

    private void bwork_Connection_DoWork(object sender, DoWorkEventArgs e)
    {
      ConnectionArgs cargs = (ConnectionArgs) e.Argument;
      e.Result = CreateOrConnectDB(cargs, (p, msg) => bwork_Connection.ReportProgress(p, msg));
    }

    private void bwork_Connection_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      SDShowMessage($"Setting up.. ({e.ProgressPercentage}%) {e.UserState}");
    }

    private void bwork_Connection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {

      if (e.Error == null)
      {
        var res = (CreateOrConnectDBResult) e.Result;
        Session.conn = res.conn;
        SDShowMessage("Connected");

        if (res.hasAccount)
        {
          bwork_Staller.RunWorkerAsync((StallerDone)(() => Close()));
        }
        else
        {
          SUSwapBoxes();
        }
      }
      else
      {
        switch (e.Error)
        {
          case MySqlException exc:
            SDShowError($"Database connection error: {exc.Message}");
            break;
          case ValidationException exc:
            SDShowError($"Validation failed: {exc.Message}");
            break;
          case ArgumentException exc:
            SDShowError("A field contained invalid value");
            break;
        }
        btn_Connect.Enabled = true;
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
      object[] args = (object[])e.Argument;
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
        bwork_Staller.RunWorkerAsync((StallerDone)(() => Close()));
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
        ((StallerDone)e.Result)();
      }
    }

    private void cb_ForceConnect_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_ForceConnect.Checked)
      {
        tt_ForceConnectHint.SetToolTip(cb_ForceConnect, "Uncheck to create a database if does not exist");
      }
      else
      {
        tt_ForceConnectHint.SetToolTip(cb_ForceConnect, "Check if connecting to an existing database");
      }
    }
  }
}
