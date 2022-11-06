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
    public partial class Collague : Form
    {
        //List<Image<Bgr, byte>> list;
        private Dashboard mainform = null;


       // private Rectangle rect;
        
        public Collague(Form callingform)
        {
            mainform = callingform as Dashboard;
            InitializeComponent();
        }

        private void btnhz_Click(object sender, EventArgs e)
        {
            try
            {
                List<Image<Bgr, byte>> list = new List<Image<Bgr, byte>>();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png|*.jpg;*.jpeg;*.png)";
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        list.Add(new Image<Bgr, byte>(file));
                    }
                }

                if (list.Count > 0)
                {
                    var img = HelperClass.HConcatenateImages(list);
                    pictureBox1.Image = img.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnvt_Click(object sender, EventArgs e)
        {
            try
            {
                List<Image<Bgr, byte>> list = new List<Image<Bgr, byte>>();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.jpeg, *.png|*.jpg;*.jpeg;*.png)";
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in dialog.FileNames)
                    {
                        list.Add(new Image<Bgr, byte>(file));
                    }
                }

                if (list.Count > 0)
                {
                    var img = HelperClass.VConcatenateImages(list);
                    //var img = HelperClass.VConcatenateImages(list[0],list[1]);
                    pictureBox1.Image = img.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainform.show();
        }
    }
}
