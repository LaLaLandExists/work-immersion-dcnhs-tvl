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
    
    private void btn_Connect_Click(object sender, EventArgs e)
    {
      lbl_Connecting.Text = "Connecting to database..";
      lbl_Connecting.Show();
      lbl_Error.Hide();
      lbl_MissingInfo.Hide();
      btn_Connect.Enabled = false;

      string server = txt_Server.Text,
             port = txt_Port.Text,
             username = txt_Username.Text,
             password = txt_Password.Text,
             db = txt_DB.Text;

      if (HasEmpty(server, username, password, db))
      {
        lbl_Connecting.Hide();
        lbl_MissingInfo.Show();
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
        lbl_Connecting.Text = $"Checking {e.UserState}..";
      }
    }

    private void bwork_Connection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      object res = e.Result;

      switch (res)
      {
        case MySqlConnection conn:
          Program.Connection = conn;
          lbl_Connecting.Text = "Connected";
          break;
        case int err when err == 0:
          lbl_Connecting.Hide();
          lbl_Error.Text = "Cannot connect to database";
          lbl_Error.Show();
          break;
        case int err when err == 1:
          lbl_Connecting.Hide();
          lbl_Error.Text = "Invalid value in fields";
          lbl_Error.Show();
          break;
        case string err:
          lbl_Connecting.Hide();
          lbl_Error.Text = err;
          lbl_Error.Show();
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

    private void lbl_MissingInfo_Click(object sender, EventArgs e)
    {

    }
  }
}
