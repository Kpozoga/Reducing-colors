using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gk_zad3
{
    public partial class Form2 : Form
    {
        public Bitmap picture;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 parent,Bitmap pic)
        {

            InitializeComponent();
            this.picture = pic;
            this.Width = picture.Width + 22;
            this.Height = picture.Height + 68;
            int x, y;
            x = parent.Location.X + parent.Width;
            if (x + this.Width > Screen.PrimaryScreen.WorkingArea.Width)
                x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            if (x < 0) x = 0;
            y = parent.Location.Y - (picture.Height - parent.Height) / 2;
            if (y + this.Height > Screen.PrimaryScreen.WorkingArea.Height)
                y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            if (y < 0) y = 0;
            this.Location = new Point(x, y);
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            pictureBox1.Image = picture;
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.RestoreDirectory = true;
            dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|Gif Image|*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picture.Save(dialog.FileName, ImageFormat.Jpeg);
                
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs =
                        (System.IO.FileStream)dialog.OpenFile();
                    // Saves the Image in the appropriate ImageFormat based upon the
                    // File type selected in the dialog box.
                    // NOTE that the FilterIndex property is one-based.
                    switch (dialog.FilterIndex) //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
                {
                    case 1:
                        picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 4:
                        picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
                
            }
        }
    }
}
