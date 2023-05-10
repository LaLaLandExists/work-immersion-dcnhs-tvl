using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // TODO: Check database validity
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
    }

    /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
     * Validity Region, to check if the loaded database works with the app.
     * * * * * * * * */

    private void bwork_DatabaseChecker_DoWork(object sender, DoWorkEventArgs e)
    {
      // TODO inspect the database here
    }

    private void bwork_DatabaseChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {

    }
  }
}
