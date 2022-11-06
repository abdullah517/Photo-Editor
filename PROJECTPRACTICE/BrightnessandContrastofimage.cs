using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class BrightnessandContrastofimage : Form
    {
        Image<Bgr, byte> ImgInput,imgOutput;
        private Dashboard mainform = null;
        public BrightnessandContrastofimage(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();
        }

        private void btnsaveimg_Click(object sender, EventArgs e)
        {
            try
            {
               if (imgOutput == null)
                {
                    return;
                }
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Images (*.jpg;)|*.jpg;| Images (*.png;)| *.png;| Images (*.bmp)|*.bmp;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgOutput.Save(dialog.FileName);
                    MessageBox.Show("Image saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrightnessandContrastofimage_Load(object sender, EventArgs e)
        {
            lblCurrentBrightness.Text = trackBar2.Value.ToString();
            lblMinBrightness.Text = trackBar2.Minimum.ToString();
            lblMaxBrightness.Text = trackBar2.Maximum.ToString();


            lblMinContrast.Text = ((float)trackBar1.Minimum / 100).ToString();
            lblMaxContrast.Text = ((float)trackBar1.Maximum / 100).ToString();
            lblCurrentContrast.Text = ((float)trackBar1.Value / 100).ToString();
        }

        private void ContrastBrightnessAdjust()
        {
            try
            {
                lblCurrentContrast.Text = ((float)trackBar1.Value / 100).ToString();
                imgOutput = ImgInput.Mul(double.Parse(lblCurrentContrast.Text)) + trackBar2.Value;
                pictureBox1.Image = imgOutput.Bitmap;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                ContrastBrightnessAdjust();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                ContrastBrightnessAdjust();
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp;";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImgInput = new Image<Bgr, byte>(dialog.FileName);
                pictureBox1.Image = ImgInput.Bitmap;
                btnsaveimg.Enabled = true;
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
            }
        }
    }
}
