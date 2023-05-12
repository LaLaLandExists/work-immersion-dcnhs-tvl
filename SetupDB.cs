using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteView
{
  public partial class SetupDB : Form
  {
    private bool hasEmphasizedRequiredFields = false;

    public SetupDB()
    {
      InitializeComponent();
    }

    private static bool HasEmpty(params string[] strs)
    {
      foreach (string str in strs)
      {
        if (str.Trim().Length == 0) return true;
      }
      return false;
    }
    private static void EmphasizeRequiredFields(params Label[] lbls)
    {
      foreach (Label lbl in lbls)
      {
        lbl.Text += "*";
        lbl.ForeColor = Color.Maroon;
      }
    }
    
    private void ShowMessage(string msg)
    {
      lbl_ErrorInfo.Hide();
      lbl_ConnectOutput.ForeColor = Color.White;
      lbl_ConnectOutput.Text = msg;
      lbl_ConnectOutput.Show();
    }
    private void ShowError(string msg, string info = null)
    {
      lbl_ConnectOutput.ForeColor = Color.Maroon;
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
      ShowMessage("Connecting to database..");
      btn_Connect.Enabled = false;

      string server = txt_Server.Text,
             port = txt_Port.Text,
             username = txt_Username.Text,
             password = txt_Password.Text,
             db = txt_DB.Text;

      if (HasEmpty(server, username, password, db))
      {
        ShowError("Missing field/s");
        if (!hasEmphasizedRequiredFields)
        {
          EmphasizeRequiredFields(lbl_Server, lbl_user, lbl_password, lbl_datab);
          hasEmphasizedRequiredFields = true;
        }
        btn_Connect.Enabled = true;
        return;
      }

      string connString = $"server={server};{(HasEmpty(port) ? "" : $"port={port};")}uid={username};pwd={password};database={db};";
      bwork_Connection.RunWorkerAsync(connString);
    }

    private void bwork_Connection_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      if (e.ProgressPercentage == 50)
      {
        ShowMessage($"Checking {e.UserState}..");
      }
    }

    private void bwork_Connection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      object res = e.Result;

      switch (res)
      {
        case MySqlConnection conn:
          Program.Connection = conn;
          ShowMessage("Connected");
          break;
        case int err when err == 0:
          ShowError("Cannot connect to database");
          break;
        case int err when err == 1:
          ShowError("Invalid value in fields");
          break;
        case string err:
          ShowError("Invalid database", err + ". Please check your database configuration");
          break;
      }

      btn_Connect.Enabled = true;
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
  }
}
