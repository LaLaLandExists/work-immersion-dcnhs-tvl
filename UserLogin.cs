using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
    public partial class UserLogin : Form
    {
      private readonly Regex unameRegex = new Regex("^[_a-zA-Z][_a-zA-Z0-9]*$");
        public UserLogin()
        {
            InitializeComponent();
        }

        private bool IsValidUName(string uname)
        {
          return unameRegex.IsMatch(uname);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gb_login_Enter(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

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
;         }
          if (unameLength > Program.MaximumUsernameLength)
          {
            ShowError("Username is too long");
            return;
          }

          if (!IsValidUName(uname))
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

          // TODO do authentication check
          ShowMessage("Ok");
        }

        private void chb_showpass_CheckedChanged(object sender, EventArgs e)
        {
          tb_pass.UseSystemPasswordChar = !tb_pass.UseSystemPasswordChar;
        }
    }
}
