namespace PARKOT.WindowsFormUI
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.pnl_Uyelik = new System.Windows.Forms.Panel();
            this.lbl_KayitEkrani = new System.Windows.Forms.Label();
            this.pctr_Geri = new System.Windows.Forms.PictureBox();
            this.lbl_Geri = new System.Windows.Forms.Label();
            this.pctr_Cikis = new System.Windows.Forms.PictureBox();
            this.lbl_Cikis = new System.Windows.Forms.Label();
            this.pctr_Goster = new System.Windows.Forms.PictureBox();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.txb_Kullanici = new System.Windows.Forms.TextBox();
            this.txb_Sifre = new System.Windows.Forms.TextBox();
            this.txb_SifreTekrar = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.lbl_SifreTekrar = new System.Windows.Forms.Label();
            this.mtxb_Gsm = new System.Windows.Forms.MaskedTextBox();
            this.lbl_TelNo = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.KayitZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.txb_Ad = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txb_Soyad = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.yuklemeBari = new System.Windows.Forms.ProgressBar();
            this.pnl_Uyelik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Geri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Goster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Uyelik
            // 
            this.pnl_Uyelik.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Uyelik.Controls.Add(this.txb_Soyad);
            this.pnl_Uyelik.Controls.Add(this.lbl_Soyad);
            this.pnl_Uyelik.Controls.Add(this.txb_Ad);
            this.pnl_Uyelik.Controls.Add(this.lbl_Ad);
            this.pnl_Uyelik.Controls.Add(this.lbl_KayitEkrani);
            this.pnl_Uyelik.Controls.Add(this.pctr_Geri);
            this.pnl_Uyelik.Controls.Add(this.lbl_Geri);
            this.pnl_Uyelik.Controls.Add(this.pctr_Cikis);
            this.pnl_Uyelik.Controls.Add(this.lbl_Cikis);
            this.pnl_Uyelik.Controls.Add(this.pctr_Goster);
            this.pnl_Uyelik.Controls.Add(this.btn_Kayit);
            this.pnl_Uyelik.Controls.Add(this.txb_Kullanici);
            this.pnl_Uyelik.Controls.Add(this.txb_Sifre);
            this.pnl_Uyelik.Controls.Add(this.txb_SifreTekrar);
            this.pnl_Uyelik.Controls.Add(this.txb_Email);
            this.pnl_Uyelik.Controls.Add(this.lbl_SifreTekrar);
            this.pnl_Uyelik.Controls.Add(this.mtxb_Gsm);
            this.pnl_Uyelik.Controls.Add(this.lbl_TelNo);
            this.pnl_Uyelik.Controls.Add(this.lbl_Mail);
            this.pnl_Uyelik.Controls.Add(this.lbl_Sifre);
            this.pnl_Uyelik.Controls.Add(this.lbl_KullaniciAdi);
            this.pnl_Uyelik.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_Uyelik.Location = new System.Drawing.Point(12, 13);
            this.pnl_Uyelik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Uyelik.Name = "pnl_Uyelik";
            this.pnl_Uyelik.Size = new System.Drawing.Size(385, 387);
            this.pnl_Uyelik.TabIndex = 2;
            // 
            // lbl_KayitEkrani
            // 
            this.lbl_KayitEkrani.AutoSize = true;
            this.lbl_KayitEkrani.ForeColor = System.Drawing.Color.Gold;
            this.lbl_KayitEkrani.Location = new System.Drawing.Point(158, 49);
            this.lbl_KayitEkrani.Name = "lbl_KayitEkrani";
            this.lbl_KayitEkrani.Size = new System.Drawing.Size(104, 21);
            this.lbl_KayitEkrani.TabIndex = 9;
            this.lbl_KayitEkrani.Text = "PARKOT KAYIT";
            // 
            // pctr_Geri
            // 
            this.pctr_Geri.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctr_Geri.BackgroundImage")));
            this.pctr_Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctr_Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctr_Geri.Location = new System.Drawing.Point(2, 7);
            this.pctr_Geri.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctr_Geri.Name = "pctr_Geri";
            this.pctr_Geri.Size = new System.Drawing.Size(42, 33);
            this.pctr_Geri.TabIndex = 6;
            this.pctr_Geri.TabStop = false;
            this.pctr_Geri.Click += new System.EventHandler(this.pctr_Geri_Click);
            this.pctr_Geri.MouseEnter += new System.EventHandler(this.pctr_Geri_MouseEnter);
            this.pctr_Geri.MouseLeave += new System.EventHandler(this.pctr_Geri_MouseLeave);
            // 
            // lbl_Geri
            // 
            this.lbl_Geri.AutoSize = true;
            this.lbl_Geri.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Geri.Location = new System.Drawing.Point(49, 19);
            this.lbl_Geri.Name = "lbl_Geri";
            this.lbl_Geri.Size = new System.Drawing.Size(39, 21);
            this.lbl_Geri.TabIndex = 8;
            this.lbl_Geri.Text = "Geri";
            this.lbl_Geri.Visible = false;
            // 
            // pctr_Cikis
            // 
            this.pctr_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.pctr_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctr_Cikis.BackgroundImage")));
            this.pctr_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctr_Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctr_Cikis.Location = new System.Drawing.Point(338, 7);
            this.pctr_Cikis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctr_Cikis.Name = "pctr_Cikis";
            this.pctr_Cikis.Size = new System.Drawing.Size(35, 33);
            this.pctr_Cikis.TabIndex = 5;
            this.pctr_Cikis.TabStop = false;
            this.pctr_Cikis.Click += new System.EventHandler(this.pctr_Cikis_Click);
            this.pctr_Cikis.MouseEnter += new System.EventHandler(this.pctr_Cikis_MouseEnter);
            this.pctr_Cikis.MouseLeave += new System.EventHandler(this.pctr_Cikis_MouseLeave);
            // 
            // lbl_Cikis
            // 
            this.lbl_Cikis.AutoSize = true;
            this.lbl_Cikis.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Cikis.Location = new System.Drawing.Point(288, 19);
            this.lbl_Cikis.Name = "lbl_Cikis";
            this.lbl_Cikis.Size = new System.Drawing.Size(45, 21);
            this.lbl_Cikis.TabIndex = 7;
            this.lbl_Cikis.Text = "Çıkış";
            this.lbl_Cikis.Visible = false;
            // 
            // pctr_Goster
            // 
            this.pctr_Goster.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctr_Goster.BackgroundImage")));
            this.pctr_Goster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctr_Goster.Location = new System.Drawing.Point(313, 198);
            this.pctr_Goster.Name = "pctr_Goster";
            this.pctr_Goster.Size = new System.Drawing.Size(32, 27);
            this.pctr_Goster.TabIndex = 6;
            this.pctr_Goster.TabStop = false;
            this.pctr_Goster.MouseEnter += new System.EventHandler(this.pctr_Goster_MouseEnter);
            this.pctr_Goster.MouseLeave += new System.EventHandler(this.pctr_Goster_MouseLeave);
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kayit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kayit.ForeColor = System.Drawing.Color.Gold;
            this.btn_Kayit.Location = new System.Drawing.Point(220, 325);
            this.btn_Kayit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(77, 32);
            this.btn_Kayit.TabIndex = 7;
            this.btn_Kayit.Text = "Kayıt";
            this.btn_Kayit.UseVisualStyleBackColor = false;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // txb_Kullanici
            // 
            this.txb_Kullanici.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Kullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Kullanici.ForeColor = System.Drawing.Color.Gold;
            this.txb_Kullanici.Location = new System.Drawing.Point(161, 166);
            this.txb_Kullanici.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_Kullanici.Name = "txb_Kullanici";
            this.txb_Kullanici.Size = new System.Drawing.Size(147, 27);
            this.txb_Kullanici.TabIndex = 2;
            // 
            // txb_Sifre
            // 
            this.txb_Sifre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Sifre.ForeColor = System.Drawing.Color.Gold;
            this.txb_Sifre.Location = new System.Drawing.Point(161, 198);
            this.txb_Sifre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_Sifre.Name = "txb_Sifre";
            this.txb_Sifre.Size = new System.Drawing.Size(147, 27);
            this.txb_Sifre.TabIndex = 3;
            this.txb_Sifre.UseSystemPasswordChar = true;
            // 
            // txb_SifreTekrar
            // 
            this.txb_SifreTekrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_SifreTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_SifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_SifreTekrar.ForeColor = System.Drawing.Color.Gold;
            this.txb_SifreTekrar.Location = new System.Drawing.Point(161, 230);
            this.txb_SifreTekrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_SifreTekrar.Name = "txb_SifreTekrar";
            this.txb_SifreTekrar.Size = new System.Drawing.Size(147, 27);
            this.txb_SifreTekrar.TabIndex = 4;
            this.txb_SifreTekrar.UseSystemPasswordChar = true;
            // 
            // txb_Email
            // 
            this.txb_Email.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Email.ForeColor = System.Drawing.Color.Gold;
            this.txb_Email.Location = new System.Drawing.Point(161, 262);
            this.txb_Email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(147, 27);
            this.txb_Email.TabIndex = 5;
            // 
            // lbl_SifreTekrar
            // 
            this.lbl_SifreTekrar.AutoSize = true;
            this.lbl_SifreTekrar.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SifreTekrar.ForeColor = System.Drawing.Color.Gold;
            this.lbl_SifreTekrar.Location = new System.Drawing.Point(46, 236);
            this.lbl_SifreTekrar.Name = "lbl_SifreTekrar";
            this.lbl_SifreTekrar.Size = new System.Drawing.Size(95, 21);
            this.lbl_SifreTekrar.TabIndex = 5;
            this.lbl_SifreTekrar.Text = "Şifre Tekrar:";
            // 
            // mtxb_Gsm
            // 
            this.mtxb_Gsm.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mtxb_Gsm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxb_Gsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxb_Gsm.ForeColor = System.Drawing.Color.Gold;
            this.mtxb_Gsm.Location = new System.Drawing.Point(161, 293);
            this.mtxb_Gsm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mtxb_Gsm.Mask = "(500)000-00-00";
            this.mtxb_Gsm.Name = "mtxb_Gsm";
            this.mtxb_Gsm.Size = new System.Drawing.Size(147, 20);
            this.mtxb_Gsm.TabIndex = 6;
            this.mtxb_Gsm.Click += new System.EventHandler(this.mtxb_Gsm_Click);
            // 
            // lbl_TelNo
            // 
            this.lbl_TelNo.AutoSize = true;
            this.lbl_TelNo.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TelNo.ForeColor = System.Drawing.Color.Gold;
            this.lbl_TelNo.Location = new System.Drawing.Point(77, 293);
            this.lbl_TelNo.Name = "lbl_TelNo";
            this.lbl_TelNo.Size = new System.Drawing.Size(64, 21);
            this.lbl_TelNo.TabIndex = 3;
            this.lbl_TelNo.Text = "GSM No:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mail.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Mail.Location = new System.Drawing.Point(84, 268);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(57, 21);
            this.lbl_Mail.TabIndex = 2;
            this.lbl_Mail.Text = "E-mail:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Sifre.Location = new System.Drawing.Point(94, 201);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(47, 21);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.ForeColor = System.Drawing.Color.Gold;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(38, 172);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(103, 21);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // KayitZamanlayici
            // 
            this.KayitZamanlayici.Interval = 10;
            this.KayitZamanlayici.Tick += new System.EventHandler(this.KayitZamanlayici_Tick);
            // 
            // txb_Ad
            // 
            this.txb_Ad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Ad.ForeColor = System.Drawing.Color.Gold;
            this.txb_Ad.Location = new System.Drawing.Point(162, 101);
            this.txb_Ad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_Ad.Name = "txb_Ad";
            this.txb_Ad.Size = new System.Drawing.Size(147, 27);
            this.txb_Ad.TabIndex = 0;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Ad.Location = new System.Drawing.Point(97, 107);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(44, 21);
            this.lbl_Ad.TabIndex = 11;
            this.lbl_Ad.Text = "İsim:";
            // 
            // txb_Soyad
            // 
            this.txb_Soyad.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txb_Soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_Soyad.ForeColor = System.Drawing.Color.Gold;
            this.txb_Soyad.Location = new System.Drawing.Point(162, 133);
            this.txb_Soyad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txb_Soyad.Name = "txb_Soyad";
            this.txb_Soyad.Size = new System.Drawing.Size(147, 27);
            this.txb_Soyad.TabIndex = 1;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Soyad.Location = new System.Drawing.Point(71, 140);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(70, 21);
            this.lbl_Soyad.TabIndex = 13;
            this.lbl_Soyad.Text = "Soyisim:";
            // 
            // yuklemeBari
            // 
            this.yuklemeBari.Location = new System.Drawing.Point(0, 461);
            this.yuklemeBari.Name = "yuklemeBari";
            this.yuklemeBari.Size = new System.Drawing.Size(403, 10);
            this.yuklemeBari.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.yuklemeBari.TabIndex = 14;
            this.yuklemeBari.Visible = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 472);
            this.Controls.Add(this.yuklemeBari);
            this.Controls.Add(this.pnl_Uyelik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.pnl_Uyelik.ResumeLayout(false);
            this.pnl_Uyelik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Geri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Cikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctr_Goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Uyelik;
        private System.Windows.Forms.Label lbl_KayitEkrani;
        private System.Windows.Forms.PictureBox pctr_Geri;
        private System.Windows.Forms.Label lbl_Geri;
        private System.Windows.Forms.PictureBox pctr_Cikis;
        private System.Windows.Forms.Label lbl_Cikis;
        private System.Windows.Forms.PictureBox pctr_Goster;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.TextBox txb_Kullanici;
        private System.Windows.Forms.TextBox txb_Sifre;
        private System.Windows.Forms.TextBox txb_SifreTekrar;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label lbl_SifreTekrar;
        private System.Windows.Forms.MaskedTextBox mtxb_Gsm;
        private System.Windows.Forms.Label lbl_TelNo;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Timer KayitZamanlayici;
        private System.Windows.Forms.TextBox txb_Soyad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txb_Ad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.ProgressBar yuklemeBari;
    }
}