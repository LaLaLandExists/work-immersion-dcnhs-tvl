namespace NoteView
{
  partial class HomeForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pnl_Top = new System.Windows.Forms.Panel();
      this.pnl_Bottom = new System.Windows.Forms.Panel();
      this.dgv_DataTable = new System.Windows.Forms.DataGridView();
      this.fpnl_TableSelectView = new System.Windows.Forms.FlowLayoutPanel();
      this.label8 = new System.Windows.Forms.Label();
      this.lbl_WaitList = new System.Windows.Forms.Label();
      this.lbl_Cancelled = new System.Windows.Forms.Label();
      this.lbl_NoShows = new System.Windows.Forms.Label();
      this.lbl_CheckedOut = new System.Windows.Forms.Label();
      this.lbl_Reservations = new System.Windows.Forms.Label();
      this.lbl_Departures = new System.Windows.Forms.Label();
      this.lbl_Arrivals = new System.Windows.Forms.Label();
      this.lbl_InHouse = new System.Windows.Forms.Label();
      this.spc_TableContainer = new System.Windows.Forms.SplitContainer();
      this.tc_GuestTabs = new System.Windows.Forms.TabControl();
      this.tab_GuestInfo = new System.Windows.Forms.TabPage();
      this.tab_GuestFolio = new System.Windows.Forms.TabPage();
      this.fpnl_UserInfoDisplay = new System.Windows.Forms.FlowLayoutPanel();
      this.lbl_UserFullName = new System.Windows.Forms.Label();
      this.lbl_Username = new System.Windows.Forms.Label();
      this.pnl_Bottom.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_DataTable)).BeginInit();
      this.fpnl_TableSelectView.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spc_TableContainer)).BeginInit();
      this.spc_TableContainer.Panel1.SuspendLayout();
      this.spc_TableContainer.Panel2.SuspendLayout();
      this.spc_TableContainer.SuspendLayout();
      this.tc_GuestTabs.SuspendLayout();
      this.fpnl_UserInfoDisplay.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnl_Top
      // 
      this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
      this.pnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_Top.Location = new System.Drawing.Point(0, 0);
      this.pnl_Top.Name = "pnl_Top";
      this.pnl_Top.Size = new System.Drawing.Size(1070, 69);
      this.pnl_Top.TabIndex = 0;
      // 
      // pnl_Bottom
      // 
      this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
      this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_Bottom.Controls.Add(this.fpnl_UserInfoDisplay);
      this.pnl_Bottom.Controls.Add(this.tc_GuestTabs);
      this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnl_Bottom.Location = new System.Drawing.Point(0, 327);
      this.pnl_Bottom.Name = "pnl_Bottom";
      this.pnl_Bottom.Size = new System.Drawing.Size(1070, 258);
      this.pnl_Bottom.TabIndex = 1;
      // 
      // dgv_DataTable
      // 
      this.dgv_DataTable.AllowUserToAddRows = false;
      this.dgv_DataTable.AllowUserToDeleteRows = false;
      this.dgv_DataTable.AllowUserToResizeColumns = false;
      this.dgv_DataTable.AllowUserToResizeRows = false;
      this.dgv_DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_DataTable.Location = new System.Drawing.Point(0, 0);
      this.dgv_DataTable.Name = "dgv_DataTable";
      this.dgv_DataTable.ReadOnly = true;
      this.dgv_DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_DataTable.Size = new System.Drawing.Size(898, 258);
      this.dgv_DataTable.TabIndex = 0;
      // 
      // fpnl_TableSelectView
      // 
      this.fpnl_TableSelectView.AutoScroll = true;
      this.fpnl_TableSelectView.AutoSize = true;
      this.fpnl_TableSelectView.BackColor = System.Drawing.SystemColors.Control;
      this.fpnl_TableSelectView.Controls.Add(this.lbl_InHouse);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_Arrivals);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_Departures);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_Reservations);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_CheckedOut);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_NoShows);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_Cancelled);
      this.fpnl_TableSelectView.Controls.Add(this.lbl_WaitList);
      this.fpnl_TableSelectView.Controls.Add(this.label8);
      this.fpnl_TableSelectView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fpnl_TableSelectView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.fpnl_TableSelectView.Location = new System.Drawing.Point(0, 0);
      this.fpnl_TableSelectView.Name = "fpnl_TableSelectView";
      this.fpnl_TableSelectView.Padding = new System.Windows.Forms.Padding(15, 20, 20, 20);
      this.fpnl_TableSelectView.Size = new System.Drawing.Size(171, 258);
      this.fpnl_TableSelectView.TabIndex = 0;
      this.fpnl_TableSelectView.WrapContents = false;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(18, 308);
      this.label8.Name = "label8";
      this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
      this.label8.Size = new System.Drawing.Size(0, 33);
      this.label8.TabIndex = 8;
      // 
      // lbl_WaitList
      // 
      this.lbl_WaitList.AutoSize = true;
      this.lbl_WaitList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_WaitList.Location = new System.Drawing.Point(18, 272);
      this.lbl_WaitList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_WaitList.Name = "lbl_WaitList";
      this.lbl_WaitList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_WaitList.Size = new System.Drawing.Size(80, 26);
      this.lbl_WaitList.TabIndex = 7;
      this.lbl_WaitList.Text = "<wait_list>";
      this.lbl_WaitList.Click += new System.EventHandler(this.lbl_WaitList_Click);
      // 
      // lbl_Cancelled
      // 
      this.lbl_Cancelled.AutoSize = true;
      this.lbl_Cancelled.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Cancelled.Location = new System.Drawing.Point(18, 236);
      this.lbl_Cancelled.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_Cancelled.Name = "lbl_Cancelled";
      this.lbl_Cancelled.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_Cancelled.Size = new System.Drawing.Size(87, 26);
      this.lbl_Cancelled.TabIndex = 6;
      this.lbl_Cancelled.Text = "<cancelled>";
      this.lbl_Cancelled.Click += new System.EventHandler(this.lbl_Cancelled_Click);
      // 
      // lbl_NoShows
      // 
      this.lbl_NoShows.AutoSize = true;
      this.lbl_NoShows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_NoShows.Location = new System.Drawing.Point(18, 200);
      this.lbl_NoShows.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_NoShows.Name = "lbl_NoShows";
      this.lbl_NoShows.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_NoShows.Size = new System.Drawing.Size(90, 26);
      this.lbl_NoShows.TabIndex = 5;
      this.lbl_NoShows.Text = "<no_shows>";
      this.lbl_NoShows.Click += new System.EventHandler(this.lbl_NoShows_Click);
      // 
      // lbl_CheckedOut
      // 
      this.lbl_CheckedOut.AutoSize = true;
      this.lbl_CheckedOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_CheckedOut.Location = new System.Drawing.Point(18, 164);
      this.lbl_CheckedOut.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_CheckedOut.Name = "lbl_CheckedOut";
      this.lbl_CheckedOut.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_CheckedOut.Size = new System.Drawing.Size(110, 26);
      this.lbl_CheckedOut.TabIndex = 4;
      this.lbl_CheckedOut.Text = "<checked_out>";
      this.lbl_CheckedOut.Click += new System.EventHandler(this.lbl_CheckedOut_Click);
      // 
      // lbl_Reservations
      // 
      this.lbl_Reservations.AutoSize = true;
      this.lbl_Reservations.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Reservations.Location = new System.Drawing.Point(18, 128);
      this.lbl_Reservations.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_Reservations.Name = "lbl_Reservations";
      this.lbl_Reservations.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_Reservations.Size = new System.Drawing.Size(106, 26);
      this.lbl_Reservations.TabIndex = 3;
      this.lbl_Reservations.Text = "<reservations>";
      this.lbl_Reservations.Click += new System.EventHandler(this.lbl_Reservations_Click);
      // 
      // lbl_Departures
      // 
      this.lbl_Departures.AutoSize = true;
      this.lbl_Departures.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Departures.Location = new System.Drawing.Point(18, 92);
      this.lbl_Departures.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_Departures.Name = "lbl_Departures";
      this.lbl_Departures.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_Departures.Size = new System.Drawing.Size(96, 26);
      this.lbl_Departures.TabIndex = 2;
      this.lbl_Departures.Text = "<departures>";
      this.lbl_Departures.Click += new System.EventHandler(this.lbl_Departures_Click);
      // 
      // lbl_Arrivals
      // 
      this.lbl_Arrivals.AutoSize = true;
      this.lbl_Arrivals.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Arrivals.Location = new System.Drawing.Point(18, 56);
      this.lbl_Arrivals.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_Arrivals.Name = "lbl_Arrivals";
      this.lbl_Arrivals.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_Arrivals.Size = new System.Drawing.Size(72, 26);
      this.lbl_Arrivals.TabIndex = 1;
      this.lbl_Arrivals.Text = "<arrivals>";
      this.lbl_Arrivals.Click += new System.EventHandler(this.lbl_Arrivals_Click);
      // 
      // lbl_InHouse
      // 
      this.lbl_InHouse.AutoSize = true;
      this.lbl_InHouse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_InHouse.Location = new System.Drawing.Point(18, 20);
      this.lbl_InHouse.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
      this.lbl_InHouse.Name = "lbl_InHouse";
      this.lbl_InHouse.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.lbl_InHouse.Size = new System.Drawing.Size(83, 26);
      this.lbl_InHouse.TabIndex = 0;
      this.lbl_InHouse.Text = "<in_house>";
      this.lbl_InHouse.Click += new System.EventHandler(this.lbl_InHouse_Click);
      // 
      // spc_TableContainer
      // 
      this.spc_TableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spc_TableContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.spc_TableContainer.IsSplitterFixed = true;
      this.spc_TableContainer.Location = new System.Drawing.Point(0, 69);
      this.spc_TableContainer.Name = "spc_TableContainer";
      // 
      // spc_TableContainer.Panel1
      // 
      this.spc_TableContainer.Panel1.Controls.Add(this.dgv_DataTable);
      this.spc_TableContainer.Panel1MinSize = 1;
      // 
      // spc_TableContainer.Panel2
      // 
      this.spc_TableContainer.Panel2.Controls.Add(this.fpnl_TableSelectView);
      this.spc_TableContainer.Panel2MinSize = 1;
      this.spc_TableContainer.Size = new System.Drawing.Size(1070, 258);
      this.spc_TableContainer.SplitterDistance = 898;
      this.spc_TableContainer.SplitterWidth = 1;
      this.spc_TableContainer.TabIndex = 3;
      // 
      // tc_GuestTabs
      // 
      this.tc_GuestTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tc_GuestTabs.Controls.Add(this.tab_GuestInfo);
      this.tc_GuestTabs.Controls.Add(this.tab_GuestFolio);
      this.tc_GuestTabs.Dock = System.Windows.Forms.DockStyle.Top;
      this.tc_GuestTabs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc_GuestTabs.Location = new System.Drawing.Point(0, 0);
      this.tc_GuestTabs.Name = "tc_GuestTabs";
      this.tc_GuestTabs.SelectedIndex = 0;
      this.tc_GuestTabs.Size = new System.Drawing.Size(1068, 233);
      this.tc_GuestTabs.TabIndex = 0;
      // 
      // tab_GuestInfo
      // 
      this.tab_GuestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.tab_GuestInfo.Location = new System.Drawing.Point(4, 4);
      this.tab_GuestInfo.Name = "tab_GuestInfo";
      this.tab_GuestInfo.Padding = new System.Windows.Forms.Padding(3);
      this.tab_GuestInfo.Size = new System.Drawing.Size(1060, 207);
      this.tab_GuestInfo.TabIndex = 0;
      this.tab_GuestInfo.Text = "Guest Info";
      // 
      // tab_GuestFolio
      // 
      this.tab_GuestFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.tab_GuestFolio.Location = new System.Drawing.Point(4, 4);
      this.tab_GuestFolio.Name = "tab_GuestFolio";
      this.tab_GuestFolio.Padding = new System.Windows.Forms.Padding(3);
      this.tab_GuestFolio.Size = new System.Drawing.Size(1060, 207);
      this.tab_GuestFolio.TabIndex = 1;
      this.tab_GuestFolio.Text = "Guest Folio";
      // 
      // fpnl_UserInfoDisplay
      // 
      this.fpnl_UserInfoDisplay.Controls.Add(this.lbl_UserFullName);
      this.fpnl_UserInfoDisplay.Controls.Add(this.lbl_Username);
      this.fpnl_UserInfoDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.fpnl_UserInfoDisplay.Location = new System.Drawing.Point(0, 237);
      this.fpnl_UserInfoDisplay.Name = "fpnl_UserInfoDisplay";
      this.fpnl_UserInfoDisplay.Size = new System.Drawing.Size(1068, 19);
      this.fpnl_UserInfoDisplay.TabIndex = 1;
      // 
      // lbl_UserFullName
      // 
      this.lbl_UserFullName.AutoSize = true;
      this.lbl_UserFullName.Location = new System.Drawing.Point(3, 0);
      this.lbl_UserFullName.Name = "lbl_UserFullName";
      this.lbl_UserFullName.Size = new System.Drawing.Size(64, 13);
      this.lbl_UserFullName.TabIndex = 0;
      this.lbl_UserFullName.Text = "<full_name>";
      // 
      // lbl_Username
      // 
      this.lbl_Username.AutoSize = true;
      this.lbl_Username.Location = new System.Drawing.Point(73, 0);
      this.lbl_Username.Name = "lbl_Username";
      this.lbl_Username.Size = new System.Drawing.Size(71, 13);
      this.lbl_Username.TabIndex = 2;
      this.lbl_Username.Text = "(<username>)";
      // 
      // HomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(1070, 585);
      this.Controls.Add(this.spc_TableContainer);
      this.Controls.Add(this.pnl_Bottom);
      this.Controls.Add(this.pnl_Top);
      this.MinimumSize = new System.Drawing.Size(1086, 624);
      this.Name = "HomeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NoteView";
      this.Load += new System.EventHandler(this.HomeForm_Load);
      this.pnl_Bottom.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_DataTable)).EndInit();
      this.fpnl_TableSelectView.ResumeLayout(false);
      this.fpnl_TableSelectView.PerformLayout();
      this.spc_TableContainer.Panel1.ResumeLayout(false);
      this.spc_TableContainer.Panel2.ResumeLayout(false);
      this.spc_TableContainer.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spc_TableContainer)).EndInit();
      this.spc_TableContainer.ResumeLayout(false);
      this.tc_GuestTabs.ResumeLayout(false);
      this.fpnl_UserInfoDisplay.ResumeLayout(false);
      this.fpnl_UserInfoDisplay.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnl_Top;
    private System.Windows.Forms.Panel pnl_Bottom;
    private System.Windows.Forms.DataGridView dgv_DataTable;
    private System.Windows.Forms.FlowLayoutPanel fpnl_TableSelectView;
    private System.Windows.Forms.Label lbl_InHouse;
    private System.Windows.Forms.Label lbl_Arrivals;
    private System.Windows.Forms.Label lbl_Departures;
    private System.Windows.Forms.Label lbl_Reservations;
    private System.Windows.Forms.Label lbl_CheckedOut;
    private System.Windows.Forms.Label lbl_NoShows;
    private System.Windows.Forms.Label lbl_Cancelled;
    private System.Windows.Forms.Label lbl_WaitList;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.SplitContainer spc_TableContainer;
    private System.Windows.Forms.TabControl tc_GuestTabs;
    private System.Windows.Forms.TabPage tab_GuestInfo;
    private System.Windows.Forms.TabPage tab_GuestFolio;
    private System.Windows.Forms.FlowLayoutPanel fpnl_UserInfoDisplay;
    private System.Windows.Forms.Label lbl_UserFullName;
    private System.Windows.Forms.Label lbl_Username;
  }
}