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
    public partial class Writeonimages : Form
    {
        textcolour []tc = new textcolour[10];
        int ind = 0,x=75,y=85;
        string imgname = "";
        Image<Bgr, byte> image1;
        Image<Bgr, byte> image2;
        private Dashboard mainform = null;
        public Writeonimages(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();
            settxtclr();
        }

        private void settxtclr()
        {
            for (int i = 0; i < tc.Length; i++)
                tc[i] = new textcolour();
            tc[0].setcolourcodes(0,0,255);
            tc[1].setcolourcodes(255,144,30);
            tc[2].setcolourcodes(255,255,0);
            tc[3].setcolourcodes(237,149,100);
            tc[4].setcolourcodes(0,140,255);
            tc[5].setcolourcodes(34,34,178);
            tc[6].setcolourcodes(0,0,128);
            tc[7].setcolourcodes(128,128,0);
            tc[8].setcolourcodes(0,0,0);
            tc[9].setcolourcodes(60,20,220);
        }

        private void bntloadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog emf = new OpenFileDialog();
            try
            {
                if (emf.ShowDialog() == DialogResult.OK)
                {
                    imgname = emf.FileName;
                    image1 = new Image<Bgr, byte>(emf.FileName);
                    imageBox1.Image = image1;
                    btnaddwatermark.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnaddwatermark_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            TextBox1.Visible = true;
            TextBox1.Focus();                     
        }

        private void btnsaveimg_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageBox2.Image.Save(saveFileDialog.FileName);
                    image1.Dispose();
                    image2.Dispose();
                }
            }
        }

        private void settextlocation()
        {
            if (comboBox2.SelectedIndex != -1)
            {
                if (comboBox2.SelectedItem.ToString() == "Top")
                {
                    x = 85;
                    y = 92;
                }
                else if (comboBox2.SelectedItem.ToString() == "Middle")
                {
                    x = 85;
                    y = 250;
                }
                else
                {
                    x = 85;
                    y = 475;
                }
            }

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextBox1.Text != "")
                {
                    settextlocation();
                    if(comboBox1.SelectedIndex!=-1)
                    ind = comboBox1.SelectedIndex;
                    image2 = new Image<Bgr, byte>(imgname);
                    CvInvoke.PutText(image2, TextBox1.Text, new Point(x,y), FontFace.HersheySimplex, 4.0, new MCvScalar(tc[ind].b,tc[ind].g,tc[ind].r), 8);
                    imageBox2.Image = image2;
                    CvInvoke.WaitKey();                  
                    btnsaveimg.Enabled = true;
                    TextBox1.Clear();
                    TextBox1.Visible = false;
                    comboBox1.Visible = false;
                    comboBox2.Visible = false;
                    comboBox1.Text = "....Choose Colour....";
                    comboBox2.Text = "....Select text location....";
                }
                else
                {
                    MessageBox.Show("Please fill the text box");
                    TextBox1.Focus();
                }
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.show();
        }
    }
}
