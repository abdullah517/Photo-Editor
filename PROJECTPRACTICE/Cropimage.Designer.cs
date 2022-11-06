
namespace PROJECTPRACTICE
{
    partial class Cropimage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cropimage));
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bntloadimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnsaveimg = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Location = new System.Drawing.Point(61, 36);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(377, 387);
            this.Panel1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Silver;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.ShadowDecoration.Parent = this.PictureBox1;
            this.PictureBox1.Size = new System.Drawing.Size(377, 387);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Location = new System.Drawing.Point(526, 36);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(377, 387);
            this.Panel2.TabIndex = 0;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Silver;
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.ShadowDecoration.Parent = this.PictureBox2;
            this.PictureBox2.Size = new System.Drawing.Size(377, 387);
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Visible = false;
            // 
            // bntloadimg
            // 
            this.bntloadimg.CheckedState.Parent = this.bntloadimg;
            this.bntloadimg.CustomImages.Parent = this.bntloadimg;
            this.bntloadimg.FillColor = System.Drawing.Color.LightBlue;
            this.bntloadimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntloadimg.ForeColor = System.Drawing.Color.White;
            this.bntloadimg.HoverState.Parent = this.bntloadimg;
            this.bntloadimg.Location = new System.Drawing.Point(150, 454);
            this.bntloadimg.Name = "bntloadimg";
            this.bntloadimg.ShadowDecoration.Parent = this.bntloadimg;
            this.bntloadimg.Size = new System.Drawing.Size(180, 45);
            this.bntloadimg.TabIndex = 6;
            this.bntloadimg.Text = "Load image";
            this.bntloadimg.Click += new System.EventHandler(this.bntloadimg_Click);
            // 
            // btnsaveimg
            // 
            this.btnsaveimg.CheckedState.Parent = this.btnsaveimg;
            this.btnsaveimg.CustomImages.Parent = this.btnsaveimg;
            this.btnsaveimg.Enabled = false;
            this.btnsaveimg.FillColor = System.Drawing.Color.LightBlue;
            this.btnsaveimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveimg.ForeColor = System.Drawing.Color.White;
            this.btnsaveimg.HoverState.Parent = this.btnsaveimg;
            this.btnsaveimg.Location = new System.Drawing.Point(642, 454);
            this.btnsaveimg.Name = "btnsaveimg";
            this.btnsaveimg.ShadowDecoration.Parent = this.btnsaveimg;
            this.btnsaveimg.Size = new System.Drawing.Size(180, 45);
            this.btnsaveimg.TabIndex = 7;
            this.btnsaveimg.Text = "Save image";
            this.btnsaveimg.Visible = false;
            this.btnsaveimg.Click += new System.EventHandler(this.btnsaveimg_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, -3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Cropimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(933, 567);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnsaveimg);
            this.Controls.Add(this.bntloadimg);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cropimage";
            this.Text = "Cropimage";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2Button bntloadimg;
        private Guna.UI2.WinForms.Guna2Button btnsaveimg;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}