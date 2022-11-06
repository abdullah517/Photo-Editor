using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace PROJECTPRACTICE
{
    public partial class Image_InPainting : Form
    {
        string imgname;
        Image<Bgr, byte> imageInput;
        List<List<Point>> InpaintPoints = null;
        List<Point> InpaintCurrentPoints=null;
        bool InpaintMouseDown=false;
        bool InpaintSelection=false;
        private Dashboard mainform=null;
        public Image_InPainting(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InpaintSelection = true;
            InpaintCurrentPoints = new List<Point>();
            InpaintPoints=new List<List<Point>>();           
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if(InpaintSelection==true&& e.Button == MouseButtons.Left)
            {
                InpaintMouseDown=true;
                InpaintCurrentPoints.Add(e.Location);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (InpaintMouseDown == true && InpaintSelection)
            {
                InpaintMouseDown = false;
                InpaintPoints.Add(InpaintCurrentPoints.ToList());
                InpaintCurrentPoints.Clear();
                button2.Enabled = true;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1 == null)
            {
                return;
            }
            if (InpaintMouseDown == true && InpaintSelection == true)
            {
                if (InpaintCurrentPoints.Count > 0)
                {
                    Pen p = new Pen(Brushes.Red, 5);
                    using (Graphics g = Graphics.FromImage(pictureBox2.Image))
                    {
                        g.DrawLine(p, InpaintCurrentPoints.Last(), e.Location);
                        g.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    }
                }
                InpaintCurrentPoints.Add(e.Location);
                pictureBox2.Invalidate();
            }
        }
               
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox2.Image == null) return;
                if (InpaintPoints.Count == 0) return;
                var img =imageInput;
                var mask = new Image<Gray, byte>(img.Width, img.Height);
                foreach(var polys in InpaintPoints)
                {
                    mask.DrawPolyline(polys.ToArray(), false, new Gray(255), 5);
                }
                var output = img.CopyBlank();
                CvInvoke.Inpaint(img, mask, output, 3, InpaintType.Telea);
                pictureBox2.Image = output.ToBitmap();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog emf = new OpenFileDialog();
            try
            {
                if (emf.ShowDialog() == DialogResult.OK)
                {
                    imgname = emf.FileName;
                    Image<Bgr, byte> img = new Image<Bgr, byte>(emf.FileName);
                    pictureBox2.Image = img.ToBitmap();
                    imageInput = img;
                    button1.Enabled = true;
                    button3.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(saveFileDialog.FileName);
                }
            }
        }
    }
}
