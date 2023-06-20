using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  public partial class Charges : Form
  {
    private readonly int resId;

    public Charges(int resId)
    {
      InitializeComponent();
      this.resId = resId;
    }

    

    private void bwork_DataFetcher_DoWork(object sender, DoWorkEventArgs e)
    {
      
    }

    private void Charges_Load(object sender, EventArgs e)
    {
      UseWaitCursor = true;
      bwork_DataFetcher.RunWorkerAsync();
    }

    private void bwork_DataFetcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Error != null)
      {
        MessageBox.Show("Cannot load charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        Close();
      }
      UseWaitCursor = false;
    }
  }
}
