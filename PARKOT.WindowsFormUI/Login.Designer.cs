namespace PARKOT.WindowsFormUI
{
    partial class Parkot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkot));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelPark = new System.Windows.Forms.Panel();
            this.checkbox_Verigizle = new System.Windows.Forms.CheckBox();
            this.lbl_Cikis = new System.Windows.Forms.Label();
            this.pnl_Fis = new System.Windows.Forms.Panel();
            this.lbl_bosParkSayisi = new System.Windows.Forms.Label();
            this.lbl_Ucret = new System.Windows.Forms.Label();
            this.lbl_Plakalar = new System.Windows.Forms.Label();
            this.picture_Cikis = new System.Windows.Forms.PictureBox();
            this.gbx_ParkTcArama = new System.Windows.Forms.GroupBox();
            this.tbx_ParkTcNoArama = new System.Windows.Forms.TextBox();
            this.gbx_ParkUyeBilgi = new System.Windows.Forms.GroupBox();
            this.lbl_ParkYeriNo = new System.Windows.Forms.Label();
            this.lbl_ParkYeri = new System.Windows.Forms.Label();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.tbx_ParkTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.tbx_ParkTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btn_ParkAracCikis = new System.Windows.Forms.Button();
            this.btn_ParkAracGiris = new System.Windows.Forms.Button();
            this.lbl_TelefonNo = new System.Windows.Forms.Label();
            this.tbx_ParkAd = new System.Windows.Forms.TextBox();
            this.lbl_ParkPlaka = new System.Windows.Forms.Label();
            this.tbx_ParkSoyad = new System.Windows.Forms.TextBox();
            this.tbx_ParkMarka = new System.Windows.Forms.TextBox();
            this.lbl_ParkMarka = new System.Windows.Forms.Label();
            this.tbx_ParkPlaka = new System.Windows.Forms.TextBox();
            this.lbl_ParkAd = new System.Windows.Forms.Label();
            this.lbl_ParkTcNo = new System.Windows.Forms.Label();
            this.lbl_ParkSoyAd = new System.Windows.Forms.Label();
            this.dgw_Cars = new System.Windows.Forms.DataGridView();
            this.pnl_Fis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cikis)).BeginInit();
            this.gbx_ParkTcArama.SuspendLayout();
            this.gbx_ParkUyeBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Cars)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPark
            // 
            this.PanelPark.AutoScroll = true;
            this.PanelPark.BackColor = System.Drawing.Color.Transparent;
            this.PanelPark.Location = new System.Drawing.Point(14, 44);
            this.PanelPark.Name = "PanelPark";
            this.PanelPark.Size = new System.Drawing.Size(484, 334);
            this.PanelPark.TabIndex = 36;
            // 
            // checkbox_Verigizle
            // 
            this.checkbox_Verigizle.AutoSize = true;
            this.checkbox_Verigizle.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_Verigizle.ForeColor = System.Drawing.Color.Gold;
            this.checkbox_Verigizle.Location = new System.Drawing.Point(23, 386);
            this.checkbox_Verigizle.Name = "checkbox_Verigizle";
            this.checkbox_Verigizle.Size = new System.Drawing.Size(96, 20);
            this.checkbox_Verigizle.TabIndex = 10;
            this.checkbox_Verigizle.Text = "Veriyi Gizle";
            this.checkbox_Verigizle.UseVisualStyleBackColor = false;
            this.checkbox_Verigizle.CheckedChanged += new System.EventHandler(this.checkbox_Verigizle_CheckedChanged);
            // 
            // lbl_Cikis
            // 
            this.lbl_Cikis.AutoSize = true;
            this.lbl_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cikis.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Cikis.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Cikis.Location = new System.Drawing.Point(1100, 9);
            this.lbl_Cikis.Name = "lbl_Cikis";
            this.lbl_Cikis.Size = new System.Drawing.Size(41, 19);
            this.lbl_Cikis.TabIndex = 34;
            this.lbl_Cikis.Text = "ÇIKIŞ";
            this.lbl_Cikis.Visible = false;
            // 
            // pnl_Fis
            // 
            this.pnl_Fis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Fis.Controls.Add(this.lbl_bosParkSayisi);
            this.pnl_Fis.Controls.Add(this.lbl_Ucret);
            this.pnl_Fis.Controls.Add(this.lbl_Plakalar);
            this.pnl_Fis.Location = new System.Drawing.Point(517, 44);
            this.pnl_Fis.Name = "pnl_Fis";
            this.pnl_Fis.Size = new System.Drawing.Size(200, 252);
            this.pnl_Fis.TabIndex = 33;
            // 
            // lbl_bosParkSayisi
            // 
            this.lbl_bosParkSayisi.AutoSize = true;
            this.lbl_bosParkSayisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_bosParkSayisi.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bosParkSayisi.ForeColor = System.Drawing.Color.Gold;
            this.lbl_bosParkSayisi.Location = new System.Drawing.Point(14, 192);
            this.lbl_bosParkSayisi.Name = "lbl_bosParkSayisi";
            this.lbl_bosParkSayisi.Size = new System.Drawing.Size(0, 22);
            this.lbl_bosParkSayisi.TabIndex = 23;
            // 
            // lbl_Ucret
            // 
            this.lbl_Ucret.AutoSize = true;
            this.lbl_Ucret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ucret.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Ucret.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ucret.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Ucret.Location = new System.Drawing.Point(14, 94);
            this.lbl_Ucret.Name = "lbl_Ucret";
            this.lbl_Ucret.Size = new System.Drawing.Size(0, 25);
            this.lbl_Ucret.TabIndex = 22;
            // 
            // lbl_Plakalar
            // 
            this.lbl_Plakalar.AutoSize = true;
            this.lbl_Plakalar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Plakalar.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Plakalar.Location = new System.Drawing.Point(14, 24);
            this.lbl_Plakalar.Name = "lbl_Plakalar";
            this.lbl_Plakalar.Size = new System.Drawing.Size(0, 25);
            this.lbl_Plakalar.TabIndex = 21;
            // 
            // picture_Cikis
            // 
            this.picture_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.picture_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Cikis.BackgroundImage")));
            this.picture_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Cikis.Location = new System.Drawing.Point(1147, 4);
            this.picture_Cikis.Name = "picture_Cikis";
            this.picture_Cikis.Size = new System.Drawing.Size(44, 41);
            this.picture_Cikis.TabIndex = 31;
            this.picture_Cikis.TabStop = false;
            this.picture_Cikis.Click += new System.EventHandler(this.picture_Cikis_Click);
            this.picture_Cikis.MouseEnter += new System.EventHandler(this.picture_Cikis_MouseEnter);
            this.picture_Cikis.MouseLeave += new System.EventHandler(this.picture_Cikis_MouseLeave);
            // 
            // gbx_ParkTcArama
            // 
            this.gbx_ParkTcArama.BackColor = System.Drawing.Color.Transparent;
            this.gbx_ParkTcArama.Controls.Add(this.tbx_ParkTcNoArama);
            this.gbx_ParkTcArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_ParkTcArama.ForeColor = System.Drawing.Color.Gold;
            this.gbx_ParkTcArama.Location = new System.Drawing.Point(517, 334);
            this.gbx_ParkTcArama.Name = "gbx_ParkTcArama";
            this.gbx_ParkTcArama.Size = new System.Drawing.Size(216, 61);
            this.gbx_ParkTcArama.TabIndex = 30;
            this.gbx_ParkTcArama.TabStop = false;
            this.gbx_ParkTcArama.Text = "TC No ile Arama ";
            // 
            // tbx_ParkTcNoArama
            // 
            this.tbx_ParkTcNoArama.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbx_ParkTcNoArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkTcNoArama.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkTcNoArama.Location = new System.Drawing.Point(18, 22);
            this.tbx_ParkTcNoArama.Name = "tbx_ParkTcNoArama";
            this.tbx_ParkTcNoArama.Size = new System.Drawing.Size(182, 22);
            this.tbx_ParkTcNoArama.TabIndex = 8;
            this.tbx_ParkTcNoArama.TextChanged += new System.EventHandler(this.tbx_ParkTcNoArama_TextChanged);
            // 
            // gbx_ParkUyeBilgi
            // 
            this.gbx_ParkUyeBilgi.BackColor = System.Drawing.Color.Transparent;
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkYeriNo);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkYeri);
            this.gbx_ParkUyeBilgi.Controls.Add(this.btn_Temizle);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkTelefonNo);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkTcNo);
            this.gbx_ParkUyeBilgi.Controls.Add(this.btn_ParkAracCikis);
            this.gbx_ParkUyeBilgi.Controls.Add(this.btn_ParkAracGiris);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_TelefonNo);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkAd);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkPlaka);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkSoyad);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkMarka);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkMarka);
            this.gbx_ParkUyeBilgi.Controls.Add(this.tbx_ParkPlaka);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkAd);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkTcNo);
            this.gbx_ParkUyeBilgi.Controls.Add(this.lbl_ParkSoyAd);
            this.gbx_ParkUyeBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_ParkUyeBilgi.ForeColor = System.Drawing.Color.Gold;
            this.gbx_ParkUyeBilgi.Location = new System.Drawing.Point(757, 40);
            this.gbx_ParkUyeBilgi.Name = "gbx_ParkUyeBilgi";
            this.gbx_ParkUyeBilgi.Size = new System.Drawing.Size(373, 338);
            this.gbx_ParkUyeBilgi.TabIndex = 29;
            this.gbx_ParkUyeBilgi.TabStop = false;
            this.gbx_ParkUyeBilgi.Text = "Kişisel Bilgiler";
            // 
            // lbl_ParkYeriNo
            // 
            this.lbl_ParkYeriNo.AutoSize = true;
            this.lbl_ParkYeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkYeriNo.Location = new System.Drawing.Point(145, 226);
            this.lbl_ParkYeriNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkYeriNo.Name = "lbl_ParkYeriNo";
            this.lbl_ParkYeriNo.Size = new System.Drawing.Size(0, 25);
            this.lbl_ParkYeriNo.TabIndex = 23;
            // 
            // lbl_ParkYeri
            // 
            this.lbl_ParkYeri.AutoSize = true;
            this.lbl_ParkYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkYeri.Location = new System.Drawing.Point(16, 226);
            this.lbl_ParkYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkYeri.Name = "lbl_ParkYeri";
            this.lbl_ParkYeri.Size = new System.Drawing.Size(87, 20);
            this.lbl_ParkYeri.TabIndex = 22;
            this.lbl_ParkYeri.Text = "Park Yeri :";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Black;
            this.btn_Temizle.Location = new System.Drawing.Point(25, 259);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(78, 28);
            this.btn_Temizle.TabIndex = 9;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = false;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // tbx_ParkTelefonNo
            // 
            this.tbx_ParkTelefonNo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbx_ParkTelefonNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkTelefonNo.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkTelefonNo.Location = new System.Drawing.Point(133, 131);
            this.tbx_ParkTelefonNo.Mask = "+\\9\\0\\ (500) 000-00-00";
            this.tbx_ParkTelefonNo.Name = "tbx_ParkTelefonNo";
            this.tbx_ParkTelefonNo.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkTelefonNo.TabIndex = 3;
            this.tbx_ParkTelefonNo.Click += new System.EventHandler(this.tbx_ParkTelefonNo_Click);
            // 
            // tbx_ParkTcNo
            // 
            this.tbx_ParkTcNo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbx_ParkTcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkTcNo.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkTcNo.Location = new System.Drawing.Point(133, 101);
            this.tbx_ParkTcNo.Mask = "00000000000";
            this.tbx_ParkTcNo.Name = "tbx_ParkTcNo";
            this.tbx_ParkTcNo.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkTcNo.TabIndex = 2;
            this.tbx_ParkTcNo.ValidatingType = typeof(int);
            this.tbx_ParkTcNo.Click += new System.EventHandler(this.tbx_ParkTcNo_Click);
            // 
            // btn_ParkAracCikis
            // 
            this.btn_ParkAracCikis.BackColor = System.Drawing.Color.Red;
            this.btn_ParkAracCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ParkAracCikis.Enabled = false;
            this.btn_ParkAracCikis.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ParkAracCikis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ParkAracCikis.Location = new System.Drawing.Point(137, 297);
            this.btn_ParkAracCikis.Name = "btn_ParkAracCikis";
            this.btn_ParkAracCikis.Size = new System.Drawing.Size(181, 34);
            this.btn_ParkAracCikis.TabIndex = 7;
            this.btn_ParkAracCikis.Text = "ARAÇ PARK ÇIKIŞ";
            this.btn_ParkAracCikis.UseVisualStyleBackColor = false;
            this.btn_ParkAracCikis.Click += new System.EventHandler(this.btn_ParkAracCikis_Click);
            // 
            // btn_ParkAracGiris
            // 
            this.btn_ParkAracGiris.BackColor = System.Drawing.Color.Lime;
            this.btn_ParkAracGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ParkAracGiris.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ParkAracGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ParkAracGiris.Location = new System.Drawing.Point(137, 255);
            this.btn_ParkAracGiris.Name = "btn_ParkAracGiris";
            this.btn_ParkAracGiris.Size = new System.Drawing.Size(181, 34);
            this.btn_ParkAracGiris.TabIndex = 6;
            this.btn_ParkAracGiris.Text = "ARAÇ PARK GİRİŞ";
            this.btn_ParkAracGiris.UseVisualStyleBackColor = false;
            this.btn_ParkAracGiris.Click += new System.EventHandler(this.btn_ParkAracGiris_Click);
            // 
            // lbl_TelefonNo
            // 
            this.lbl_TelefonNo.AutoSize = true;
            this.lbl_TelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TelefonNo.Location = new System.Drawing.Point(29, 130);
            this.lbl_TelefonNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TelefonNo.Name = "lbl_TelefonNo";
            this.lbl_TelefonNo.Size = new System.Drawing.Size(74, 20);
            this.lbl_TelefonNo.TabIndex = 19;
            this.lbl_TelefonNo.Text = "Telefon :";
            // 
            // tbx_ParkAd
            // 
            this.tbx_ParkAd.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbx_ParkAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkAd.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkAd.Location = new System.Drawing.Point(133, 38);
            this.tbx_ParkAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ParkAd.Name = "tbx_ParkAd";
            this.tbx_ParkAd.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkAd.TabIndex = 0;
            // 
            // lbl_ParkPlaka
            // 
            this.lbl_ParkPlaka.AutoSize = true;
            this.lbl_ParkPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkPlaka.Location = new System.Drawing.Point(43, 189);
            this.lbl_ParkPlaka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkPlaka.Name = "lbl_ParkPlaka";
            this.lbl_ParkPlaka.Size = new System.Drawing.Size(60, 20);
            this.lbl_ParkPlaka.TabIndex = 12;
            this.lbl_ParkPlaka.Text = "Plaka :";
            // 
            // tbx_ParkSoyad
            // 
            this.tbx_ParkSoyad.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbx_ParkSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkSoyad.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkSoyad.Location = new System.Drawing.Point(133, 70);
            this.tbx_ParkSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ParkSoyad.Name = "tbx_ParkSoyad";
            this.tbx_ParkSoyad.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkSoyad.TabIndex = 1;
            // 
            // tbx_ParkMarka
            // 
            this.tbx_ParkMarka.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbx_ParkMarka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkMarka.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkMarka.Location = new System.Drawing.Point(133, 159);
            this.tbx_ParkMarka.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ParkMarka.Name = "tbx_ParkMarka";
            this.tbx_ParkMarka.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkMarka.TabIndex = 4;
            // 
            // lbl_ParkMarka
            // 
            this.lbl_ParkMarka.AutoSize = true;
            this.lbl_ParkMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkMarka.Location = new System.Drawing.Point(38, 161);
            this.lbl_ParkMarka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkMarka.Name = "lbl_ParkMarka";
            this.lbl_ParkMarka.Size = new System.Drawing.Size(65, 20);
            this.lbl_ParkMarka.TabIndex = 10;
            this.lbl_ParkMarka.Text = "Marka :";
            // 
            // tbx_ParkPlaka
            // 
            this.tbx_ParkPlaka.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbx_ParkPlaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_ParkPlaka.ForeColor = System.Drawing.Color.Gold;
            this.tbx_ParkPlaka.Location = new System.Drawing.Point(133, 189);
            this.tbx_ParkPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ParkPlaka.Name = "tbx_ParkPlaka";
            this.tbx_ParkPlaka.Size = new System.Drawing.Size(229, 22);
            this.tbx_ParkPlaka.TabIndex = 5;
            // 
            // lbl_ParkAd
            // 
            this.lbl_ParkAd.AutoSize = true;
            this.lbl_ParkAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkAd.Location = new System.Drawing.Point(53, 40);
            this.lbl_ParkAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkAd.Name = "lbl_ParkAd";
            this.lbl_ParkAd.Size = new System.Drawing.Size(50, 20);
            this.lbl_ParkAd.TabIndex = 5;
            this.lbl_ParkAd.Text = "İsim :";
            // 
            // lbl_ParkTcNo
            // 
            this.lbl_ParkTcNo.AutoSize = true;
            this.lbl_ParkTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkTcNo.Location = new System.Drawing.Point(36, 101);
            this.lbl_ParkTcNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkTcNo.Name = "lbl_ParkTcNo";
            this.lbl_ParkTcNo.Size = new System.Drawing.Size(67, 20);
            this.lbl_ParkTcNo.TabIndex = 9;
            this.lbl_ParkTcNo.Text = "TC No :";
            // 
            // lbl_ParkSoyAd
            // 
            this.lbl_ParkSoyAd.AutoSize = true;
            this.lbl_ParkSoyAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ParkSoyAd.Location = new System.Drawing.Point(25, 72);
            this.lbl_ParkSoyAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ParkSoyAd.Name = "lbl_ParkSoyAd";
            this.lbl_ParkSoyAd.Size = new System.Drawing.Size(78, 20);
            this.lbl_ParkSoyAd.TabIndex = 8;
            this.lbl_ParkSoyAd.Text = "Soyisim :";
            // 
            // dgw_Cars
            // 
            this.dgw_Cars.AllowUserToAddRows = false;
            this.dgw_Cars.AllowUserToDeleteRows = false;
            this.dgw_Cars.AllowUserToResizeColumns = false;
            this.dgw_Cars.AllowUserToResizeRows = false;
            this.dgw_Cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Cars.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgw_Cars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Cars.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_Cars.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_Cars.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgw_Cars.Location = new System.Drawing.Point(14, 413);
            this.dgw_Cars.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_Cars.MultiSelect = false;
            this.dgw_Cars.Name = "dgw_Cars";
            this.dgw_Cars.ReadOnly = true;
            this.dgw_Cars.RowHeadersWidth = 51;
            this.dgw_Cars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_Cars.Size = new System.Drawing.Size(1177, 260);
            this.dgw_Cars.TabIndex = 28;
            this.dgw_Cars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Cars_CellClick);
            // 
            // Parkot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1201, 681);
            this.Controls.Add(this.PanelPark);
            this.Controls.Add(this.checkbox_Verigizle);
            this.Controls.Add(this.lbl_Cikis);
            this.Controls.Add(this.pnl_Fis);
            this.Controls.Add(this.picture_Cikis);
            this.Controls.Add(this.gbx_ParkTcArama);
            this.Controls.Add(this.gbx_ParkUyeBilgi);
            this.Controls.Add(this.dgw_Cars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parkot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Fis.ResumeLayout(false);
            this.pnl_Fis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cikis)).EndInit();
            this.gbx_ParkTcArama.ResumeLayout(false);
            this.gbx_ParkTcArama.PerformLayout();
            this.gbx_ParkUyeBilgi.ResumeLayout(false);
            this.gbx_ParkUyeBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelPark;
        private System.Windows.Forms.CheckBox checkbox_Verigizle;
        private System.Windows.Forms.Label lbl_Cikis;
        private System.Windows.Forms.Panel pnl_Fis;
        private System.Windows.Forms.Label lbl_bosParkSayisi;
        private System.Windows.Forms.Label lbl_Ucret;
        private System.Windows.Forms.Label lbl_Plakalar;
        private System.Windows.Forms.PictureBox picture_Cikis;
        private System.Windows.Forms.GroupBox gbx_ParkTcArama;
        private System.Windows.Forms.TextBox tbx_ParkTcNoArama;
        private System.Windows.Forms.GroupBox gbx_ParkUyeBilgi;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.MaskedTextBox tbx_ParkTelefonNo;
        private System.Windows.Forms.MaskedTextBox tbx_ParkTcNo;
        private System.Windows.Forms.Button btn_ParkAracCikis;
        private System.Windows.Forms.Button btn_ParkAracGiris;
        private System.Windows.Forms.Label lbl_TelefonNo;
        private System.Windows.Forms.TextBox tbx_ParkAd;
        private System.Windows.Forms.Label lbl_ParkPlaka;
        private System.Windows.Forms.TextBox tbx_ParkSoyad;
        private System.Windows.Forms.TextBox tbx_ParkMarka;
        private System.Windows.Forms.Label lbl_ParkMarka;
        private System.Windows.Forms.TextBox tbx_ParkPlaka;
        private System.Windows.Forms.Label lbl_ParkAd;
        private System.Windows.Forms.Label lbl_ParkTcNo;
        private System.Windows.Forms.Label lbl_ParkSoyAd;
        private System.Windows.Forms.DataGridView dgw_Cars;
        private System.Windows.Forms.Label lbl_ParkYeri;
        private System.Windows.Forms.Label lbl_ParkYeriNo;
    }
}

