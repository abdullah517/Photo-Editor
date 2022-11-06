using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTPRACTICE
{
    public partial class Imageoverlay : Form
    {
        Image<Bgr, byte> imgInput;
        Rectangle rect;
        Point StartROI;
        bool Selecting, MouseDown;

        private Dashboard mainform = null;
        public Imageoverlay(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();
            Selecting = false;
            rect = Rectangle.Empty;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new Rectangle(Math.Min(StartROI.X, e.X),
                    Math.Min(StartROI.Y, e.Y),
                    width,
                    height);
                Refresh();
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
                btnoverlay.Enabled = true;
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }
        }

        private void btnroi_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }

        private void bntsaveimg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnoverlay_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var image1 = imgInput;
                    var image2 = new Image<Bgr, byte>(ofd.FileName)
                        .Resize(0.75,Inter.Cubic);
                    var mask = image2.Convert<Gray, byte>()
                        .SmoothGaussian(3)
                        .ThresholdBinaryInv(new Gray(245),new Gray(255))
                        .Erode(1);

                    rect.Width = image2.Width;
                    rect.Height = image2.Height;
                    image1.ROI = rect;
                    image1.SetValue(new Bgr(0, 0, 0), mask);
                    image2.SetValue(new Bgr(0, 0, 0), mask.Not());
                    image1._Or(image2);
                    image1.ROI = Rectangle.Empty;
                    
                    PictureBox1.Image = image1.ToBitmap();
                    bntsaveimg.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.show();
        }

        private void bntloadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try

            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   imgInput = new Image<Bgr, byte>(ofd.FileName);
                   PictureBox1.Image = imgInput.Bitmap;
                    btnroi.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
