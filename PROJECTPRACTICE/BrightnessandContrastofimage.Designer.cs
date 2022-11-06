
namespace PROJECTPRACTICE
{
    partial class BrightnessandContrastofimage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrightnessandContrastofimage));
            this.lblMinContrast = new System.Windows.Forms.Label();
            this.lblCurrentContrast = new System.Windows.Forms.Label();
            this.lblMaxContrast = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMinBrightness = new System.Windows.Forms.Label();
            this.lblCurrentBrightness = new System.Windows.Forms.Label();
            this.lblMaxBrightness = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bntloadimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnsaveimg = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMinContrast
            // 
            this.lblMinContrast.AutoSize = true;
            this.lblMinContrast.ForeColor = System.Drawing.Color.White;
            this.lblMinContrast.Location = new System.Drawing.Point(5, 411);
            this.lblMinContrast.Name = "lblMinContrast";
            this.lblMinContrast.Size = new System.Drawing.Size(35, 13);
            this.lblMinContrast.TabIndex = 1;
            this.lblMinContrast.Text = "label1";
            // 
            // lblCurrentContrast
            // 
            this.lblCurrentContrast.AutoSize = true;
            this.lblCurrentContrast.ForeColor = System.Drawing.Color.White;
            this.lblCurrentContrast.Location = new System.Drawing.Point(373, 411);
            this.lblCurrentContrast.Name = "lblCurrentContrast";
            this.lblCurrentContrast.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentContrast.TabIndex = 2;
            this.lblCurrentContrast.Text = "label2";
            // 
            // lblMaxContrast
            // 
            this.lblMaxContrast.AutoSize = true;
            this.lblMaxContrast.ForeColor = System.Drawing.Color.White;
            this.lblMaxContrast.Location = new System.Drawing.Point(693, 411);
            this.lblMaxContrast.Name = "lblMaxContrast";
            this.lblMaxContrast.Size = new System.Drawing.Size(35, 13);
            this.lblMaxContrast.TabIndex = 3;
            this.lblMaxContrast.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrast";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(724, 38);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.pictureBox1);
            this.guna2Panel2.Controls.Add(this.groupBox2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 26);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(730, 322);
            this.guna2Panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(85, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.ShadowDecoration.Parent = this.pictureBox1;
            this.pictureBox1.Size = new System.Drawing.Size(477, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMinBrightness);
            this.groupBox2.Controls.Add(this.lblCurrentBrightness);
            this.groupBox2.Controls.Add(this.lblMaxBrightness);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(625, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brightness";
            // 
            // lblMinBrightness
            // 
            this.lblMinBrightness.AutoSize = true;
            this.lblMinBrightness.ForeColor = System.Drawing.Color.White;
            this.lblMinBrightness.Location = new System.Drawing.Point(54, 295);
            this.lblMinBrightness.Name = "lblMinBrightness";
            this.lblMinBrightness.Size = new System.Drawing.Size(35, 13);
            this.lblMinBrightness.TabIndex = 6;
            this.lblMinBrightness.Text = "label6";
            // 
            // lblCurrentBrightness
            // 
            this.lblCurrentBrightness.AutoSize = true;
            this.lblCurrentBrightness.ForeColor = System.Drawing.Color.White;
            this.lblCurrentBrightness.Location = new System.Drawing.Point(58, 171);
            this.lblCurrentBrightness.Name = "lblCurrentBrightness";
            this.lblCurrentBrightness.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentBrightness.TabIndex = 5;
            this.lblCurrentBrightness.Text = "label5";
            // 
            // lblMaxBrightness
            // 
            this.lblMaxBrightness.AutoSize = true;
            this.lblMaxBrightness.ForeColor = System.Drawing.Color.White;
            this.lblMaxBrightness.Location = new System.Drawing.Point(58, 26);
            this.lblMaxBrightness.Name = "lblMaxBrightness";
            this.lblMaxBrightness.Size = new System.Drawing.Size(35, 13);
            this.lblMaxBrightness.TabIndex = 4;
            this.lblMaxBrightness.Text = "label4";
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new System.Drawing.Point(3, 16);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 303);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(730, 405);
            this.guna2Panel1.TabIndex = 0;
            // 
            // bntloadimg
            // 
            this.bntloadimg.CheckedState.Parent = this.bntloadimg;
            this.bntloadimg.CustomImages.Parent = this.bntloadimg;
            this.bntloadimg.FillColor = System.Drawing.Color.LightBlue;
            this.bntloadimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntloadimg.ForeColor = System.Drawing.Color.White;
            this.bntloadimg.HoverState.Parent = this.bntloadimg;
            this.bntloadimg.Location = new System.Drawing.Point(127, 432);
            this.bntloadimg.Name = "bntloadimg";
            this.bntloadimg.ShadowDecoration.Parent = this.bntloadimg;
            this.bntloadimg.Size = new System.Drawing.Size(180, 45);
            this.bntloadimg.TabIndex = 7;
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
            this.btnsaveimg.Location = new System.Drawing.Point(469, 432);
            this.btnsaveimg.Name = "btnsaveimg";
            this.btnsaveimg.ShadowDecoration.Parent = this.btnsaveimg;
            this.btnsaveimg.Size = new System.Drawing.Size(180, 45);
            this.btnsaveimg.TabIndex = 8;
            this.btnsaveimg.Text = "Save image";
            this.btnsaveimg.Click += new System.EventHandler(this.btnsaveimg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BrightnessandContrastofimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(730, 499);
            this.Controls.Add(this.btnsaveimg);
            this.Controls.Add(this.bntloadimg);
            this.Controls.Add(this.lblMaxContrast);
            this.Controls.Add(this.lblCurrentContrast);
            this.Controls.Add(this.lblMinContrast);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrightnessandContrastofimage";
            this.Text = "Brightnessofimage";
            this.Load += new System.EventHandler(this.BrightnessandContrastofimage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMinContrast;
        private System.Windows.Forms.Label lblCurrentContrast;
        private System.Windows.Forms.Label lblMaxContrast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMinBrightness;
        private System.Windows.Forms.Label lblCurrentBrightness;
        private System.Windows.Forms.Label lblMaxBrightness;
        private System.Windows.Forms.TrackBar trackBar2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bntloadimg;
        private Guna.UI2.WinForms.Guna2Button btnsaveimg;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}