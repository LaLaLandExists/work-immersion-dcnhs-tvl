using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  public partial class HomeForm : Form
  {
    // Table Indicator
    private readonly Label[] tableSelectIndicators;
    private readonly string[] dormantIndicatorTexts;
    private readonly string[] activeIndicatorTexts;
    private readonly Font dormantIndicatorFont = new Font("Verdana", 9, FontStyle.Regular);
    private readonly Font activeIndicatorFont = new Font("Verdana", 9, FontStyle.Bold);
    private readonly Color dormantIndicatorColor = Color.Black;
    private readonly Color activeIndicatorColor = Color.Blue;

    private int selectedTable;

    private void SetTableIndicatorEmphasizedState(int ii, bool state)
    {
      Label theIndicator = tableSelectIndicators[ii];
      if (state)
      {
        selectedTable = ii;
        theIndicator.Font = activeIndicatorFont;
        theIndicator.Text = activeIndicatorTexts[ii];
        theIndicator.ForeColor = activeIndicatorColor;
        SetDGVColumns(tableLayouts[ii]);

        // Fetch the stuff
        SetTableIndicatorState(false);
        bwork_TableFetcher.RunWorkerAsync();
      }
      else
      {
        theIndicator.Font = dormantIndicatorFont;
        theIndicator.Text = dormantIndicatorTexts[ii];
        theIndicator.ForeColor = dormantIndicatorColor;
      }
    }

    private void EmphasizeTableIndicator(Label theIndicator)
    {
      for (int i = 0; i < tableSelectIndicators.Length; i++)
      {
        SetTableIndicatorEmphasizedState(i, theIndicator == tableSelectIndicators[i]);
      }
    }
    // End of Table Indicators

    // DGV Modifiers
    private readonly DataGridViewColumn[] inHouseColumns = new DataGridViewColumn[]
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Stay"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child")
      };
    private readonly DataGridViewColumn[] noShowColumns = new DataGridViewColumn[]
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child"),
        MakeColumn<DataGridViewTextBoxColumn>("Cancel No.")
      };

    private readonly DataGridViewColumn[][] tableLayouts;

    // Iterates through the result set and invokes decorator
    // Invoked in RunWorker
    private delegate void TableFetcher(MySqlDataReader rd);
    // Invoked in ProgressChanged
    private delegate void TableDecorator(object[] values);
    private delegate void TableResolver();
    private delegate void TableResolveDecorator(int i, object[] values);

    private readonly TableFetcher[] tableFetchers;
    private readonly TableDecorator[] tableDecorators;
    private readonly TableResolver[] tableResolvers;
    private readonly TableResolveDecorator[] tableRDecorators;

    // In House Methods
    private void InHouseFetcher(MySqlDataReader rd)
    {
      while (rd.Read())
      {
        DateTime arrival = rd.GetDateTime("arrival");
        DateTime departure = rd.GetDateTime("departure");
        bwork_TableFetcher.ReportProgress(0, new object[] {
          rd.GetInt32("roomId"), rd.GetInt32("roomId"), rd.GetInt32("clientId"),
          arrival.ToShortDateString(), departure.ToShortDateString(), (SessionBirth - arrival.Date).Days, rd.GetInt32("id"),
          rd.GetInt32("roomId"), rd.GetInt32("adultCount"), rd.GetInt32("childCount")
        });
      }
    }

    private void InHouseDecorator(object[] values)
    {
      dgv_DataTable.Rows.Add(values);
    }

    private void InHouseResolver()
    {
      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        for (int i = 0; i < dgv_DataTable.Rows.Count; i++)
        {
          DataGridViewRow row = dgv_DataTable.Rows[i];
          DataGridViewCellCollection cells = row.Cells;
          cmd.CommandText = $"SELECT roomNumber, roomType, rate FROM Room WHERE id = {row.Cells[0].Value};";
          string roomNo, roomType;
          double rate;
          using (MySqlDataReader rd = cmd.ExecuteReader())
          {
            rd.Read();
            roomNo = rd.GetString("roomNumber");
            roomType = rd.GetString("roomType");
            rate = rd.GetDouble("rate");
          }

          cmd.CommandText = $"SELECT firstName, lastName FROM Client WHERE id = {row.Cells[2].Value};";
          string clientName;
          using (MySqlDataReader rd = cmd.ExecuteReader())
          {
            rd.Read();
            clientName = $"{rd.GetString("lastName")}, {rd.GetString("firstName")}";
          }

          bwork_TableResolver.ReportProgress(i, new object[] {
            roomNo, roomType, clientName, cells[3].Value, cells[4].Value, cells[5].Value, cells[6].Value, rate, cells[8].Value, cells[9].Value
          });
        }
      }
    }

    private void InHouseRDecorator(int i, object[] values)
    {
      dgv_DataTable.Rows[i].SetValues(values);
    }

    private static DataGridViewColumn MakeColumn<T>(string name, bool readOnly = true) where T : DataGridViewColumn, new()
    {
      DataGridViewColumn obj = new T
      {
        HeaderText = name,
        ReadOnly = readOnly
      };
      return obj;
    }

    private void SetDGVColumns(DataGridViewColumn[] cols)
    {
      dgv_DataTable.Columns.Clear();
      dgv_DataTable.Columns.AddRange(cols);
      //dgv_DataTable.Rows.Add();
    }
    // End of DGV Modifiers

    // WinForm methods
    public HomeForm()
    {
      InitializeComponent();

      tableSelectIndicators = new Label[]
      {
        lbl_InHouse, lbl_Arrivals, lbl_Departures,
        lbl_Reservations, lbl_CheckedOut, lbl_NoShows,
        lbl_Cancelled, lbl_WaitList
      };

      dormantIndicatorTexts = new string[]
      {
        "In House", "Arrivals", "Departures",
        "Reservations", "Checked Out", "No Shows",
        "Cancelled", "Wait List"
      };

      activeIndicatorTexts = new string[dormantIndicatorTexts.Length];

      for (int i = 0; i < activeIndicatorTexts.Length; i++)
      {
        activeIndicatorTexts[i] = $"▶ {dormantIndicatorTexts[i]}";
      }

      // TODO: OPTIMIZE!
      tableLayouts = new DataGridViewColumn[][] {
      // For In House
      inHouseColumns,

      // For Arrivals
      new DataGridViewColumn []
      {
        MakeColumn<DataGridViewTextBoxColumn>("Room No."),
        MakeColumn<DataGridViewTextBoxColumn>("Room Type"),
        MakeColumn<DataGridViewTextBoxColumn>("Name"),
        MakeColumn<DataGridViewTextBoxColumn>("Date In"),
        MakeColumn<DataGridViewTextBoxColumn>("Date Out"),
        MakeColumn<DataGridViewTextBoxColumn>("Res ID"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate"),
        MakeColumn<DataGridViewTextBoxColumn>("Rate Code"),
        MakeColumn<DataGridViewTextBoxColumn>("Adult"),
        MakeColumn<DataGridViewTextBoxColumn>("Child")
      },

      // For Departures
      inHouseColumns,

      // For Reservations
      inHouseColumns,

      // For Checked Out
      inHouseColumns,

      // For No Shows
      noShowColumns,

      // For Cancelled
      noShowColumns,

      // For Wait List
      inHouseColumns
    };

      tableFetchers = new TableFetcher[] { InHouseFetcher };
      tableDecorators = new TableDecorator[] { InHouseDecorator };
      tableResolvers = new TableResolver[] { InHouseResolver };
      tableRDecorators = new TableResolveDecorator[] { InHouseRDecorator };
    }

    private void HomeForm_Load(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_InHouse);
      Session.AssertConnection();
      Session sesh = Program.session;
      lbl_UserFullName.Text = $"{sesh.lastName}, {sesh.firstName}";
      lbl_Username.Text = $"({sesh.username})";
      lbl_DateTimeIndicator.Text = $"Session birth: {SessionBirth}";
    }

    private DateTime SessionBirth
    {
      get { return Program.session.dateTime;  }
    }

    private bool AskExitConfirmation()
    {
      var res = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
      return res == DialogResult.Yes;
    }

    private void lbl_InHouse_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_InHouse);
    }

    private void lbl_Arrivals_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Arrivals);
    }

    private void lbl_Departures_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Departures);
    }

    private void lbl_Reservations_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Reservations);
    }

    private void lbl_CheckedOut_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_CheckedOut);
    }

    private void lbl_NoShows_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_NoShows);
    }

    private void lbl_Cancelled_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_Cancelled);
    }

    private void lbl_WaitList_Click(object sender, EventArgs e)
    {
      EmphasizeTableIndicator(lbl_WaitList);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = !AskExitConfirmation();
    }

    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new ChangePassword().ShowDialog();
    }

    private void pcmd_NewBooking_Click(object sender, EventArgs e)
    {
     new NewReservation().ShowDialog();
    }

    private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new SystemConfiguration().ShowDialog();
    }

    private void SetControlState(bool state, params Control[] ctrls)
    {
      foreach (Control ctrl in ctrls)
      {
        ctrl.Enabled = state;
      }
    }

    private void SetTableIndicatorState(bool state)
    {
      SetControlState(state, lbl_InHouse, lbl_Arrivals, lbl_Departures, lbl_Reservations, lbl_CheckedOut, lbl_NoShows, lbl_Cancelled);
    }

    private void bwork_TableFetcher_DoWork(object sender, DoWorkEventArgs e)
    {
      TableFetcher fetcher = tableFetchers[selectedTable];
      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = $"SELECT * FROM Reservation;";
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
          fetcher(reader);
        }
      }
    }

    private void bwork_TableFetcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      tableDecorators[selectedTable]((object[]) e.UserState);
    }

    private void bwork_TableFetcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        SetTableIndicatorState(true);
        MessageBox.Show("Cannot fetch reservation data.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        bwork_TableResolver.RunWorkerAsync();
      }
    }

    private void bwork_TableResolver_DoWork(object sender, DoWorkEventArgs e)
    {
      tableResolvers[selectedTable]();
    }

    private void bwork_TableResolver_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      tableRDecorators[selectedTable](e.ProgressPercentage, (object[]) e.UserState);
    }

    private void bwork_TableResolver_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        MessageBox.Show("Cannot fetch reservation data.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      SetTableIndicatorState(true);
    }
  }
}
