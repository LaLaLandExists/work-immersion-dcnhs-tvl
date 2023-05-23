using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteView
{
  public partial class AddUser : Form
  {
    private Session session;

    public AddUser()
    {
      InitializeComponent();
    }

    private void SwapBoxes()
    {
      gbx_AdminAuth.Visible = !gbx_AdminAuth.Visible;
      gbx_SignUp.Visible = !gbx_SignUp.Visible;
    }

    // Admin Authentication Group Box

    private void TryAAAuth()
    {
      string uname = tb_AAusername.Text.Trim();
      string pword = tb_AApass.Text;
      string res;

      res = Program.IsValidUname(uname);
      if (res != null) throw new ArgumentException(res);

      res = Program.IsValidPword(pword);
      if (res != null) throw new ArgumentException(res);

      session = Session.LoginAccount(uname, pword);

      if (!session.adminMode) throw new InvalidOperationException("Account is unauthorized");
    }

    private void AAShowError(string msg)
    {
      lbl_AAAuthMessage.Text = msg;
      lbl_AAAuthMessage.ForeColor = Color.Red;
      lbl_AAAuthMessage.Show();
    }

    private void AAShowMessage(string msg)
    {
      lbl_AAAuthMessage.Text = msg;
      lbl_AAAuthMessage.ForeColor = Color.White;
      lbl_AAAuthMessage.Show();
    }

    private void btn_AAlogin_Click(object sender, EventArgs e)
    {
      try
      {
        TryAAAuth();
        AAShowMessage("Welcome admin");
        SwapBoxes();
        lbl_AdminMessage.Text = $"Authenticated as {session.lastName}, {session.firstName} ({session.username})";
        lbl_AdminMessage.Visible = true;
      }
      catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
      {
        AAShowError(ex.Message);
      }
    }

    private void chb_AAshowpass_CheckedChanged(object sender, EventArgs e)
    {
      tb_AApass.UseSystemPasswordChar = !tb_AApass.UseSystemPasswordChar;
    }

    // Sign Up Group Box

    private void SUReturn()
    {
      SwapBoxes();
      lbl_AAAuthMessage.Hide();
      tb_AAusername.Text = "";
      tb_AApass.Text = "";
      lbl_AdminMessage.Hide();
      SUClearFields();
    }

    private void SUClearFields()
    {
      tbx_SignUpUid.Text = "";
      tbx_SignUpFirstName.Text = "";
      tbx_SignUpLastName.Text = "";
      tbx_SignUpPass1.Text = "";
      tbx_SignUpPass2.Text = "";
      cb_AdminCheck.Checked = false;
    }

    private void SUTrySignUp()
    {
      string uname = tbx_SignUpUid.Text.Trim();
      string fname = tbx_SignUpFirstName.Text.Trim();
      string lname = tbx_SignUpLastName.Text.Trim();
      string pword = tbx_SignUpPass1.Text;
      string confirmPword = tbx_SignUpPass2.Text;
      bool isAdmin = cb_AdminCheck.Checked;

      // TODO: IMPLEMENT CONSTRAINTS ON NAMES
      if (string.IsNullOrEmpty(fname)) throw new ArgumentException("Invalid first name");
      if (string.IsNullOrEmpty(lname)) throw new ArgumentException("Invalid last name");

      string qres;

      qres = Program.IsValidUname(uname);
      if (qres != null)
      {
        throw new ArgumentException(qres);
      }

      qres = Program.IsValidPword(pword);
      if (qres != null)
      {
        throw new ArgumentException(qres);
      }

      if (pword != confirmPword)
      {
        throw new ArgumentException("Password does not match");
      }

      session.RegisterAccount(isAdmin, uname, pword, fname, lname);
    }

    private void SUShowError(string msg)
    {
      lbl_SignUpMsg.Text = msg;
      lbl_SignUpMsg.ForeColor = Color.Red;
      lbl_SignUpMsg.Show();
    }

    private void SUShowMessage(string msg)
    {
      lbl_SignUpMsg.Text = msg;
      lbl_SignUpMsg.ForeColor = Color.White;
      lbl_SignUpMsg.Show();
    }

    private void btn_SignUp_Click(object sender, EventArgs e)
    {
      try
      {
        SUTrySignUp();
        SUShowMessage("Account added");
      }
      catch (Exception ex) when (ex is ArgumentException || ex is InvalidOperationException)
      {
        SUShowError(ex.Message);
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass1.UseSystemPasswordChar = !tbx_SignUpPass1.UseSystemPasswordChar;
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass2.UseSystemPasswordChar = !tbx_SignUpPass2.UseSystemPasswordChar;
    }

    private void llbl_GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SUReturn();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      SUClearFields();
    }
  }
}
