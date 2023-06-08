using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  public partial class SystemConfiguration : Form
  {
    private const string RoomSearchInactiveStringHeader = "Existing Rooms";
    private const string RoomSearchActiveStringHeader = "Searching for rooms..";

    public SystemConfiguration()
    {
      InitializeComponent();
    }

    private void SetRoomConfigControls(bool state)
    {
      dgv_Rooms.Enabled = state;
      pcmd_RoomSearch.Enabled = state;
      txt_RoomSearch.Enabled = state;
    }

    private void FetchRooms(string keyword = null)
    {
      SetRoomConfigControls(false);
      UseWaitCursor = true;
      dgv_Rooms.Rows.Clear();
      gb_RoomTable.Text = RoomSearchActiveStringHeader;
      bwork_RoomFetcher.RunWorkerAsync(keyword);
    }

    private struct RoomFetchRow
    {
      public string id, roomNo, roomType, rate, capacity;

      public RoomFetchRow(string id, string no, string type, string rate, string capacity)
      {
        this.id = id;
        roomNo = no;
        roomType = type;
        this.rate = rate;
        this.capacity = capacity;
      }
    }

    private void bwork_RoomFetcher_DoWork(object sender, DoWorkEventArgs e)
    {
      string query;

      if (e.Argument == null)
      {
        query = $"SELECT * FROM Room;";
      }
      else
      {
        string sought = (string) e.Argument;
        query = $"SELECT * FROM Room WHERE roomNumber LIKE '%{sought}%' OR roomType LIKE '%{sought}%';";
      }

      Session.AssertConnection();

      RoomFetchRow row = new RoomFetchRow();

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = query;
        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            row.id = $"{reader.GetInt32("id")}";
            row.roomNo = reader.GetString("roomNumber");
            row.roomType = reader.GetString("roomType");
            row.rate = $"{reader.GetFloat("rate")}";
            row.capacity = $"{reader.GetInt32("capacity")}";

            bwork_RoomFetcher.ReportProgress(0, row);
          }
        }
      }
    }

    private void bwork_RoomFetcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      SetRoomConfigControls(true);
      UseWaitCursor = false;
      if (e.Error == null)
      {
        gb_RoomTable.Text = RoomSearchInactiveStringHeader;
      } 
      else
      {
        tsstrip_Indicator.Text = e.Error.Message;
      }

      cmd_Remove.Enabled = dgv_Rooms.CurrentRow != null;
    }

    private void SystemConfiguration_Load(object sender, EventArgs e)
    {
      FetchRooms();
    }

    private void pcmd_RoomSearch_Click(object sender, EventArgs e)
    {
      FetchRooms(string.IsNullOrWhiteSpace(txt_RoomSearch.Text) ? null : txt_RoomSearch.Text);
    }

    private void bwork_RoomFetcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      RoomFetchRow row = (RoomFetchRow) e.UserState;

      dgv_Rooms.Rows.Add(row.id, row.roomNo, row.roomType, row.rate, row.capacity);
    }

    private void dgv_Rooms_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      int i = e.RowIndex;

      var row = dgv_Rooms.Rows[i];
      txt_RoomNo.Text = (string) row.Cells[1].Value;
      txt_RoomType.Text = (string)row.Cells[2].Value;
      txt_Rate.Text = (string)row.Cells[3].Value;
      txt_Capacity.Text = (string)row.Cells[4].Value;
    }

    private void cmd_Remove_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you sure?", "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        bwork_RoomDeleter.RunWorkerAsync(dgv_Rooms.CurrentRow);
      }
    }

    private void bwork_RoomDeleter_DoWork(object sender, DoWorkEventArgs e)
    {
      DataGridViewRow row = (DataGridViewRow) e.Argument;
      Session.AssertConnection();

      using (MySqlCommand cmd = Session.conn.CreateCommand())
      {
        cmd.CommandText = $"DELETE FROM Room WHERE id = {row.Cells[0].Value};";
        cmd.ExecuteNonQuery();
      }
    }

    private void bwork_RoomDeleter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error == null)
      {
        tsstrip_Indicator.Text = "Removed room successfully";
        FetchRooms(txt_RoomSearch.Text);
      }
      else
      {
        tsstrip_Indicator.Text = e.Error.Message;
      }
    }
  }
}
