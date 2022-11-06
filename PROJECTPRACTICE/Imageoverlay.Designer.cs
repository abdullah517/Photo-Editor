
namespace PROJECTPRACTICE
{
    partial class Imageoverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imageoverlay));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bntloadimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnroi = new Guna.UI2.WinForms.Guna2Button();
            this.btnoverlay = new Guna.UI2.WinForms.Guna2Button();
            this.bntsaveimg = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(310, 13);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(340, 400);
            this.guna2Panel1.TabIndex = 0;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Silver;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.ShadowDecoration.Parent = this.PictureBox1;
            this.PictureBox1.Size = new System.Drawing.Size(340, 400);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // bntloadimg
            // 
            this.bntloadimg.CheckedState.Parent = this.bntloadimg;
            this.bntloadimg.CustomImages.Parent = this.bntloadimg;
            this.bntloadimg.FillColor = System.Drawing.Color.LightBlue;
            this.bntloadimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntloadimg.ForeColor = System.Drawing.Color.White;
            this.bntloadimg.HoverState.Parent = this.bntloadimg;
            this.bntloadimg.Location = new System.Drawing.Point(165, 432);
            this.bntloadimg.Name = "bntloadimg";
            this.bntloadimg.ShadowDecoration.Parent = this.bntloadimg;
            this.bntloadimg.Size = new System.Drawing.Size(180, 45);
            this.bntloadimg.TabIndex = 7;
            this.bntloadimg.Text = "Load image";
            this.bntloadimg.Click += new System.EventHandler(this.bntloadimg_Click);
            // 
            // btnroi
            // 
            this.btnroi.CheckedState.Parent = this.btnroi;
            this.btnroi.CustomImages.Parent = this.btnroi;
            this.btnroi.Enabled = false;
            this.btnroi.FillColor = System.Drawing.Color.LightBlue;
            this.btnroi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroi.ForeColor = System.Drawing.Color.White;
            this.btnroi.HoverState.Parent = this.btnroi;
            this.btnroi.Location = new System.Drawing.Point(396, 432);
            this.btnroi.Name = "btnroi";
            this.btnroi.ShadowDecoration.Parent = this.btnroi;
            this.btnroi.Size = new System.Drawing.Size(180, 45);
            this.btnroi.TabIndex = 8;
            this.btnroi.Text = "Set ROI";
            this.btnroi.Click += new System.EventHandler(this.btnroi_Click);
            // 
            // btnoverlay
            // 
            this.btnoverlay.CheckedState.Parent = this.btnoverlay;
            this.btnoverlay.CustomImages.Parent = this.btnoverlay;
            this.btnoverlay.Enabled = false;
            this.btnoverlay.FillColor = System.Drawing.Color.LightBlue;
            this.btnoverlay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoverlay.ForeColor = System.Drawing.Color.White;
            this.btnoverlay.HoverState.Parent = this.btnoverlay;
            this.btnoverlay.Location = new System.Drawing.Point(633, 432);
            this.btnoverlay.Name = "btnoverlay";
            this.btnoverlay.ShadowDecoration.Parent = this.btnoverlay;
            this.btnoverlay.Size = new System.Drawing.Size(180, 45);
            this.btnoverlay.TabIndex = 9;
            this.btnoverlay.Text = "Overlay image";
            this.btnoverlay.Click += new System.EventHandler(this.btnoverlay_Click);
            // 
            // bntsaveimg
            // 
            this.bntsaveimg.CheckedState.Parent = this.bntsaveimg;
            this.bntsaveimg.CustomImages.Parent = this.bntsaveimg;
            this.bntsaveimg.Enabled = false;
            this.bntsaveimg.FillColor = System.Drawing.Color.LightBlue;
            this.bntsaveimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsaveimg.ForeColor = System.Drawing.Color.White;
            this.bntsaveimg.HoverState.Parent = this.bntsaveimg;
            this.bntsaveimg.Location = new System.Drawing.Point(396, 506);
            this.bntsaveimg.Name = "bntsaveimg";
            this.bntsaveimg.ShadowDecoration.Parent = this.bntsaveimg;
            this.bntsaveimg.Size = new System.Drawing.Size(180, 45);
            this.bntsaveimg.TabIndex = 10;
            this.bntsaveimg.Text = "Save image";
            this.bntsaveimg.Click += new System.EventHandler(this.bntsaveimg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, -3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Imageoverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bntsaveimg);
            this.Controls.Add(this.btnoverlay);
            this.Controls.Add(this.btnroi);
            this.Controls.Add(this.bntloadimg);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imageoverlay";
            this.Text = "Imageoverlay";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button bntloadimg;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnroi;
        private Guna.UI2.WinForms.Guna2Button btnoverlay;
        private Guna.UI2.WinForms.Guna2Button bntsaveimg;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}