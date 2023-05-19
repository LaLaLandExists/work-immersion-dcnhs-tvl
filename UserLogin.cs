using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NoteView
{
  public partial class UserLogin : Form
  {
    private AddUser addUserForm;
    public UserLogin()
    {
      InitializeComponent();
    }

    private void ShowMessage(string msg)
    {
      lbl_AuthMessage.ForeColor = Color.White;
      lbl_AuthMessage.Text = msg;
      lbl_AuthMessage.Show();
    }

    private void ShowError(string msg)
    {
      lbl_AuthMessage.ForeColor = Color.Red;
      lbl_AuthMessage.Text = msg;
      lbl_AuthMessage.Show();
    }
    private void btn_login_Click(object sender, EventArgs e)
    {

      string uname = tb_username.Text.Trim();
      string pword = tb_pass.Text.Trim();

      int unameLength = uname.Length;

      if (unameLength < Program.MinimumUsernameLength)
      {
        ShowError("Username is too short");
        return;
        ;
      }
      if (unameLength > Program.MaximumUsernameLength)
      {
        ShowError("Username is too long");
        return;
      }

      if (!Program.IsValidUname(uname))
      {
        ShowError("Username contained invalid characters");
        return;
      }

      int passLength = pword.Length;
      if (passLength < Program.MinimumPasswordLength)
      {
        ShowError("Password is too short");
        return;
      }
      if (passLength > Program.MaximumPasswordLength)
      {
        ShowError("Password is too long");
        return;
      }

      bwork_Authentication.RunWorkerAsync();
    }

    private void chb_showpass_CheckedChanged(object sender, EventArgs e)
    {
      tb_pass.UseSystemPasswordChar = !tb_pass.UseSystemPasswordChar;
    }

    private void llbl_AddAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      addUserForm = new AddUser();
      addUserForm.ShowDialog();
    }

    private void bwork_Authentication_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      try
      {
        Program.session = new Session(tb_username.Text.Trim(), tb_pass.Text.Trim());
      }
      catch (InvalidOperationException exc)
      {
        e.Result = exc.Message;
      }
    }

    private void bwork_Authentication_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (e.Result != null)
      {
        ShowError((string) e.Result);
      }
      else
      {
        ShowMessage("Authenticated");
      }
    }
  }
}
