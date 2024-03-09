namespace PARKOT.WindowsFormUI
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctr_Cikis = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txb_Sifre = new System.Windows.Forms.TextBox();
            this.txb_Kullanici = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pctr_Cikis
            // 
            this.pctr_Cikis.BackColor = System.Drawing.Color.Black;
            this.pctr_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctr_Cikis.BackgroundImage")));
            this.pctr_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctr_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctr_Cikis.Location = new System.Drawing.Point(601, 12);
            this.pctr_Cikis.Name = "pctr_Cikis";
            this.pctr_Cikis.Size = new System.Drawing.Size(28, 28);
            this.pctr_Cikis.TabIndex = 5;
            this.pctr_Cikis.TabStop = false;
            this.pctr_Cikis.Click += new System.EventHandler(this.pctr_Cikis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(221, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 40);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Black;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.Gold;
            this.btn_Giris.Location = new System.Drawing.Point(444, 7);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 29);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txb_Sifre
            // 
            this.txb_Sifre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Sifre.ForeColor = System.Drawing.Color.Gold;
            this.txb_Sifre.Location = new System.Drawing.Point(275, 12);
            this.txb_Sifre.Name = "txb_Sifre";
            this.txb_Sifre.Size = new System.Drawing.Size(151, 22);
            this.txb_Sifre.TabIndex = 1;
            this.txb_Sifre.UseSystemPasswordChar = true;
            // 
            // txb_Kullanici
            // 
            this.txb_Kullanici.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Kullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Kullanici.ForeColor = System.Drawing.Color.Gold;
            this.txb_Kullanici.Location = new System.Drawing.Point(82, 24);
            this.txb_Kullanici.Name = "txb_Kullanici";
            this.txb_Kullanici.Size = new System.Drawing.Size(151, 22);
            this.txb_Kullanici.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(64, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 392);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pctr_Cikis);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txb_Sifre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txb_Kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKOT Login";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctr_Cikis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txb_Sifre;
        private System.Windows.Forms.TextBox txb_Kullanici;
        private System.Windows.Forms.TextBox textBox1;
    }
}