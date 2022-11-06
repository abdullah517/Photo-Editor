
namespace PROJECTPRACTICE
{
    partial class Writeonimages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Writeonimages));
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.bntloadimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnsaveimg = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddwatermark = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.imageBox1.Location = new System.Drawing.Point(62, 43);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(223, 208);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.Parent = this.TextBox1;
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedState.Parent = this.TextBox1;
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.HoverState.Parent = this.TextBox1;
            this.TextBox1.Location = new System.Drawing.Point(80, 54);
            this.TextBox1.MaxLength = 10;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "Enter any text";
            this.TextBox1.SelectedText = "";
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(180, 44);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.Visible = false;
            this.TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.imageBox2.Location = new System.Drawing.Point(596, 43);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(223, 208);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // bntloadimg
            // 
            this.bntloadimg.CheckedState.Parent = this.bntloadimg;
            this.bntloadimg.CustomImages.Parent = this.bntloadimg;
            this.bntloadimg.FillColor = System.Drawing.Color.LightBlue;
            this.bntloadimg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntloadimg.ForeColor = System.Drawing.Color.White;
            this.bntloadimg.HoverState.Parent = this.bntloadimg;
            this.bntloadimg.Location = new System.Drawing.Point(80, 277);
            this.bntloadimg.Name = "bntloadimg";
            this.bntloadimg.ShadowDecoration.Parent = this.bntloadimg;
            this.bntloadimg.Size = new System.Drawing.Size(180, 45);
            this.bntloadimg.TabIndex = 5;
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
            this.btnsaveimg.Location = new System.Drawing.Point(624, 277);
            this.btnsaveimg.Name = "btnsaveimg";
            this.btnsaveimg.ShadowDecoration.Parent = this.btnsaveimg;
            this.btnsaveimg.Size = new System.Drawing.Size(180, 45);
            this.btnsaveimg.TabIndex = 6;
            this.btnsaveimg.Text = "Save image";
            this.btnsaveimg.Click += new System.EventHandler(this.btnsaveimg_Click);
            // 
            // btnaddwatermark
            // 
            this.btnaddwatermark.CheckedState.Parent = this.btnaddwatermark;
            this.btnaddwatermark.CustomImages.Parent = this.btnaddwatermark;
            this.btnaddwatermark.Enabled = false;
            this.btnaddwatermark.FillColor = System.Drawing.Color.LightBlue;
            this.btnaddwatermark.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddwatermark.ForeColor = System.Drawing.Color.White;
            this.btnaddwatermark.HoverState.Parent = this.btnaddwatermark;
            this.btnaddwatermark.Location = new System.Drawing.Point(80, 358);
            this.btnaddwatermark.Name = "btnaddwatermark";
            this.btnaddwatermark.ShadowDecoration.Parent = this.btnaddwatermark;
            this.btnaddwatermark.Size = new System.Drawing.Size(180, 45);
            this.btnaddwatermark.TabIndex = 7;
            this.btnaddwatermark.Text = "Add Watermark";
            this.btnaddwatermark.Click += new System.EventHandler(this.btnaddwatermark_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Dodger Blue",
            "Cyan",
            "Corn flower blue",
            "Orange",
            "Firebrick",
            "Maroon",
            "Teal",
            "Black",
            "Crimson"});
            this.comboBox1.Location = new System.Drawing.Point(351, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "....Choose Colour....";
            this.comboBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "Top",
            "Middle",
            "Bottom"});
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Top",
            "Middle",
            "Bottom"});
            this.comboBox2.Location = new System.Drawing.Point(351, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 28);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "....Select text location....";
            this.comboBox2.Visible = false;
            // 
            // Writeonimages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(856, 474);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnaddwatermark);
            this.Controls.Add(this.btnsaveimg);
            this.Controls.Add(this.bntloadimg);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.imageBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Writeonimages";
            this.Text = "Writeonimages";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Guna.UI2.WinForms.Guna2Button bntloadimg;
        private Guna.UI2.WinForms.Guna2Button btnsaveimg;
        private Guna.UI2.WinForms.Guna2Button btnaddwatermark;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}