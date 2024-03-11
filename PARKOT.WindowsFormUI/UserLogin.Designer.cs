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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txb_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Kullanici = new System.Windows.Forms.TextBox();
            this.yuklenme_Bari = new System.Windows.Forms.ProgressBar();
            this.Giris_Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.lbl_GirisOnayi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctr_Cikis = new System.Windows.Forms.PictureBox();
            this.pictureSifre = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureArkaPlan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArkaPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Black;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.Gold;
            this.btn_Giris.Location = new System.Drawing.Point(471, 345);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(92, 33);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txb_Sifre
            // 
            this.txb_Sifre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Sifre.ForeColor = System.Drawing.Color.Gold;
            this.txb_Sifre.Location = new System.Drawing.Point(302, 356);
            this.txb_Sifre.Name = "txb_Sifre";
            this.txb_Sifre.Size = new System.Drawing.Size(146, 22);
            this.txb_Sifre.TabIndex = 1;
            this.txb_Sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "PARKOT";
            // 
            // txb_Kullanici
            // 
            this.txb_Kullanici.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Kullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Kullanici.ForeColor = System.Drawing.Color.Gold;
            this.txb_Kullanici.Location = new System.Drawing.Point(91, 356);
            this.txb_Kullanici.Name = "txb_Kullanici";
            this.txb_Kullanici.Size = new System.Drawing.Size(146, 22);
            this.txb_Kullanici.TabIndex = 0;
            // 
            // yuklenme_Bari
            // 
            this.yuklenme_Bari.Location = new System.Drawing.Point(0, 384);
            this.yuklenme_Bari.Name = "yuklenme_Bari";
            this.yuklenme_Bari.Size = new System.Drawing.Size(685, 17);
            this.yuklenme_Bari.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.yuklenme_Bari.TabIndex = 13;
            this.yuklenme_Bari.Visible = false;
            // 
            // Giris_Zamanlayici
            // 
            this.Giris_Zamanlayici.Interval = 20;
            this.Giris_Zamanlayici.Tick += new System.EventHandler(this.Giris_Zamanlayici_Tick);
            // 
            // lbl_GirisOnayi
            // 
            this.lbl_GirisOnayi.AutoSize = true;
            this.lbl_GirisOnayi.BackColor = System.Drawing.Color.Black;
            this.lbl_GirisOnayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GirisOnayi.ForeColor = System.Drawing.Color.Gold;
            this.lbl_GirisOnayi.Location = new System.Drawing.Point(272, 384);
            this.lbl_GirisOnayi.Name = "lbl_GirisOnayi";
            this.lbl_GirisOnayi.Size = new System.Drawing.Size(121, 16);
            this.lbl_GirisOnayi.TabIndex = 14;
            this.lbl_GirisOnayi.Text = "Giriş Onaylandı..";
            this.lbl_GirisOnayi.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(623, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(597, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pctr_Cikis
            // 
            this.pctr_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctr_Cikis.BackgroundImage")));
            this.pctr_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctr_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctr_Cikis.Location = new System.Drawing.Point(645, 9);
            this.pctr_Cikis.Name = "pctr_Cikis";
            this.pctr_Cikis.Size = new System.Drawing.Size(28, 28);
            this.pctr_Cikis.TabIndex = 5;
            this.pctr_Cikis.TabStop = false;
            this.pctr_Cikis.Click += new System.EventHandler(this.pctr_Cikis_Click);
            // 
            // pictureSifre
            // 
            this.pictureSifre.BackColor = System.Drawing.Color.Transparent;
            this.pictureSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSifre.BackgroundImage")));
            this.pictureSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSifre.Location = new System.Drawing.Point(248, 345);
            this.pictureSifre.Name = "pictureSifre";
            this.pictureSifre.Size = new System.Drawing.Size(48, 37);
            this.pictureSifre.TabIndex = 7;
            this.pictureSifre.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureUser.BackgroundImage")));
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Location = new System.Drawing.Point(39, 345);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(46, 37);
            this.pictureUser.TabIndex = 6;
            this.pictureUser.TabStop = false;
            // 
            // pictureArkaPlan
            // 
            this.pictureArkaPlan.BackColor = System.Drawing.Color.Transparent;
            this.pictureArkaPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureArkaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureArkaPlan.Image = ((System.Drawing.Image)(resources.GetObject("pictureArkaPlan.Image")));
            this.pictureArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.pictureArkaPlan.Name = "pictureArkaPlan";
            this.pictureArkaPlan.Size = new System.Drawing.Size(685, 401);
            this.pictureArkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArkaPlan.TabIndex = 0;
            this.pictureArkaPlan.TabStop = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(685, 401);
            this.Controls.Add(this.lbl_GirisOnayi);
            this.Controls.Add(this.yuklenme_Bari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txb_Kullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctr_Cikis);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.pictureSifre);
            this.Controls.Add(this.txb_Sifre);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.pictureArkaPlan);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKOT Login";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArkaPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArkaPlan;
        private System.Windows.Forms.PictureBox pctr_Cikis;
        private System.Windows.Forms.PictureBox pictureSifre;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txb_Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Kullanici;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar yuklenme_Bari;
        private System.Windows.Forms.Timer Giris_Zamanlayici;
        private System.Windows.Forms.Label lbl_GirisOnayi;
    }
}