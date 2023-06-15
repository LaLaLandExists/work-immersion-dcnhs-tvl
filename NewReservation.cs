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
            else { tb_Amount.ReadOnly = true;
                tb_Amount.Text = "0"; }
    }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            btn_Clear_Click(sender, e);
            cb_ClientType.Text = "";
            cb_RoomCharge.Text = "";

        }

        private void NewReservation_Load(object sender, EventArgs e)
        {
            dtp_Arrival.Value = DateTime.Today;
            dtp_Departure.Value = DateTime.Today;
            lbl_issuedName.Text = $"{Program.session.lastName}, {Program.session.firstName}";
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
            UseWaitCursor = true;

            using (MySqlCommand cmd = Session.conn.CreateCommand())
            {
                string nameTitle = tb_nameTitle.Text;
                string firstName = tb_FirstName.Text;
                string middleName = tb_middleName.Text;
                string lastName = tb_LastName.Text;

                string streetAd = tb_address.Text;
                string zipCode = tb_ZipCode.Text;
                string cityAd = tb_City.Text;
                string countryAd = cb_Country.Text;
                string stateProvinceAd = tb_State_Province.Text;
                string nationality = cb_Nationality.Text;

                string guestNote = tb_GuestNote.Text;

                string telephone = tb_TelephoneNum.Text;
                string mobile = tb_MobileNum.Text;
                string email = tb_Email.Text;

                string amount = tb_Amount.Text;

                string vehicleBrand = tb_Brand.Text;
                string vehicleModel = tb_Model.Text;
                string vehicleColor = tb_Color.Text;
                string license = tb_License.Text;

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
                    MessageBox.Show("All highlighted information are required. Please try again!", "Oops");
                else
                    bWork_Client.RunWorkerAsync();
            }

        }
    }
}