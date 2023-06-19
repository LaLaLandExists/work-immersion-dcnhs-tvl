using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NoteView
{
  public partial class NewReservation : Form
  {
    public NewReservation()
    {
      InitializeComponent();
    }
    private static void SetControl(bool s, params Control[] ctrls) 
    {
      foreach (Control ctrl in ctrls)
      {
        ctrl.Enabled = s;
      }
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
      tb_FirstName.Text = ""; tb_LastName.Text = ""; tb_address.Text = ""; tb_ZipCode.Text = ""; cb_Country.Text = "";
      cb_Nationality.Text = ""; tb_City.Text = ""; tb_State_Province.Text = "";
      tb_GuestNote.Text = ""; tb_MobileNum.Text = ""; tb_TelephoneNum.Text = ""; tb_Email.Text = "";
      cb_PostDepo.Checked = false; tb_Amount.Text = string.Empty;
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
      if (cb_PostDepo.Checked == true)
      {
        tb_Amount.Text = "";
        tb_Amount.ReadOnly = false;
      }
      else
      {
        tb_Amount.ReadOnly = true;
        tb_Amount.Text = "0";
      }
    }

    private void btn_Refresh_Click(object sender, EventArgs e)
    {
      Reload();
      btn_Clear_Click(sender, e);
      cb_ClientType.Text = "";
      cb_RoomCharge.Text = "";

    }

    private void NewReservation_Load(object sender, EventArgs e)
    {
      dtp_Arrival.Value = DateTime.Today;
      dtp_Departure.Value = DateTime.Today;
      lbl_issuedName.Text = $"{Program.session.lastName}, {Program.session.firstName}";
      Reload();
    }

    private void dtp_Departure_ValueChanged(object sender, EventArgs e)
    {
      int Arrival = dtp_Arrival.Value.Day;
      int departure = dtp_Departure.Value.Day;

      if (departure > Arrival)
      {
        nud_Nights.Value = 0;
        for (int today = Arrival; today < departure; ++today)
        {
          nud_Nights.Value += 1;
        }
      }
      if (departure <= Arrival)
        nud_Nights.Value = 0;
    }

    private void btn_search_Click(object sender, EventArgs e)
    {
      GuestSearch guestSearch = new GuestSearch();
      guestSearch.ShowDialog();

    }

    private void btn_Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_CreditCards_Click(object sender, EventArgs e)
    {
      CreditCards creditCards = new CreditCards();
      creditCards.ShowDialog();
    }

    private void bWork_Client_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      string[] args = (string[])e.Argument;
      UseWaitCursor = true;

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        string nameTitle = args[0];
        string firstName = args[1];
        string middleName = args[2];
        string lastName = args[3];

        string streetAd = args[4];
        string zipCode = args[5];
        string cityAd = args[6];
        string countryAd = args[7];
        string stateProvinceAd = args[8];
        string nationality = args[9];

        string guestNote = args[10];

        string telephone = args[11];
        string mobile = args[12];
        string email = args[13];

        string amount = args[14];

        string vehicleBrand = args[15];
        string vehicleModel = args[16];
        string vehicleColor = args[17];
        string license = args[18];

        cmd.CommandText = $"INSERT INTO Client (nameTitle, firstName, middleName, lastName, streetAd, zipCode, cityAd," +
            $" countryAd, stateProvinceAd, nationality, guestNote, telephone, mobile, email, amount, vehicleBrand," +
            $" vehicleModel, vehicleColor, license) VALUES ('{nameTitle}', '{firstName}', '{middleName}', '{lastName}'," +
            $"'{streetAd}', '{zipCode}', '{cityAd}', '{countryAd}', '{stateProvinceAd}', '{nationality}', '{guestNote}', '{telephone}'," +
            $"'{mobile}', '{email}', '{amount}', '{vehicleBrand}', '{vehicleModel}', '{vehicleColor}', '{license}');";

        UseWaitCursor = false;
        cmd.ExecuteNonQuery();
      }
    }

    private void btn_submit_Click(object sender, EventArgs e)
    {
      string firstName = tb_FirstName.Text;
      string lastName = tb_LastName.Text;
      string zipCode = tb_ZipCode.Text;
      string mobile = tb_MobileNum.Text;
      if (MessageBox.Show("Please double check for the information, or YES if you are sure.", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        if ((firstName == "") || (lastName == "") || (zipCode == "") || (mobile == ""))
          MessageBox.Show("Missing required information.", "Oops");
        else
        {
          UseWaitCursor = true;
          bWork_Client.RunWorkerAsync(new string[] {
              tb_nameTitle.Text, tb_FirstName.Text, tb_middleName.Text, tb_LastName.Text, tb_address.Text,
              tb_ZipCode.Text, tb_City.Text, cb_Country.Text, tb_State_Province.Text, cb_Nationality.Text,
              tb_GuestNote.Text, tb_TelephoneNum.Text, tb_MobileNum.Text, tb_Email.Text, tb_Amount.Text,
              tb_Brand.Text, tb_Model.Text, tb_Color.Text, tb_License.Text
          });
        }
      }
    }

    private void bWork_Client_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      UseWaitCursor = false;
      if (e.Error != null)
      {
        MessageBox.Show("An error occurred, the process cannot be completed", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error); 
      }
    }

    private void RightSidePanel_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Reload()
    {
      UseWaitCursor = true;
      SetControl(false, cb_ClientType, cb_RoomCharge, nud_Nights, nud_Adult, nud_Child, btn_Refresh);

      cb_RoomNumber.Items.Clear();
      bWork_Loader.RunWorkerAsync();
    }

    private void bWork_Loader_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT roomNumber FROM Room;";
        using (MySqlDataReader rd = cmd.ExecuteReader())
        {
          while (rd.Read())
          {
            bWork_Loader.ReportProgress(0, rd.GetString(0));
          }
        }
      }
    }

    private void bWork_Loader_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      string arg = (string) e.UserState;
      cb_RoomNumber.Items.Add(arg);
    }

    private void bWork_Loader_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        MessageBox.Show("Cannot retrieve information", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      UseWaitCursor = false;
      SetControl(true, cb_ClientType, cb_RoomCharge, nud_Nights, nud_Adult, nud_Child, btn_Refresh);
    }

    private void cb_RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
    {
      btn_submit.Enabled = true;
    }
  }
}