using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteView
{
  internal class PictureLabel : FlowLayoutPanel
  {
    public readonly PictureBox theImage = new PictureBox();
    public readonly Label theLabel = new Label();

    public PictureLabel()
    {
      theImage.Size = new System.Drawing.Size(72, 72);
      theImage.Location = new System.Drawing.Point(3, 3);
      theImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

      theLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      theLabel.ForeColor = System.Drawing.Color.Navy;
      theLabel.Location = new System.Drawing.Point(3, 78);
      theLabel.Size = new System.Drawing.Size(72, 17);
      theLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      theLabel.Text = "Enter Text";

      Controls.Add(theImage);
      Controls.Add(theLabel);

      FlowDirection = FlowDirection.TopDown;
      Size = new System.Drawing.Size(78, 95);
    }
  }
}
