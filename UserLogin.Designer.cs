namespace NoteView
{
    partial class UserLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
      this.panel1 = new System.Windows.Forms.Panel();
      this.gb_login = new System.Windows.Forms.GroupBox();
      this.chb_showpass = new System.Windows.Forms.CheckBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btn_login = new System.Windows.Forms.Button();
      this.tb_pass = new System.Windows.Forms.TextBox();
      this.tb_username = new System.Windows.Forms.TextBox();
      this.lbl_pass = new System.Windows.Forms.Label();
      this.lbl_username = new System.Windows.Forms.Label();
      this.lbl_AuthMessage = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.gb_login.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
      this.panel1.Controls.Add(this.gb_login);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 450);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // gb_login
      // 
      this.gb_login.BackColor = System.Drawing.Color.Transparent;
      this.gb_login.Controls.Add(this.lbl_AuthMessage);
      this.gb_login.Controls.Add(this.chb_showpass);
      this.gb_login.Controls.Add(this.pictureBox1);
      this.gb_login.Controls.Add(this.btn_login);
      this.gb_login.Controls.Add(this.tb_pass);
      this.gb_login.Controls.Add(this.tb_username);
      this.gb_login.Controls.Add(this.lbl_pass);
      this.gb_login.Controls.Add(this.lbl_username);
      this.gb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gb_login.ForeColor = System.Drawing.SystemColors.Control;
      this.gb_login.Location = new System.Drawing.Point(228, 22);
      this.gb_login.Name = "gb_login";
      this.gb_login.Size = new System.Drawing.Size(344, 369);
      this.gb_login.TabIndex = 0;
      this.gb_login.TabStop = false;
      this.gb_login.Text = "Log-In";
      this.gb_login.Enter += new System.EventHandler(this.gb_login_Enter);
      // 
      // chb_showpass
      // 
      this.chb_showpass.AutoSize = true;
      this.chb_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chb_showpass.ForeColor = System.Drawing.Color.AliceBlue;
      this.chb_showpass.Location = new System.Drawing.Point(137, 263);
      this.chb_showpass.Name = "chb_showpass";
      this.chb_showpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.chb_showpass.Size = new System.Drawing.Size(115, 17);
      this.chb_showpass.TabIndex = 6;
      this.chb_showpass.Text = "Show Password";
      this.chb_showpass.UseVisualStyleBackColor = true;
      this.chb_showpass.CheckedChanged += new System.EventHandler(this.chb_showpass_CheckedChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(97, 37);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(150, 148);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // btn_login
      // 
      this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.btn_login.Location = new System.Drawing.Point(135, 313);
      this.btn_login.Name = "btn_login";
      this.btn_login.Size = new System.Drawing.Size(75, 24);
      this.btn_login.TabIndex = 4;
      this.btn_login.Text = "Log-In";
      this.btn_login.UseVisualStyleBackColor = true;
      this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
      // 
      // tb_pass
      // 
      this.tb_pass.Location = new System.Drawing.Point(137, 235);
      this.tb_pass.Name = "tb_pass";
      this.tb_pass.Size = new System.Drawing.Size(154, 23);
      this.tb_pass.TabIndex = 3;
      this.tb_pass.UseSystemPasswordChar = true;
      this.tb_pass.TextChanged += new System.EventHandler(this.tb_pass_TextChanged);
      // 
      // tb_username
      // 
      this.tb_username.Location = new System.Drawing.Point(137, 202);
      this.tb_username.Name = "tb_username";
      this.tb_username.Size = new System.Drawing.Size(154, 23);
      this.tb_username.TabIndex = 2;
      this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
      // 
      // lbl_pass
      // 
      this.lbl_pass.AutoSize = true;
      this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_pass.Location = new System.Drawing.Point(58, 238);
      this.lbl_pass.Name = "lbl_pass";
      this.lbl_pass.Size = new System.Drawing.Size(73, 15);
      this.lbl_pass.TabIndex = 1;
      this.lbl_pass.Text = "Password:";
      this.lbl_pass.Click += new System.EventHandler(this.label2_Click);
      // 
      // lbl_username
      // 
      this.lbl_username.AutoSize = true;
      this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
      this.lbl_username.Location = new System.Drawing.Point(54, 205);
      this.lbl_username.Name = "lbl_username";
      this.lbl_username.Size = new System.Drawing.Size(77, 15);
      this.lbl_username.TabIndex = 0;
      this.lbl_username.Text = "Username:";
      this.lbl_username.Click += new System.EventHandler(this.label1_Click);
      // 
      // lbl_AuthMessage
      // 
      this.lbl_AuthMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_AuthMessage.Location = new System.Drawing.Point(6, 293);
      this.lbl_AuthMessage.Name = "lbl_AuthMessage";
      this.lbl_AuthMessage.Size = new System.Drawing.Size(332, 17);
      this.lbl_AuthMessage.TabIndex = 7;
      this.lbl_AuthMessage.Text = "lbl_AuthMessage";
      this.lbl_AuthMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // UserLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "UserLogin";
      this.Text = "Login";
      this.panel1.ResumeLayout(false);
      this.gb_login.ResumeLayout(false);
      this.gb_login.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chb_showpass;
    private System.Windows.Forms.Label lbl_AuthMessage;
  }
}