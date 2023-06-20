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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
      this.pnl_Bottom = new System.Windows.Forms.Panel();
      this.fpnl_UserInfoDisplay = new System.Windows.Forms.FlowLayoutPanel();
      this.lbl_UserFullName = new System.Windows.Forms.Label();
      this.lbl_Username = new System.Windows.Forms.Label();
      this.lbl_DateTimeIndicator = new System.Windows.Forms.Label();
      this.tc_GuestTabs = new System.Windows.Forms.TabControl();
      this.tab_GuestInfo = new System.Windows.Forms.TabPage();
      this.sc_GuestInfo = new System.Windows.Forms.SplitContainer();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbl_iLastName = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_iFirstName = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbl_iTitle = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.lbl_iZip = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lbl_iCountry = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.lbl_iCity = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.lbl_iStreet = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lbl_iEmail = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lbl_iMobile = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lbl_iTelephone = new System.Windows.Forms.Label();
      this.pnl_NotesBorder = new System.Windows.Forms.Panel();
      this.rtxt_Notes = new System.Windows.Forms.RichTextBox();
      this.label18 = new System.Windows.Forms.Label();
      this.dgv_DataTable = new System.Windows.Forms.DataGridView();
      this.fpnl_TableSelectView = new System.Windows.Forms.FlowLayoutPanel();
      this.lbl_InHouse = new System.Windows.Forms.Label();
      this.lbl_Arrivals = new System.Windows.Forms.Label();
      this.lbl_Departures = new System.Windows.Forms.Label();
      this.lbl_Reservations = new System.Windows.Forms.Label();
      this.lbl_CheckedOut = new System.Windows.Forms.Label();
      this.lbl_NoShows = new System.Windows.Forms.Label();
      this.lbl_Cancelled = new System.Windows.Forms.Label();
      this.lbl_WaitList = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.spc_TableContainer = new System.Windows.Forms.SplitContainer();
      this.bwork_TableFetcher = new System.ComponentModel.BackgroundWorker();
      this.bwork_TableResolver = new System.ComponentModel.BackgroundWorker();
      this.bwork_InfoGetter = new System.ComponentModel.BackgroundWorker();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.frontDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.systemConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.label17 = new System.Windows.Forms.Label();
      this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
      this.label39 = new System.Windows.Forms.Label();
      this.pnl_Top = new System.Windows.Forms.Panel();
      this.pcmd_Charges = new NoteView.PictureButton();
      this.pcmd_NewBooking = new NoteView.PictureButton();
      this.pnl_Bottom.SuspendLayout();
      this.fpnl_UserInfoDisplay.SuspendLayout();
      this.tc_GuestTabs.SuspendLayout();
      this.tab_GuestInfo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sc_GuestInfo)).BeginInit();
      this.sc_GuestInfo.Panel1.SuspendLayout();
      this.sc_GuestInfo.Panel2.SuspendLayout();
      this.sc_GuestInfo.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.pnl_NotesBorder.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_DataTable)).BeginInit();
      this.fpnl_TableSelectView.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spc_TableContainer)).BeginInit();
      this.spc_TableContainer.Panel1.SuspendLayout();
      this.spc_TableContainer.Panel2.SuspendLayout();
      this.spc_TableContainer.SuspendLayout();
      this.mainMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.flowLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel5.SuspendLayout();
      this.pnl_Top.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_Charges)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_NewBooking)).BeginInit();
      this.SuspendLayout();
      // 
      // pnl_Bottom
      // 
      this.pnl_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
      this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_Bottom.Controls.Add(this.fpnl_UserInfoDisplay);
      this.pnl_Bottom.Controls.Add(this.tc_GuestTabs);
      this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnl_Bottom.Location = new System.Drawing.Point(0, 531);
      this.pnl_Bottom.Margin = new System.Windows.Forms.Padding(4);
      this.pnl_Bottom.Name = "pnl_Bottom";
      this.pnl_Bottom.Size = new System.Drawing.Size(1792, 356);
      this.pnl_Bottom.TabIndex = 1;
      // 
      // fpnl_UserInfoDisplay
      // 
      this.fpnl_UserInfoDisplay.Controls.Add(this.lbl_UserFullName);
      this.fpnl_UserInfoDisplay.Controls.Add(this.lbl_Username);
      this.fpnl_UserInfoDisplay.Controls.Add(this.lbl_DateTimeIndicator);
      this.fpnl_UserInfoDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.fpnl_UserInfoDisplay.Location = new System.Drawing.Point(0, 331);
      this.fpnl_UserInfoDisplay.Margin = new System.Windows.Forms.Padding(4);
      this.fpnl_UserInfoDisplay.Name = "fpnl_UserInfoDisplay";
      this.fpnl_UserInfoDisplay.Size = new System.Drawing.Size(1790, 23);
      this.fpnl_UserInfoDisplay.TabIndex = 1;
      // 
      // lbl_UserFullName
      // 
      this.lbl_UserFullName.AutoSize = true;
      this.lbl_UserFullName.Location = new System.Drawing.Point(4, 0);
      this.lbl_UserFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_UserFullName.Name = "lbl_UserFullName";
      this.lbl_UserFullName.Size = new System.Drawing.Size(78, 16);
      this.lbl_UserFullName.TabIndex = 0;
      this.lbl_UserFullName.Text = "<full_name>";
      // 
      // lbl_Username
      // 
      this.lbl_Username.AutoSize = true;
      this.lbl_Username.Location = new System.Drawing.Point(90, 0);
      this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbl_Username.Name = "lbl_Username";
      this.lbl_Username.Size = new System.Drawing.Size(89, 16);
      this.lbl_Username.TabIndex = 2;
      this.lbl_Username.Text = "(<username>)";
      // 
      // lbl_DateTimeIndicator
      // 
      this.lbl_DateTimeIndicator.AutoSize = true;
      this.lbl_DateTimeIndicator.Location = new System.Drawing.Point(186, 0);
      this.lbl_DateTimeIndicator.Name = "lbl_DateTimeIndicator";
      this.lbl_DateTimeIndicator.Size = new System.Drawing.Size(126, 16);
      this.lbl_DateTimeIndicator.TabIndex = 3;
      this.lbl_DateTimeIndicator.Text = "<session date time>";
      // 
      // tc_GuestTabs
      // 
      this.tc_GuestTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
      this.tc_GuestTabs.Controls.Add(this.tab_GuestInfo);
      this.tc_GuestTabs.Dock = System.Windows.Forms.DockStyle.Top;
      this.tc_GuestTabs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc_GuestTabs.HotTrack = true;
      this.tc_GuestTabs.Location = new System.Drawing.Point(0, 0);
      this.tc_GuestTabs.Margin = new System.Windows.Forms.Padding(4);
      this.tc_GuestTabs.MinimumSize = new System.Drawing.Size(1, 1);
      this.tc_GuestTabs.Name = "tc_GuestTabs";
      this.tc_GuestTabs.SelectedIndex = 0;
      this.tc_GuestTabs.Size = new System.Drawing.Size(1790, 327);
      this.tc_GuestTabs.TabIndex = 0;
      this.tc_GuestTabs.TabStop = false;
      // 
      // tab_GuestInfo
      // 
      this.tab_GuestInfo.AutoScroll = true;
      this.tab_GuestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.tab_GuestInfo.Controls.Add(this.sc_GuestInfo);
      this.tab_GuestInfo.Location = new System.Drawing.Point(4, 4);
      this.tab_GuestInfo.Margin = new System.Windows.Forms.Padding(4);
      this.tab_GuestInfo.Name = "tab_GuestInfo";
      this.tab_GuestInfo.Padding = new System.Windows.Forms.Padding(4);
      this.tab_GuestInfo.Size = new System.Drawing.Size(1782, 297);
      this.tab_GuestInfo.TabIndex = 0;
      this.tab_GuestInfo.Text = "Guest Info";
      // 
      // sc_GuestInfo
      // 
      this.sc_GuestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(191)))), ((int)(((byte)(172)))));
      this.sc_GuestInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sc_GuestInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.sc_GuestInfo.IsSplitterFixed = true;
      this.sc_GuestInfo.Location = new System.Drawing.Point(4, 4);
      this.sc_GuestInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.sc_GuestInfo.Name = "sc_GuestInfo";
      // 
      // sc_GuestInfo.Panel1
      // 
      this.sc_GuestInfo.Panel1.Controls.Add(this.flowLayoutPanel1);
      // 
      // sc_GuestInfo.Panel2
      // 
      this.sc_GuestInfo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(171)))), ((int)(((byte)(152)))));
      this.sc_GuestInfo.Panel2.Controls.Add(this.pnl_NotesBorder);
      this.sc_GuestInfo.Size = new System.Drawing.Size(1774, 289);
      this.sc_GuestInfo.SplitterDistance = 1546;
      this.sc_GuestInfo.SplitterWidth = 1;
      this.sc_GuestInfo.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.AutoScroll = true;
      this.flowLayoutPanel1.AutoSize = true;
      this.flowLayoutPanel1.Controls.Add(this.groupBox4);
      this.flowLayoutPanel1.Controls.Add(this.groupBox2);
      this.flowLayoutPanel1.Controls.Add(this.groupBox1);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(1546, 289);
      this.flowLayoutPanel1.TabIndex = 1;
      // 
      // groupBox4
      // 
      this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupBox4.AutoSize = true;
      this.groupBox4.Controls.Add(this.label1);
      this.groupBox4.Controls.Add(this.lbl_iLastName);
      this.groupBox4.Controls.Add(this.label2);
      this.groupBox4.Controls.Add(this.lbl_iFirstName);
      this.groupBox4.Controls.Add(this.label3);
      this.groupBox4.Controls.Add(this.lbl_iTitle);
      this.groupBox4.ForeColor = System.Drawing.SystemColors.InfoText;
      this.groupBox4.Location = new System.Drawing.Point(3, 14);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox4.Size = new System.Drawing.Size(250, 133);
      this.groupBox4.TabIndex = 9;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label1.Location = new System.Drawing.Point(63, 33);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label1.Size = new System.Drawing.Size(57, 28);
      this.label1.TabIndex = 0;
      this.label1.Text = "Title:";
      // 
      // lbl_iLastName
      // 
      this.lbl_iLastName.AutoSize = true;
      this.lbl_iLastName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iLastName.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iLastName.Location = new System.Drawing.Point(131, 85);
      this.lbl_iLastName.Name = "lbl_iLastName";
      this.lbl_iLastName.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iLastName.Size = new System.Drawing.Size(113, 28);
      this.lbl_iLastName.TabIndex = 5;
      this.lbl_iLastName.Text = "Select a Row";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.Location = new System.Drawing.Point(5, 58);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label2.Size = new System.Drawing.Size(112, 28);
      this.label2.TabIndex = 1;
      this.label2.Text = "First Name:";
      // 
      // lbl_iFirstName
      // 
      this.lbl_iFirstName.AutoSize = true;
      this.lbl_iFirstName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iFirstName.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iFirstName.Location = new System.Drawing.Point(131, 58);
      this.lbl_iFirstName.Name = "lbl_iFirstName";
      this.lbl_iFirstName.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iFirstName.Size = new System.Drawing.Size(113, 28);
      this.lbl_iFirstName.TabIndex = 4;
      this.lbl_iFirstName.Text = "Select a Row";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label3.Location = new System.Drawing.Point(8, 86);
      this.label3.Name = "label3";
      this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label3.Size = new System.Drawing.Size(111, 28);
      this.label3.TabIndex = 2;
      this.label3.Text = "Last Name:";
      // 
      // lbl_iTitle
      // 
      this.lbl_iTitle.AutoSize = true;
      this.lbl_iTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iTitle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iTitle.Location = new System.Drawing.Point(131, 33);
      this.lbl_iTitle.Name = "lbl_iTitle";
      this.lbl_iTitle.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iTitle.Size = new System.Drawing.Size(113, 28);
      this.lbl_iTitle.TabIndex = 3;
      this.lbl_iTitle.Text = "Select a Row";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupBox2.AutoSize = true;
      this.groupBox2.Controls.Add(this.lbl_iZip);
      this.groupBox2.Controls.Add(this.label19);
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Controls.Add(this.lbl_iCountry);
      this.groupBox2.Controls.Add(this.label13);
      this.groupBox2.Controls.Add(this.lbl_iCity);
      this.groupBox2.Controls.Add(this.label15);
      this.groupBox2.Controls.Add(this.lbl_iStreet);
      this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
      this.groupBox2.Location = new System.Drawing.Point(259, 2);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Size = new System.Drawing.Size(223, 158);
      this.groupBox2.TabIndex = 11;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Address";
      // 
      // lbl_iZip
      // 
      this.lbl_iZip.AutoSize = true;
      this.lbl_iZip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iZip.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iZip.Location = new System.Drawing.Point(104, 111);
      this.lbl_iZip.Name = "lbl_iZip";
      this.lbl_iZip.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iZip.Size = new System.Drawing.Size(113, 28);
      this.lbl_iZip.TabIndex = 7;
      this.lbl_iZip.Text = "Select a Row";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label19.Location = new System.Drawing.Point(48, 111);
      this.label19.Name = "label19";
      this.label19.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label19.Size = new System.Drawing.Size(46, 28);
      this.label19.TabIndex = 6;
      this.label19.Text = "Zip:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label11.Location = new System.Drawing.Point(20, 33);
      this.label11.Name = "label11";
      this.label11.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label11.Size = new System.Drawing.Size(74, 28);
      this.label11.TabIndex = 0;
      this.label11.Text = "Street:";
      // 
      // lbl_iCountry
      // 
      this.lbl_iCountry.AutoSize = true;
      this.lbl_iCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iCountry.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iCountry.Location = new System.Drawing.Point(104, 86);
      this.lbl_iCountry.Name = "lbl_iCountry";
      this.lbl_iCountry.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iCountry.Size = new System.Drawing.Size(113, 28);
      this.lbl_iCountry.TabIndex = 5;
      this.lbl_iCountry.Text = "Select a Row";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label13.Location = new System.Drawing.Point(40, 60);
      this.label13.Name = "label13";
      this.label13.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label13.Size = new System.Drawing.Size(54, 28);
      this.label13.TabIndex = 1;
      this.label13.Text = "City:";
      // 
      // lbl_iCity
      // 
      this.lbl_iCity.AutoSize = true;
      this.lbl_iCity.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iCity.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iCity.Location = new System.Drawing.Point(104, 60);
      this.lbl_iCity.Name = "lbl_iCity";
      this.lbl_iCity.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iCity.Size = new System.Drawing.Size(113, 28);
      this.lbl_iCity.TabIndex = 4;
      this.lbl_iCity.Text = "Select a Row";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label15.Location = new System.Drawing.Point(5, 86);
      this.label15.Name = "label15";
      this.label15.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label15.Size = new System.Drawing.Size(87, 28);
      this.label15.TabIndex = 2;
      this.label15.Text = "Country:";
      // 
      // lbl_iStreet
      // 
      this.lbl_iStreet.AutoSize = true;
      this.lbl_iStreet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iStreet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iStreet.Location = new System.Drawing.Point(104, 33);
      this.lbl_iStreet.Name = "lbl_iStreet";
      this.lbl_iStreet.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iStreet.Size = new System.Drawing.Size(113, 28);
      this.lbl_iStreet.TabIndex = 3;
      this.lbl_iStreet.Text = "Select a Row";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.lbl_iEmail);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.lbl_iMobile);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.lbl_iTelephone);
      this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
      this.groupBox1.Location = new System.Drawing.Point(488, 15);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Size = new System.Drawing.Size(244, 132);
      this.groupBox1.TabIndex = 10;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Contact";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label4.Location = new System.Drawing.Point(5, 33);
      this.label4.Name = "label4";
      this.label4.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label4.Size = new System.Drawing.Size(106, 28);
      this.label4.TabIndex = 0;
      this.label4.Text = "Telephone:";
      // 
      // lbl_iEmail
      // 
      this.lbl_iEmail.AutoSize = true;
      this.lbl_iEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iEmail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iEmail.Location = new System.Drawing.Point(125, 85);
      this.lbl_iEmail.Name = "lbl_iEmail";
      this.lbl_iEmail.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iEmail.Size = new System.Drawing.Size(113, 28);
      this.lbl_iEmail.TabIndex = 5;
      this.lbl_iEmail.Text = "Select a Row";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label6.Location = new System.Drawing.Point(39, 58);
      this.label6.Name = "label6";
      this.label6.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label6.Size = new System.Drawing.Size(74, 28);
      this.label6.TabIndex = 1;
      this.label6.Text = "Mobile:";
      // 
      // lbl_iMobile
      // 
      this.lbl_iMobile.AutoSize = true;
      this.lbl_iMobile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iMobile.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iMobile.Location = new System.Drawing.Point(125, 58);
      this.lbl_iMobile.Name = "lbl_iMobile";
      this.lbl_iMobile.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iMobile.Size = new System.Drawing.Size(113, 28);
      this.lbl_iMobile.TabIndex = 4;
      this.lbl_iMobile.Text = "Select a Row";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label9.Location = new System.Drawing.Point(40, 85);
      this.label9.Name = "label9";
      this.label9.Padding = new System.Windows.Forms.Padding(5, 5, 3, 5);
      this.label9.Size = new System.Drawing.Size(73, 28);
      this.label9.TabIndex = 2;
      this.label9.Text = "E-mail:";
      // 
      // lbl_iTelephone
      // 
      this.lbl_iTelephone.AutoSize = true;
      this.lbl_iTelephone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_iTelephone.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_iTelephone.Location = new System.Drawing.Point(125, 31);
      this.lbl_iTelephone.Name = "lbl_iTelephone";
      this.lbl_iTelephone.Padding = new System.Windows.Forms.Padding(3, 5, 5, 5);
      this.lbl_iTelephone.Size = new System.Drawing.Size(113, 28);
      this.lbl_iTelephone.TabIndex = 3;
      this.lbl_iTelephone.Text = "Select a Row";
      // 
      // pnl_NotesBorder
      // 
      this.pnl_NotesBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pnl_NotesBorder.Controls.Add(this.rtxt_Notes);
      this.pnl_NotesBorder.Controls.Add(this.label18);
      this.pnl_NotesBorder.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_NotesBorder.Location = new System.Drawing.Point(0, 0);
      this.pnl_NotesBorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_NotesBorder.Name = "pnl_NotesBorder";
      this.pnl_NotesBorder.Size = new System.Drawing.Size(227, 289);
      this.pnl_NotesBorder.TabIndex = 0;
      // 
      // rtxt_Notes
      // 
      this.rtxt_Notes.Cursor = System.Windows.Forms.Cursors.Default;
      this.rtxt_Notes.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.rtxt_Notes.Location = new System.Drawing.Point(0, 31);
      this.rtxt_Notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rtxt_Notes.Name = "rtxt_Notes";
      this.rtxt_Notes.ReadOnly = true;
      this.rtxt_Notes.Size = new System.Drawing.Size(223, 254);
      this.rtxt_Notes.TabIndex = 1;
      this.rtxt_Notes.Text = "";
      this.rtxt_Notes.WordWrap = false;
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Location = new System.Drawing.Point(7, 6);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(52, 17);
      this.label18.TabIndex = 0;
      this.label18.Text = "Notes";
      // 
      // dgv_DataTable
      // 
      this.dgv_DataTable.AllowUserToAddRows = false;
      this.dgv_DataTable.AllowUserToDeleteRows = false;
      this.dgv_DataTable.AllowUserToResizeColumns = false;
      this.dgv_DataTable.AllowUserToResizeRows = false;
      this.dgv_DataTable.ColumnHeadersHeight = 29;
      this.dgv_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_DataTable.Location = new System.Drawing.Point(0, 0);
      this.dgv_DataTable.Margin = new System.Windows.Forms.Padding(4);
      this.dgv_DataTable.Name = "dgv_DataTable";
      this.dgv_DataTable.ReadOnly = true;
      this.dgv_DataTable.RowHeadersWidth = 51;
      this.dgv_DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_DataTable.Size = new System.Drawing.Size(1635, 368);
      this.dgv_DataTable.TabIndex = 0;
      this.dgv_DataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DataTable_CellClick);
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
      this.fpnl_TableSelectView.Margin = new System.Windows.Forms.Padding(4);
      this.fpnl_TableSelectView.Name = "fpnl_TableSelectView";
      this.fpnl_TableSelectView.Padding = new System.Windows.Forms.Padding(20, 25, 27, 25);
      this.fpnl_TableSelectView.Size = new System.Drawing.Size(156, 368);
      this.fpnl_TableSelectView.TabIndex = 0;
      this.fpnl_TableSelectView.WrapContents = false;
      // 
      // lbl_InHouse
      // 
      this.lbl_InHouse.AutoSize = true;
      this.lbl_InHouse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_InHouse.Location = new System.Drawing.Point(24, 25);
      this.lbl_InHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_InHouse.Name = "lbl_InHouse";
      this.lbl_InHouse.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_InHouse.Size = new System.Drawing.Size(71, 52);
      this.lbl_InHouse.TabIndex = 0;
      this.lbl_InHouse.Text = "<in_house>";
      this.lbl_InHouse.Click += new System.EventHandler(this.lbl_InHouse_Click);
      // 
      // lbl_Arrivals
      // 
      this.lbl_Arrivals.AutoSize = true;
      this.lbl_Arrivals.Enabled = false;
      this.lbl_Arrivals.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Arrivals.Location = new System.Drawing.Point(24, 89);
      this.lbl_Arrivals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_Arrivals.Name = "lbl_Arrivals";
      this.lbl_Arrivals.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_Arrivals.Size = new System.Drawing.Size(77, 52);
      this.lbl_Arrivals.TabIndex = 1;
      this.lbl_Arrivals.Text = "<arrivals>";
      this.lbl_Arrivals.Click += new System.EventHandler(this.lbl_Arrivals_Click);
      // 
      // lbl_Departures
      // 
      this.lbl_Departures.AutoSize = true;
      this.lbl_Departures.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Departures.Location = new System.Drawing.Point(24, 153);
      this.lbl_Departures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_Departures.Name = "lbl_Departures";
      this.lbl_Departures.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_Departures.Size = new System.Drawing.Size(79, 52);
      this.lbl_Departures.TabIndex = 2;
      this.lbl_Departures.Text = "<departures>";
      this.lbl_Departures.Click += new System.EventHandler(this.lbl_Departures_Click);
      // 
      // lbl_Reservations
      // 
      this.lbl_Reservations.AutoSize = true;
      this.lbl_Reservations.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Reservations.Location = new System.Drawing.Point(24, 217);
      this.lbl_Reservations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_Reservations.Name = "lbl_Reservations";
      this.lbl_Reservations.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_Reservations.Size = new System.Drawing.Size(76, 52);
      this.lbl_Reservations.TabIndex = 3;
      this.lbl_Reservations.Text = "<reservations>";
      this.lbl_Reservations.Click += new System.EventHandler(this.lbl_Reservations_Click);
      // 
      // lbl_CheckedOut
      // 
      this.lbl_CheckedOut.AutoSize = true;
      this.lbl_CheckedOut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_CheckedOut.Location = new System.Drawing.Point(24, 281);
      this.lbl_CheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_CheckedOut.Name = "lbl_CheckedOut";
      this.lbl_CheckedOut.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_CheckedOut.Size = new System.Drawing.Size(72, 72);
      this.lbl_CheckedOut.TabIndex = 4;
      this.lbl_CheckedOut.Text = "<checked_out>";
      this.lbl_CheckedOut.Visible = false;
      this.lbl_CheckedOut.Click += new System.EventHandler(this.lbl_CheckedOut_Click);
      // 
      // lbl_NoShows
      // 
      this.lbl_NoShows.AutoSize = true;
      this.lbl_NoShows.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_NoShows.Location = new System.Drawing.Point(24, 365);
      this.lbl_NoShows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_NoShows.Name = "lbl_NoShows";
      this.lbl_NoShows.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_NoShows.Size = new System.Drawing.Size(75, 52);
      this.lbl_NoShows.TabIndex = 5;
      this.lbl_NoShows.Text = "<no_shows>";
      this.lbl_NoShows.Visible = false;
      this.lbl_NoShows.Click += new System.EventHandler(this.lbl_NoShows_Click);
      // 
      // lbl_Cancelled
      // 
      this.lbl_Cancelled.AutoSize = true;
      this.lbl_Cancelled.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Cancelled.Location = new System.Drawing.Point(24, 429);
      this.lbl_Cancelled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_Cancelled.Name = "lbl_Cancelled";
      this.lbl_Cancelled.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_Cancelled.Size = new System.Drawing.Size(77, 52);
      this.lbl_Cancelled.TabIndex = 6;
      this.lbl_Cancelled.Text = "<cancelled>";
      this.lbl_Cancelled.Visible = false;
      this.lbl_Cancelled.Click += new System.EventHandler(this.lbl_Cancelled_Click);
      // 
      // lbl_WaitList
      // 
      this.lbl_WaitList.AutoSize = true;
      this.lbl_WaitList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_WaitList.Location = new System.Drawing.Point(24, 493);
      this.lbl_WaitList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
      this.lbl_WaitList.Name = "lbl_WaitList";
      this.lbl_WaitList.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
      this.lbl_WaitList.Size = new System.Drawing.Size(80, 52);
      this.lbl_WaitList.TabIndex = 7;
      this.lbl_WaitList.Text = "<wait_list>";
      this.lbl_WaitList.Visible = false;
      this.lbl_WaitList.Click += new System.EventHandler(this.lbl_WaitList_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(24, 557);
      this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
      this.label8.Size = new System.Drawing.Size(0, 41);
      this.label8.TabIndex = 8;
      // 
      // spc_TableContainer
      // 
      this.spc_TableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spc_TableContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.spc_TableContainer.IsSplitterFixed = true;
      this.spc_TableContainer.Location = new System.Drawing.Point(0, 163);
      this.spc_TableContainer.Margin = new System.Windows.Forms.Padding(4);
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
      this.spc_TableContainer.Size = new System.Drawing.Size(1792, 368);
      this.spc_TableContainer.SplitterDistance = 1635;
      this.spc_TableContainer.SplitterWidth = 1;
      this.spc_TableContainer.TabIndex = 3;
      // 
      // bwork_TableFetcher
      // 
      this.bwork_TableFetcher.WorkerReportsProgress = true;
      this.bwork_TableFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_TableFetcher_DoWork);
      this.bwork_TableFetcher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_TableFetcher_ProgressChanged);
      this.bwork_TableFetcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_TableFetcher_RunWorkerCompleted);
      // 
      // bwork_TableResolver
      // 
      this.bwork_TableResolver.WorkerReportsProgress = true;
      this.bwork_TableResolver.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_TableResolver_DoWork);
      this.bwork_TableResolver.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_TableResolver_ProgressChanged);
      this.bwork_TableResolver.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_TableResolver_RunWorkerCompleted);
      // 
      // bwork_InfoGetter
      // 
      this.bwork_InfoGetter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_InfoGetter_DoWork);
      this.bwork_InfoGetter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_InfoGetter_RunWorkerCompleted);
      // 
      // mainMenu
      // 
      this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontDeskToolStripMenuItem,
            this.systemConfigurationToolStripMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.mainMenu.Size = new System.Drawing.Size(1790, 30);
      this.mainMenu.TabIndex = 0;
      this.mainMenu.Text = "menuStrip1";
      // 
      // frontDeskToolStripMenuItem
      // 
      this.frontDeskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.frontDeskToolStripMenuItem.Name = "frontDeskToolStripMenuItem";
      this.frontDeskToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
      this.frontDeskToolStripMenuItem.Text = "Front Desk";
      // 
      // changePasswordToolStripMenuItem
      // 
      this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
      this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
      this.changePasswordToolStripMenuItem.Text = "Change Password";
      this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // systemConfigurationToolStripMenuItem
      // 
      this.systemConfigurationToolStripMenuItem.Name = "systemConfigurationToolStripMenuItem";
      this.systemConfigurationToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
      this.systemConfigurationToolStripMenuItem.Text = "System Configuration";
      this.systemConfigurationToolStripMenuItem.Click += new System.EventHandler(this.systemConfigurationToolStripMenuItem_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox1.Location = new System.Drawing.Point(1418, 48);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(361, 97);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.pcmd_NewBooking);
      this.flowLayoutPanel2.Controls.Add(this.label17);
      this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 38);
      this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(104, 117);
      this.flowLayoutPanel2.TabIndex = 2;
      // 
      // label17
      // 
      this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.ForeColor = System.Drawing.Color.Navy;
      this.label17.Location = new System.Drawing.Point(4, 97);
      this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(96, 21);
      this.label17.TabIndex = 1;
      this.label17.Text = "New Booking";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // flowLayoutPanel5
      // 
      this.flowLayoutPanel5.Controls.Add(this.pcmd_Charges);
      this.flowLayoutPanel5.Controls.Add(this.label39);
      this.flowLayoutPanel5.Location = new System.Drawing.Point(125, 38);
      this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
      this.flowLayoutPanel5.Name = "flowLayoutPanel5";
      this.flowLayoutPanel5.Size = new System.Drawing.Size(104, 117);
      this.flowLayoutPanel5.TabIndex = 5;
      // 
      // label39
      // 
      this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label39.ForeColor = System.Drawing.Color.Navy;
      this.label39.Location = new System.Drawing.Point(4, 97);
      this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(96, 21);
      this.label39.TabIndex = 1;
      this.label39.Text = "Charges";
      this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pnl_Top
      // 
      this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
      this.pnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_Top.Controls.Add(this.flowLayoutPanel5);
      this.pnl_Top.Controls.Add(this.flowLayoutPanel2);
      this.pnl_Top.Controls.Add(this.pictureBox1);
      this.pnl_Top.Controls.Add(this.mainMenu);
      this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_Top.Location = new System.Drawing.Point(0, 0);
      this.pnl_Top.Margin = new System.Windows.Forms.Padding(4);
      this.pnl_Top.Name = "pnl_Top";
      this.pnl_Top.Size = new System.Drawing.Size(1792, 163);
      this.pnl_Top.TabIndex = 0;
      // 
      // pcmd_Charges
      // 
      this.pcmd_Charges.BackgroundImage = global::NoteView.Properties.Resources.post_charges;
      this.pcmd_Charges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_Charges.Location = new System.Drawing.Point(4, 4);
      this.pcmd_Charges.Margin = new System.Windows.Forms.Padding(4);
      this.pcmd_Charges.Name = "pcmd_Charges";
      this.pcmd_Charges.Size = new System.Drawing.Size(96, 89);
      this.pcmd_Charges.TabIndex = 3;
      this.pcmd_Charges.TabStop = false;
      this.pcmd_Charges.Click += new System.EventHandler(this.pcmd_Charges_Click);
      // 
      // pcmd_NewBooking
      // 
      this.pcmd_NewBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcmd_NewBooking.BackgroundImage")));
      this.pcmd_NewBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_NewBooking.Location = new System.Drawing.Point(4, 4);
      this.pcmd_NewBooking.Margin = new System.Windows.Forms.Padding(4);
      this.pcmd_NewBooking.Name = "pcmd_NewBooking";
      this.pcmd_NewBooking.Size = new System.Drawing.Size(96, 89);
      this.pcmd_NewBooking.TabIndex = 3;
      this.pcmd_NewBooking.TabStop = false;
      this.pcmd_NewBooking.Click += new System.EventHandler(this.pcmd_NewBooking_Click);
      // 
      // HomeForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.ClientSize = new System.Drawing.Size(1792, 887);
      this.Controls.Add(this.spc_TableContainer);
      this.Controls.Add(this.pnl_Bottom);
      this.Controls.Add(this.pnl_Top);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(1363, 724);
      this.Name = "HomeForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "NoteView";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
      this.Load += new System.EventHandler(this.HomeForm_Load);
      this.pnl_Bottom.ResumeLayout(false);
      this.fpnl_UserInfoDisplay.ResumeLayout(false);
      this.fpnl_UserInfoDisplay.PerformLayout();
      this.tc_GuestTabs.ResumeLayout(false);
      this.tab_GuestInfo.ResumeLayout(false);
      this.sc_GuestInfo.Panel1.ResumeLayout(false);
      this.sc_GuestInfo.Panel1.PerformLayout();
      this.sc_GuestInfo.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.sc_GuestInfo)).EndInit();
      this.sc_GuestInfo.ResumeLayout(false);
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.pnl_NotesBorder.ResumeLayout(false);
      this.pnl_NotesBorder.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_DataTable)).EndInit();
      this.fpnl_TableSelectView.ResumeLayout(false);
      this.fpnl_TableSelectView.PerformLayout();
      this.spc_TableContainer.Panel1.ResumeLayout(false);
      this.spc_TableContainer.Panel2.ResumeLayout(false);
      this.spc_TableContainer.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spc_TableContainer)).EndInit();
      this.spc_TableContainer.ResumeLayout(false);
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel5.ResumeLayout(false);
      this.pnl_Top.ResumeLayout(false);
      this.pnl_Top.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_Charges)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_NewBooking)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
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
    private System.Windows.Forms.FlowLayoutPanel fpnl_UserInfoDisplay;
    private System.Windows.Forms.Label lbl_UserFullName;
    private System.Windows.Forms.Label lbl_Username;
    private System.Windows.Forms.Label lbl_DateTimeIndicator;
    private System.ComponentModel.BackgroundWorker bwork_TableFetcher;
    private System.ComponentModel.BackgroundWorker bwork_TableResolver;
    private System.Windows.Forms.TabControl tc_GuestTabs;
    private System.Windows.Forms.TabPage tab_GuestInfo;
    private System.Windows.Forms.SplitContainer sc_GuestInfo;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbl_iLastName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_iFirstName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbl_iTitle;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label lbl_iZip;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lbl_iCountry;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label lbl_iCity;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label lbl_iStreet;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lbl_iEmail;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lbl_iMobile;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lbl_iTelephone;
    private System.Windows.Forms.Panel pnl_NotesBorder;
    private System.Windows.Forms.RichTextBox rtxt_Notes;
    private System.Windows.Forms.Label label18;
    private System.ComponentModel.BackgroundWorker bwork_InfoGetter;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem frontDeskToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem systemConfigurationToolStripMenuItem;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private PictureButton pcmd_NewBooking;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    private PictureButton pcmd_Charges;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.Panel pnl_Top;
  }
}