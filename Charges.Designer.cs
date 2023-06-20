namespace NoteView
{
  partial class Charges
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
      this.rtxt_Receipt = new System.Windows.Forms.RichTextBox();
      this.bwork_DataFetcher = new System.ComponentModel.BackgroundWorker();
      this.SuspendLayout();
      // 
      // rtxt_Receipt
      // 
      this.rtxt_Receipt.Dock = System.Windows.Forms.DockStyle.Top;
      this.rtxt_Receipt.Location = new System.Drawing.Point(0, 0);
      this.rtxt_Receipt.Name = "rtxt_Receipt";
      this.rtxt_Receipt.ReadOnly = true;
      this.rtxt_Receipt.Size = new System.Drawing.Size(766, 503);
      this.rtxt_Receipt.TabIndex = 0;
      this.rtxt_Receipt.Text = "";
      // 
      // bwork_DataFetcher
      // 
      this.bwork_DataFetcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwork_DataFetcher_DoWork);
      this.bwork_DataFetcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwork_DataFetcher_RunWorkerCompleted);
      // 
      // Charges
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::NoteView.Properties.Resources.bg_noteview;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(766, 608);
      this.Controls.Add(this.rtxt_Receipt);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "Charges";
      this.Text = "Charges";
      this.Load += new System.EventHandler(this.Charges_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtxt_Receipt;
    private System.ComponentModel.BackgroundWorker bwork_DataFetcher;
  }
}