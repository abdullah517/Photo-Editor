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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();         
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_MouseHover(object sender, EventArgs e)
        {
            btnmaximize.BackColor = Color.Gray;
        }

        private void btnmaximize_MouseLeave(object sender, EventArgs e)
        {
            btnmaximize.BackColor = Color.DeepSkyBlue;
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnwriteonimg_Click(object sender, EventArgs e)
        {
            openchildform(new Writeonimages(this));
        }

        private void btncropimg_Click(object sender, EventArgs e)
        {
            openchildform(new Cropimage(this));
        }

        private void btnremovenoise_Click(object sender, EventArgs e)
        {
            openchildform(new Image_InPainting(this));
        }

        private void btnimgoverlay_Click(object sender, EventArgs e)
        {
            openchildform(new Imageoverlay(this));
        }

        private void btnmkcolg_Click(object sender, EventArgs e)
        {
            openchildform(new Collague(this));
        }

        private void btnbr_cr_Click(object sender, EventArgs e)
        {
            openchildform(new BrightnessandContrastofimage(this));
        }

        private void openchildform(object form)
        {
            if (this.mainpanel.Controls.Count > 1)
            {
                this.mainpanel.Controls.RemoveAt(1);
            }
            PictureBox2.Visible = false;

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        public void show()
        {
            PictureBox2.Visible = true;
        }

        private void btnlgout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login(false);
            l.Show();
        }
    }
}













