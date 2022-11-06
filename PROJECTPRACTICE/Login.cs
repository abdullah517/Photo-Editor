using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECTPRACTICE
{
    public partial class Login : Form
    {
        public Login(bool chk=true)
        {
            if (chk == true)
            {
                Thread t = new Thread(new ThreadStart(splashstart));
                t.Start();
                Thread.Sleep(1800);
                InitializeComponent();
                t.Abort();
            }
            else
                InitializeComponent();
        }

        public void splashstart()
        {

            Application.Run(new Splashscreen());
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = CheckBox1.Checked;
            if (check == true)
                txtpass.PasswordChar = '\0';
            else
                txtpass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusname.Text != "" && txtpass.Text != "")
            {
                if (txtusname.Text == "hello123" && txtpass.Text == "123456")
                {
                    this.Hide();
                    Dashboard ds = new Dashboard();
                    ds.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter valid details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
