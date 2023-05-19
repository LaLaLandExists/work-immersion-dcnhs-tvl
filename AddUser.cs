using System;
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

    private void btn_AAlogin_Click(object sender, EventArgs e)
    {
      gbx_AdminAuth.Visible = false;
      gbx_SignUp.Visible = true;
    }

    private void btn_SignUp_Click(object sender, EventArgs e)
    {
      gbx_AdminAuth.Visible = true;
      gbx_SignUp.Visible = false;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass1.UseSystemPasswordChar = !tbx_SignUpPass1.UseSystemPasswordChar;
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      tbx_SignUpPass2.UseSystemPasswordChar = !tbx_SignUpPass2.UseSystemPasswordChar;
    }

    private void chb_AAshowpass_CheckedChanged(object sender, EventArgs e)
    {
      tb_AApass.UseSystemPasswordChar = !tb_AApass.UseSystemPasswordChar;
    }

    private void cb_AdminCheck_CheckedChanged(object sender, EventArgs e)
    {

    }
  }
}
