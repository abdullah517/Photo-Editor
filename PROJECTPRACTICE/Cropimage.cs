using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;

namespace PROJECTPRACTICE
{
    public partial class Cropimage : Form
    {
        Image<Bgr, byte> imgInput;
        Rectangle rect;
        Point StartLocation, EndLocation;
        bool IsMouseDown = false;
         

        private Dashboard mainform = null;
        public Cropimage(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();          
        }

        private void btnsaveimg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBox2.Image.Save(saveFileDialog.FileName);
                }
            }
        }


        private Rectangle GetRectangle()
        {
            rect = new Rectangle();
            rect.X = Math.Min(StartLocation.X, EndLocation.X);
            rect.Y = Math.Min(StartLocation.Y, EndLocation.Y);
            rect.Width = Math.Abs(StartLocation.X - EndLocation.X);
            rect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);
            return rect;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                EndLocation = e.Location;
                IsMouseDown = false;

                if (rect != null)
                {
                    imgInput.ROI = rect;
                    Image<Bgr, byte> temp = imgInput.CopyBlank();
                    imgInput.CopyTo(temp);
                    imgInput.ROI = Rectangle.Empty;
                    PictureBox2.Image = temp.Bitmap;
                    btnsaveimg.Enabled = true;
                }
            }
        }
       
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
       
            if (IsMouseDown == true)
            {
                EndLocation = e.Location;
                PictureBox1.Invalidate();
            }                      
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Green, GetRectangle());
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            StartLocation = e.Location;         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.show();
        }

        private void bntloadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg;)|*.jpg;";
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                    PictureBox1.Image = imgInput.Bitmap;
                    PictureBox2.Visible = true;
                    btnsaveimg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
