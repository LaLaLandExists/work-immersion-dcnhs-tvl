using System;
using System.Windows.Forms;

namespace NoteView
{
  public partial class NewReservation : Form
  {
    public NewReservation()
    {
      InitializeComponent();
    }

    private void tb_Info_Selected(object sender, TabControlEventArgs e)
    {
      if (e.TabPage == tp_Calendar)
        btn_Refresh.Visible = true;
      else
        btn_Refresh.Visible = false;
    }
    private void btn_Clear_Click(object sender, EventArgs e)
    {
      // Guest Info
      tb_FirstName.Text = ""; tb_LastName.Text = ""; tb_Address.Text = ""; tb_ZipCode.Text = ""; cb_Country.Text = "";
      cb_Nationality.Text = ""; tb_City.Text = ""; tb_State_Province.Text = ""; tb_PONumber.Text = "";
      tb_SoB.Text = ""; tb_GuestNote.Text = ""; tb_MobileNum.Text = ""; tb_TelephoneNum.Text = ""; tb_Email.Text = "";
      cb_Opt.Checked = false; cb_AGE.Checked = false; cb_VIP.Checked = false; cb_PostDepo.Checked = false;
      tb_Amount.Text = string.Empty;
      // Payment Method
      cb_PostDepo.Checked = false; cb_CardType.Text = ""; tb_CardNumber.Text = "";
      tb_ExpiryDate.Text = ""; tb_CardNumber.Text = "";
      // Vehicle Method
      tb_Brand.Text = "";
      tb_Color.Text = "";
      tb_Model.Text = "";
      tb_License.Text = "";
    }
    private void cb_PostDepo_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_PostDepo.Checked == true) tb_Amount.Enabled = true;
      else tb_Amount.Enabled = false; tb_Amount.Text = "";
    }

    private void cb_VIP_CheckedChanged(object sender, EventArgs e)
    {
      if (cb_VIP.Checked == true) tb_VIP.Enabled = true;
      else tb_VIP.Enabled = false; tb_VIP.Text = "";
    }
  }
}