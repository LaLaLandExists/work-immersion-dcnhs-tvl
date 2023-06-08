namespace NoteView
{
  partial class SystemConfiguration
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
      this.gb_RoomConfiguration = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cmd_Add = new System.Windows.Forms.Button();
      this.txt_Capacity = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txt_Rate = new System.Windows.Forms.TextBox();
      this.txt_RoomType = new System.Windows.Forms.TextBox();
      this.txt_RoomNo = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cmd_Remove = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.pcmd_RoomSearch = new NoteView.PictureButton();
      this.txt_RoomSearch = new System.Windows.Forms.TextBox();
      this.gb_RoomTable = new System.Windows.Forms.GroupBox();
      this.sstrip_Indicator = new System.Windows.Forms.StatusStrip();
      this.tsstrip_Indicator = new System.Windows.Forms.ToolStripStatusLabel();
      this.dgv_Rooms = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.roomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bwork_RoomFetcher = new System.ComponentModel.BackgroundWorker();
      this.bwork_RoomDeleter = new System.ComponentModel.BackgroundWorker();
      this.gb_RoomConfiguration.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomSearch)).BeginInit();
      this.gb_RoomTable.SuspendLayout();
      this.sstrip_Indicator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).BeginInit();
      this.SuspendLayout();
      // 
      // gb_RoomConfiguration
      // 
      this.gb_RoomConfiguration.Controls.Add(this.panel1);
      this.gb_RoomConfiguration.Controls.Add(this.cmd_Remove);
      this.gb_RoomConfiguration.Controls.Add(this.groupBox2);
      this.gb_RoomConfiguration.Controls.Add(this.gb_RoomTable);
      this.gb_RoomConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gb_RoomConfiguration.Location = new System.Drawing.Point(0, 0);
      this.gb_RoomConfiguration.Name = "gb_RoomConfiguration";
      this.gb_RoomConfiguration.Size = new System.Drawing.Size(785, 494);
      this.gb_RoomConfiguration.TabIndex = 0;
      this.gb_RoomConfiguration.TabStop = false;
      this.gb_RoomConfiguration.Text = "Room";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.cmd_Add);
      this.panel1.Controls.Add(this.txt_Capacity);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txt_Rate);
      this.panel1.Controls.Add(this.txt_RoomType);
      this.panel1.Controls.Add(this.txt_RoomNo);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 19);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(214, 161);
      this.panel1.TabIndex = 5;
      // 
      // cmd_Add
      // 
      this.cmd_Add.Location = new System.Drawing.Point(70, 125);
      this.cmd_Add.Name = "cmd_Add";
      this.cmd_Add.Size = new System.Drawing.Size(75, 23);
      this.cmd_Add.TabIndex = 8;
      this.cmd_Add.Text = "Add Room";
      this.cmd_Add.UseVisualStyleBackColor = true;
      // 
      // txt_Capacity
      // 
      this.txt_Capacity.Location = new System.Drawing.Point(79, 88);
      this.txt_Capacity.Name = "txt_Capacity";
      this.txt_Capacity.Size = new System.Drawing.Size(121, 20);
      this.txt_Capacity.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(25, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Capacity";
      // 
      // txt_Rate
      // 
      this.txt_Rate.Location = new System.Drawing.Point(79, 62);
      this.txt_Rate.Name = "txt_Rate";
      this.txt_Rate.Size = new System.Drawing.Size(121, 20);
      this.txt_Rate.TabIndex = 5;
      // 
      // txt_RoomType
      // 
      this.txt_RoomType.Location = new System.Drawing.Point(79, 36);
      this.txt_RoomType.Name = "txt_RoomType";
      this.txt_RoomType.Size = new System.Drawing.Size(121, 20);
      this.txt_RoomType.TabIndex = 4;
      // 
      // txt_RoomNo
      // 
      this.txt_RoomNo.Location = new System.Drawing.Point(79, 9);
      this.txt_RoomNo.Name = "txt_RoomNo";
      this.txt_RoomNo.Size = new System.Drawing.Size(121, 20);
      this.txt_RoomNo.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(43, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(30, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Rate";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Room Type";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Room No.";
      // 
      // cmd_Remove
      // 
      this.cmd_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cmd_Remove.Location = new System.Drawing.Point(511, 230);
      this.cmd_Remove.Name = "cmd_Remove";
      this.cmd_Remove.Size = new System.Drawing.Size(75, 23);
      this.cmd_Remove.TabIndex = 9;
      this.cmd_Remove.Text = "Remove";
      this.cmd_Remove.UseVisualStyleBackColor = true;
      this.cmd_Remove.Click += new System.EventHandler(this.cmd_Remove_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.pcmd_RoomSearch);
      this.groupBox2.Controls.Add(this.txt_RoomSearch);
      this.groupBox2.Location = new System.Drawing.Point(593, 218);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(186, 41);
      this.groupBox2.TabIndex = 4;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Search Room Type or Room No.";
      // 
      // pcmd_RoomSearch
      // 
      this.pcmd_RoomSearch.BackgroundImage = global::NoteView.Properties.Resources.search;
      this.pcmd_RoomSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pcmd_RoomSearch.Location = new System.Drawing.Point(11, 19);
      this.pcmd_RoomSearch.Name = "pcmd_RoomSearch";
      this.pcmd_RoomSearch.Size = new System.Drawing.Size(18, 18);
      this.pcmd_RoomSearch.TabIndex = 3;
      this.pcmd_RoomSearch.TabStop = false;
      this.pcmd_RoomSearch.Click += new System.EventHandler(this.pcmd_RoomSearch_Click);
      // 
      // txt_RoomSearch
      // 
      this.txt_RoomSearch.Location = new System.Drawing.Point(35, 17);
      this.txt_RoomSearch.Name = "txt_RoomSearch";
      this.txt_RoomSearch.Size = new System.Drawing.Size(145, 20);
      this.txt_RoomSearch.TabIndex = 2;
      // 
      // gb_RoomTable
      // 
      this.gb_RoomTable.Controls.Add(this.sstrip_Indicator);
      this.gb_RoomTable.Controls.Add(this.dgv_Rooms);
      this.gb_RoomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.gb_RoomTable.Location = new System.Drawing.Point(3, 256);
      this.gb_RoomTable.Name = "gb_RoomTable";
      this.gb_RoomTable.Size = new System.Drawing.Size(779, 235);
      this.gb_RoomTable.TabIndex = 1;
      this.gb_RoomTable.TabStop = false;
      this.gb_RoomTable.Text = "Existing Rooms";
      // 
      // sstrip_Indicator
      // 
      this.sstrip_Indicator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsstrip_Indicator});
      this.sstrip_Indicator.Location = new System.Drawing.Point(3, 210);
      this.sstrip_Indicator.Name = "sstrip_Indicator";
      this.sstrip_Indicator.Size = new System.Drawing.Size(773, 22);
      this.sstrip_Indicator.TabIndex = 1;
      this.sstrip_Indicator.Text = "<status>";
      // 
      // tsstrip_Indicator
      // 
      this.tsstrip_Indicator.Name = "tsstrip_Indicator";
      this.tsstrip_Indicator.Size = new System.Drawing.Size(0, 17);
      // 
      // dgv_Rooms
      // 
      this.dgv_Rooms.AllowUserToAddRows = false;
      this.dgv_Rooms.AllowUserToDeleteRows = false;
      this.dgv_Rooms.AllowUserToResizeColumns = false;
      this.dgv_Rooms.AllowUserToResizeRows = false;
      this.dgv_Rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgv_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.roomNumber,
            this.roomType,
            this.roomRate,
            this.roomCapacity});
      this.dgv_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_Rooms.Location = new System.Drawing.Point(3, 16);
      this.dgv_Rooms.MultiSelect = false;
      this.dgv_Rooms.Name = "dgv_Rooms";
      this.dgv_Rooms.ReadOnly = true;
      this.dgv_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Rooms.Size = new System.Drawing.Size(773, 216);
      this.dgv_Rooms.TabIndex = 0;
      this.dgv_Rooms.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Rooms_RowEnter);
      // 
      // id
      // 
      this.id.HeaderText = "Room ID";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Width = 74;
      // 
      // roomNumber
      // 
      this.roomNumber.HeaderText = "Room No.";
      this.roomNumber.Name = "roomNumber";
      this.roomNumber.ReadOnly = true;
      this.roomNumber.Width = 80;
      // 
      // roomType
      // 
      this.roomType.HeaderText = "Room Type";
      this.roomType.Name = "roomType";
      this.roomType.ReadOnly = true;
      this.roomType.Width = 87;
      // 
      // roomRate
      // 
      this.roomRate.HeaderText = "Rate";
      this.roomRate.Name = "roomRate";
      this.roomRate.ReadOnly = true;
      this.roomRate.Width = 55;
      // 
      // roomCapacity
      // 
      this.roomCapacity.HeaderText = "Capacity";
      this.roomCapacity.Name = "roomCapacity";
      this.roomCapacity.ReadOnly = true;
      this.roomCapacity.Width = 73;
      // 
      // bwork_RoomFetcher
      // 
      this.bwork_RoomFetcher.WorkerReportsProgress = true;
      this.bwork_RoomFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_RoomFetcher_DoWork);
      this.bwork_RoomFetcher.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_RoomFetcher_ProgressChanged);
      this.bwork_RoomFetcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_RoomFetcher_RunWorkerCompleted);
      // 
      // bwork_RoomDeleter
      // 
      this.bwork_RoomDeleter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_RoomDeleter_DoWork);
      this.bwork_RoomDeleter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_RoomDeleter_RunWorkerCompleted);
      // 
      // SystemConfiguration
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 494);
      this.Controls.Add(this.gb_RoomConfiguration);
      this.Name = "SystemConfiguration";
      this.Text = "Configure System";
      this.Load += new System.EventHandler(this.SystemConfiguration_Load);
      this.gb_RoomConfiguration.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcmd_RoomSearch)).EndInit();
      this.gb_RoomTable.ResumeLayout(false);
      this.gb_RoomTable.PerformLayout();
      this.sstrip_Indicator.ResumeLayout(false);
      this.sstrip_Indicator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Rooms)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gb_RoomConfiguration;
    private System.Windows.Forms.DataGridView dgv_Rooms;
    private System.Windows.Forms.GroupBox gb_RoomTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomType;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomRate;
    private System.Windows.Forms.DataGridViewTextBoxColumn roomCapacity;
    private System.Windows.Forms.TextBox txt_RoomSearch;
    private System.Windows.Forms.GroupBox groupBox2;
    private PictureButton pcmd_RoomSearch;
    private System.ComponentModel.BackgroundWorker bwork_RoomFetcher;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txt_Rate;
    private System.Windows.Forms.TextBox txt_RoomType;
    private System.Windows.Forms.TextBox txt_RoomNo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txt_Capacity;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button cmd_Remove;
    private System.Windows.Forms.Button cmd_Add;
    private System.Windows.Forms.StatusStrip sstrip_Indicator;
    private System.Windows.Forms.ToolStripStatusLabel tsstrip_Indicator;
    private System.ComponentModel.BackgroundWorker bwork_RoomDeleter;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
  }
}