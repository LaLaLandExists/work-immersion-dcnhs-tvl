namespace NoteView
{
  partial class SetupDB
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDB));
      this.bwork_Connection = new System.ComponentModel.BackgroundWorker();
      this.pnl_setUpDB = new System.Windows.Forms.Panel();
      this.lbl_ErrorInfo = new System.Windows.Forms.Label();
      this.gb_dbcnnct = new System.Windows.Forms.GroupBox();
      this.lbl_ConnectOutput = new System.Windows.Forms.Label();
      this.btn_Connect = new System.Windows.Forms.Button();
      this.txt_DB = new System.Windows.Forms.TextBox();
      this.txt_Password = new System.Windows.Forms.TextBox();
      this.txt_Username = new System.Windows.Forms.TextBox();
      this.txt_Port = new System.Windows.Forms.TextBox();
      this.txt_Server = new System.Windows.Forms.TextBox();
      this.lbl_datab = new System.Windows.Forms.Label();
      this.lbl_password = new System.Windows.Forms.Label();
      this.lbl_user = new System.Windows.Forms.Label();
      this.lbl_port = new System.Windows.Forms.Label();
      this.lbl_Server = new System.Windows.Forms.Label();
      this.pcb_Welcome = new System.Windows.Forms.PictureBox();
      this.pnl_setUpDB.SuspendLayout();
      this.gb_dbcnnct.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcb_Welcome)).BeginInit();
      this.SuspendLayout();
      // 
      // bwork_Connection
      // 
      this.bwork_Connection.WorkerReportsProgress = true;
      this.bwork_Connection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_Connection_DoWork);
      this.bwork_Connection.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwork_Connection_ProgressChanged);
      this.bwork_Connection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_Connection_RunWorkerCompleted);
      // 
      // pnl_setUpDB
      // 
      this.pnl_setUpDB.BackgroundImage = global::NoteView.Properties.Resources.bg1;
      this.pnl_setUpDB.Controls.Add(this.lbl_ErrorInfo);
      this.pnl_setUpDB.Controls.Add(this.gb_dbcnnct);
      this.pnl_setUpDB.Controls.Add(this.pcb_Welcome);
      this.pnl_setUpDB.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_setUpDB.ForeColor = System.Drawing.Color.White;
      this.pnl_setUpDB.Location = new System.Drawing.Point(0, 0);
      this.pnl_setUpDB.Name = "pnl_setUpDB";
      this.pnl_setUpDB.Size = new System.Drawing.Size(784, 411);
      this.pnl_setUpDB.TabIndex = 12;
      // 
      // lbl_ErrorInfo
      // 
      this.lbl_ErrorInfo.AutoSize = true;
      this.lbl_ErrorInfo.BackColor = System.Drawing.Color.Transparent;
      this.lbl_ErrorInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ErrorInfo.ForeColor = System.Drawing.Color.Red;
      this.lbl_ErrorInfo.Location = new System.Drawing.Point(-3, 398);
      this.lbl_ErrorInfo.Name = "lbl_ErrorInfo";
      this.lbl_ErrorInfo.Size = new System.Drawing.Size(81, 14);
      this.lbl_ErrorInfo.TabIndex = 27;
      this.lbl_ErrorInfo.Text = "Generic Error";
      this.lbl_ErrorInfo.Visible = false;
      // 
      // gb_dbcnnct
      // 
      this.gb_dbcnnct.BackColor = System.Drawing.Color.Transparent;
      this.gb_dbcnnct.Controls.Add(this.lbl_ConnectOutput);
      this.gb_dbcnnct.Controls.Add(this.btn_Connect);
      this.gb_dbcnnct.Controls.Add(this.txt_DB);
      this.gb_dbcnnct.Controls.Add(this.txt_Password);
      this.gb_dbcnnct.Controls.Add(this.txt_Username);
      this.gb_dbcnnct.Controls.Add(this.txt_Port);
      this.gb_dbcnnct.Controls.Add(this.txt_Server);
      this.gb_dbcnnct.Controls.Add(this.lbl_datab);
      this.gb_dbcnnct.Controls.Add(this.lbl_password);
      this.gb_dbcnnct.Controls.Add(this.lbl_user);
      this.gb_dbcnnct.Controls.Add(this.lbl_port);
      this.gb_dbcnnct.Controls.Add(this.lbl_Server);
      this.gb_dbcnnct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_dbcnnct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.gb_dbcnnct.Location = new System.Drawing.Point(458, 57);
      this.gb_dbcnnct.Name = "gb_dbcnnct";
      this.gb_dbcnnct.Size = new System.Drawing.Size(290, 311);
      this.gb_dbcnnct.TabIndex = 26;
      this.gb_dbcnnct.TabStop = false;
      this.gb_dbcnnct.Text = "Set-up Database Connection";
      // 
      // lbl_ConnectOutput
      // 
      this.lbl_ConnectOutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_ConnectOutput.Location = new System.Drawing.Point(6, 228);
      this.lbl_ConnectOutput.Name = "lbl_ConnectOutput";
      this.lbl_ConnectOutput.Size = new System.Drawing.Size(278, 15);
      this.lbl_ConnectOutput.TabIndex = 46;
      this.lbl_ConnectOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_ConnectOutput.Visible = false;
      // 
      // btn_Connect
      // 
      this.btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_Connect.Location = new System.Drawing.Point(78, 246);
      this.btn_Connect.Name = "btn_Connect";
      this.btn_Connect.Size = new System.Drawing.Size(135, 28);
      this.btn_Connect.TabIndex = 45;
      this.btn_Connect.Text = "CONNECT";
      this.btn_Connect.UseVisualStyleBackColor = true;
      this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
      // 
      // txt_DB
      // 
      this.txt_DB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_DB.Location = new System.Drawing.Point(94, 163);
      this.txt_DB.Name = "txt_DB";
      this.txt_DB.Size = new System.Drawing.Size(192, 21);
      this.txt_DB.TabIndex = 44;
      this.txt_DB.Text = "test";
      // 
      // txt_Password
      // 
      this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Password.Location = new System.Drawing.Point(94, 136);
      this.txt_Password.Name = "txt_Password";
      this.txt_Password.Size = new System.Drawing.Size(192, 21);
      this.txt_Password.TabIndex = 43;
      this.txt_Password.Text = "password";
      this.txt_Password.UseSystemPasswordChar = true;
      // 
      // txt_Username
      // 
      this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Username.Location = new System.Drawing.Point(94, 109);
      this.txt_Username.Name = "txt_Username";
      this.txt_Username.Size = new System.Drawing.Size(192, 21);
      this.txt_Username.TabIndex = 42;
      this.txt_Username.Text = "root";
      // 
      // txt_Port
      // 
      this.txt_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Port.Location = new System.Drawing.Point(94, 82);
      this.txt_Port.Name = "txt_Port";
      this.txt_Port.Size = new System.Drawing.Size(192, 21);
      this.txt_Port.TabIndex = 41;
      // 
      // txt_Server
      // 
      this.txt_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txt_Server.Location = new System.Drawing.Point(94, 54);
      this.txt_Server.Name = "txt_Server";
      this.txt_Server.Size = new System.Drawing.Size(192, 21);
      this.txt_Server.TabIndex = 40;
      this.txt_Server.Text = "localhost";
      // 
      // lbl_datab
      // 
      this.lbl_datab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_datab.AutoSize = true;
      this.lbl_datab.BackColor = System.Drawing.Color.Transparent;
      this.lbl_datab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_datab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_datab.Location = new System.Drawing.Point(5, 166);
      this.lbl_datab.Name = "lbl_datab";
      this.lbl_datab.Size = new System.Drawing.Size(77, 17);
      this.lbl_datab.TabIndex = 39;
      this.lbl_datab.Text = "Database";
      // 
      // lbl_password
      // 
      this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_password.AutoSize = true;
      this.lbl_password.BackColor = System.Drawing.Color.Transparent;
      this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_password.Location = new System.Drawing.Point(5, 139);
      this.lbl_password.Name = "lbl_password";
      this.lbl_password.Size = new System.Drawing.Size(77, 17);
      this.lbl_password.TabIndex = 38;
      this.lbl_password.Text = "Password";
      // 
      // lbl_user
      // 
      this.lbl_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_user.AutoSize = true;
      this.lbl_user.BackColor = System.Drawing.Color.Transparent;
      this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_user.Location = new System.Drawing.Point(5, 112);
      this.lbl_user.Name = "lbl_user";
      this.lbl_user.Size = new System.Drawing.Size(42, 17);
      this.lbl_user.TabIndex = 37;
      this.lbl_user.Text = "User";
      // 
      // lbl_port
      // 
      this.lbl_port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_port.AutoSize = true;
      this.lbl_port.BackColor = System.Drawing.Color.Transparent;
      this.lbl_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_port.Location = new System.Drawing.Point(5, 85);
      this.lbl_port.Name = "lbl_port";
      this.lbl_port.Size = new System.Drawing.Size(38, 17);
      this.lbl_port.TabIndex = 36;
      this.lbl_port.Text = "Port";
      // 
      // lbl_Server
      // 
      this.lbl_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbl_Server.AutoSize = true;
      this.lbl_Server.BackColor = System.Drawing.Color.Transparent;
      this.lbl_Server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_Server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_Server.Location = new System.Drawing.Point(5, 57);
      this.lbl_Server.Name = "lbl_Server";
      this.lbl_Server.Size = new System.Drawing.Size(56, 17);
      this.lbl_Server.TabIndex = 35;
      this.lbl_Server.Text = "Server";
      // 
      // pcb_Welcome
      // 
      this.pcb_Welcome.BackColor = System.Drawing.Color.Transparent;
      this.pcb_Welcome.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Welcome.Image")));
      this.pcb_Welcome.Location = new System.Drawing.Point(18, 89);
      this.pcb_Welcome.Name = "pcb_Welcome";
      this.pcb_Welcome.Size = new System.Drawing.Size(425, 224);
      this.pcb_Welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pcb_Welcome.TabIndex = 25;
      this.pcb_Welcome.TabStop = false;
      // 
      // SetupDB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(784, 411);
      this.Controls.Add(this.pnl_setUpDB);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "SetupDB";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Connect to a Database";
      this.pnl_setUpDB.ResumeLayout(false);
      this.pnl_setUpDB.PerformLayout();
      this.gb_dbcnnct.ResumeLayout(false);
      this.gb_dbcnnct.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcb_Welcome)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel pnl_setUpDB;
    private System.Windows.Forms.PictureBox pcb_Welcome;
    private System.Windows.Forms.GroupBox gb_dbcnnct;
    private System.Windows.Forms.Button btn_Connect;
    private System.Windows.Forms.TextBox txt_DB;
    private System.Windows.Forms.TextBox txt_Password;
    private System.Windows.Forms.TextBox txt_Username;
    private System.Windows.Forms.TextBox txt_Port;
    private System.Windows.Forms.TextBox txt_Server;
    private System.Windows.Forms.Label lbl_datab;
    private System.Windows.Forms.Label lbl_password;
    private System.Windows.Forms.Label lbl_user;
    private System.Windows.Forms.Label lbl_port;
    private System.Windows.Forms.Label lbl_Server;
        private System.ComponentModel.BackgroundWorker bwork_Connection;
    private System.Windows.Forms.Label lbl_ErrorInfo;
    private System.Windows.Forms.Label lbl_ConnectOutput;
  }
}