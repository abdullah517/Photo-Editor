
namespace PROJECTPRACTICE
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelmenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnlgout = new Guna.UI2.WinForms.Guna2Button();
            this.btnbr_cr = new Guna.UI2.WinForms.Guna2Button();
            this.btnmkcolg = new Guna.UI2.WinForms.Guna2Button();
            this.btnimgoverlay = new Guna.UI2.WinForms.Guna2Button();
            this.btnremovenoise = new Guna.UI2.WinForms.Guna2Button();
            this.btncropimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnwriteonimg = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnmaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnminimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.mainpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Controls.Add(this.panelmenu);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(10, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 700);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.btnlgout);
            this.panelmenu.Controls.Add(this.btnbr_cr);
            this.panelmenu.Controls.Add(this.btnmkcolg);
            this.panelmenu.Controls.Add(this.btnimgoverlay);
            this.panelmenu.Controls.Add(this.btnremovenoise);
            this.panelmenu.Controls.Add(this.btncropimg);
            this.panelmenu.Controls.Add(this.btnwriteonimg);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmenu.Location = new System.Drawing.Point(0, 139);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.ShadowDecoration.Parent = this.panelmenu;
            this.panelmenu.Size = new System.Drawing.Size(200, 561);
            this.panelmenu.TabIndex = 1;
            // 
            // btnlgout
            // 
            this.btnlgout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlgout.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnlgout.CheckedState.Parent = this.btnlgout;
            this.btnlgout.CustomImages.Parent = this.btnlgout;
            this.btnlgout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlgout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnlgout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlgout.ForeColor = System.Drawing.Color.White;
            this.btnlgout.HoverState.Parent = this.btnlgout;
            this.btnlgout.Location = new System.Drawing.Point(0, 516);
            this.btnlgout.Name = "btnlgout";
            this.btnlgout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnlgout.ShadowDecoration.Parent = this.btnlgout;
            this.btnlgout.Size = new System.Drawing.Size(200, 45);
            this.btnlgout.TabIndex = 8;
            this.btnlgout.Text = "Logout";
            this.btnlgout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlgout.Click += new System.EventHandler(this.btnlgout_Click);
            // 
            // btnbr_cr
            // 
            this.btnbr_cr.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnbr_cr.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnbr_cr.CheckedState.Parent = this.btnbr_cr;
            this.btnbr_cr.CustomImages.Parent = this.btnbr_cr;
            this.btnbr_cr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbr_cr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnbr_cr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbr_cr.ForeColor = System.Drawing.Color.White;
            this.btnbr_cr.HoverState.Parent = this.btnbr_cr;
            this.btnbr_cr.Location = new System.Drawing.Point(0, 225);
            this.btnbr_cr.Name = "btnbr_cr";
            this.btnbr_cr.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnbr_cr.ShadowDecoration.Parent = this.btnbr_cr;
            this.btnbr_cr.Size = new System.Drawing.Size(200, 45);
            this.btnbr_cr.TabIndex = 6;
            this.btnbr_cr.Text = "Brightness and Contrast of images";
            this.btnbr_cr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnbr_cr.Click += new System.EventHandler(this.btnbr_cr_Click);
            // 
            // btnmkcolg
            // 
            this.btnmkcolg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnmkcolg.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnmkcolg.CheckedState.Parent = this.btnmkcolg;
            this.btnmkcolg.CustomImages.Parent = this.btnmkcolg;
            this.btnmkcolg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmkcolg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnmkcolg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmkcolg.ForeColor = System.Drawing.Color.White;
            this.btnmkcolg.HoverState.Parent = this.btnmkcolg;
            this.btnmkcolg.Location = new System.Drawing.Point(0, 180);
            this.btnmkcolg.Name = "btnmkcolg";
            this.btnmkcolg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmkcolg.ShadowDecoration.Parent = this.btnmkcolg;
            this.btnmkcolg.Size = new System.Drawing.Size(200, 45);
            this.btnmkcolg.TabIndex = 4;
            this.btnmkcolg.Text = "Make Collague";
            this.btnmkcolg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmkcolg.Click += new System.EventHandler(this.btnmkcolg_Click);
            // 
            // btnimgoverlay
            // 
            this.btnimgoverlay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnimgoverlay.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnimgoverlay.CheckedState.Parent = this.btnimgoverlay;
            this.btnimgoverlay.CustomImages.Parent = this.btnimgoverlay;
            this.btnimgoverlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnimgoverlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnimgoverlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnimgoverlay.ForeColor = System.Drawing.Color.White;
            this.btnimgoverlay.HoverState.Parent = this.btnimgoverlay;
            this.btnimgoverlay.Location = new System.Drawing.Point(0, 135);
            this.btnimgoverlay.Name = "btnimgoverlay";
            this.btnimgoverlay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnimgoverlay.ShadowDecoration.Parent = this.btnimgoverlay;
            this.btnimgoverlay.Size = new System.Drawing.Size(200, 45);
            this.btnimgoverlay.TabIndex = 3;
            this.btnimgoverlay.Text = "Image overlay";
            this.btnimgoverlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnimgoverlay.Click += new System.EventHandler(this.btnimgoverlay_Click);
            // 
            // btnremovenoise
            // 
            this.btnremovenoise.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnremovenoise.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnremovenoise.CheckedState.Parent = this.btnremovenoise;
            this.btnremovenoise.CustomImages.Parent = this.btnremovenoise;
            this.btnremovenoise.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnremovenoise.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnremovenoise.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremovenoise.ForeColor = System.Drawing.Color.White;
            this.btnremovenoise.HoverState.Parent = this.btnremovenoise;
            this.btnremovenoise.Location = new System.Drawing.Point(0, 90);
            this.btnremovenoise.Name = "btnremovenoise";
            this.btnremovenoise.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnremovenoise.ShadowDecoration.Parent = this.btnremovenoise;
            this.btnremovenoise.Size = new System.Drawing.Size(200, 45);
            this.btnremovenoise.TabIndex = 2;
            this.btnremovenoise.Text = "Remove noise";
            this.btnremovenoise.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnremovenoise.Click += new System.EventHandler(this.btnremovenoise_Click);
            // 
            // btncropimg
            // 
            this.btncropimg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncropimg.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btncropimg.CheckedState.Parent = this.btncropimg;
            this.btncropimg.CustomImages.Parent = this.btncropimg;
            this.btncropimg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncropimg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btncropimg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncropimg.ForeColor = System.Drawing.Color.White;
            this.btncropimg.HoverState.Parent = this.btncropimg;
            this.btncropimg.Location = new System.Drawing.Point(0, 45);
            this.btncropimg.Name = "btncropimg";
            this.btncropimg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btncropimg.ShadowDecoration.Parent = this.btncropimg;
            this.btncropimg.Size = new System.Drawing.Size(200, 45);
            this.btncropimg.TabIndex = 1;
            this.btncropimg.Text = "Crop images";
            this.btncropimg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncropimg.Click += new System.EventHandler(this.btncropimg_Click);
            // 
            // btnwriteonimg
            // 
            this.btnwriteonimg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnwriteonimg.CheckedState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnwriteonimg.CheckedState.Parent = this.btnwriteonimg;
            this.btnwriteonimg.CustomImages.Parent = this.btnwriteonimg;
            this.btnwriteonimg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnwriteonimg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnwriteonimg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnwriteonimg.ForeColor = System.Drawing.Color.White;
            this.btnwriteonimg.HoverState.Parent = this.btnwriteonimg;
            this.btnwriteonimg.Location = new System.Drawing.Point(0, 0);
            this.btnwriteonimg.Name = "btnwriteonimg";
            this.btnwriteonimg.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnwriteonimg.ShadowDecoration.Parent = this.btnwriteonimg;
            this.btnwriteonimg.Size = new System.Drawing.Size(200, 45);
            this.btnwriteonimg.TabIndex = 0;
            this.btnwriteonimg.Text = "Writeonimages";
            this.btnwriteonimg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnwriteonimg.Click += new System.EventHandler(this.btnwriteonimg_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 139);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 139);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.Panel3.Controls.Add(this.btnmaximize);
            this.Panel3.Controls.Add(this.btnminimize);
            this.Panel3.Controls.Add(this.btnclose);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(210, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(947, 36);
            this.Panel3.TabIndex = 1;
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnmaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnmaximize.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnmaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximize.Image")));
            this.btnmaximize.Location = new System.Drawing.Point(878, 0);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.ShadowDecoration.Parent = this.btnmaximize;
            this.btnmaximize.Size = new System.Drawing.Size(33, 35);
            this.btnmaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmaximize.TabIndex = 2;
            this.btnmaximize.TabStop = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            this.btnmaximize.MouseLeave += new System.EventHandler(this.btnmaximize_MouseLeave);
            this.btnmaximize.MouseHover += new System.EventHandler(this.btnmaximize_MouseHover);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.CheckedState.Parent = this.btnminimize;
            this.btnminimize.CustomImages.Parent = this.btnminimize;
            this.btnminimize.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnminimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnminimize.HoverState.Parent = this.btnminimize;
            this.btnminimize.Location = new System.Drawing.Point(846, 0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.ShadowDecoration.Parent = this.btnminimize;
            this.btnminimize.Size = new System.Drawing.Size(33, 35);
            this.btnminimize.TabIndex = 3;
            this.btnminimize.Text = "-";
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Location = new System.Drawing.Point(910, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(33, 35);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.mainpanel.Controls.Add(this.PictureBox2);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(210, 36);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.ShadowDecoration.Parent = this.mainpanel;
            this.mainpanel.Size = new System.Drawing.Size(947, 664);
            this.mainpanel.TabIndex = 2;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(251, 144);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.ShadowDecoration.Parent = this.PictureBox2;
            this.PictureBox2.Size = new System.Drawing.Size(502, 500);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1157, 700);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximize)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelmenu;
        private Guna.UI2.WinForms.Guna2Button btnwriteonimg;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnremovenoise;
        private Guna.UI2.WinForms.Guna2Button btncropimg;
        private Guna.UI2.WinForms.Guna2Button btnmkcolg;
        private Guna.UI2.WinForms.Guna2Button btnimgoverlay;
        private Guna.UI2.WinForms.Guna2Button btnbr_cr;
        private Guna.UI2.WinForms.Guna2Button btnlgout;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2Button btnminimize;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2PictureBox btnmaximize;
        private Guna.UI2.WinForms.Guna2Panel mainpanel;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox2;
    }
}