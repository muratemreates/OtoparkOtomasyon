namespace PARKOT.WindowsFormUI
{
    partial class ParkotSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkotSettings));
            this.picture_Cikis = new System.Windows.Forms.PictureBox();
            this.tbx_YeniUcret = new System.Windows.Forms.TextBox();
            this.gbx_Settings = new System.Windows.Forms.GroupBox();
            this.lbl_yeniUcret = new System.Windows.Forms.Label();
            this.picture_Ucret = new System.Windows.Forms.PictureBox();
            this.picture_Otopark = new System.Windows.Forms.PictureBox();
            this.lbl_OtoparkEkle = new System.Windows.Forms.Label();
            this.tbx_YeniOtopark = new System.Windows.Forms.TextBox();
            this.lbl_Mevcut_Ucret = new System.Windows.Forms.Label();
            this.lbl_Mevcut_Otopark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cikis)).BeginInit();
            this.gbx_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ucret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Otopark)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Cikis
            // 
            this.picture_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.picture_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Cikis.BackgroundImage")));
            this.picture_Cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Cikis.Location = new System.Drawing.Point(334, 22);
            this.picture_Cikis.Name = "picture_Cikis";
            this.picture_Cikis.Size = new System.Drawing.Size(44, 41);
            this.picture_Cikis.TabIndex = 32;
            this.picture_Cikis.TabStop = false;
            this.picture_Cikis.Click += new System.EventHandler(this.picture_Cikis_Click);
            // 
            // tbx_YeniUcret
            // 
            this.tbx_YeniUcret.Location = new System.Drawing.Point(123, 109);
            this.tbx_YeniUcret.Name = "tbx_YeniUcret";
            this.tbx_YeniUcret.Size = new System.Drawing.Size(60, 23);
            this.tbx_YeniUcret.TabIndex = 33;
            this.tbx_YeniUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // gbx_Settings
            // 
            this.gbx_Settings.Controls.Add(this.lbl_Mevcut_Otopark);
            this.gbx_Settings.Controls.Add(this.lbl_Mevcut_Ucret);
            this.gbx_Settings.Controls.Add(this.picture_Otopark);
            this.gbx_Settings.Controls.Add(this.lbl_OtoparkEkle);
            this.gbx_Settings.Controls.Add(this.tbx_YeniOtopark);
            this.gbx_Settings.Controls.Add(this.picture_Ucret);
            this.gbx_Settings.Controls.Add(this.lbl_yeniUcret);
            this.gbx_Settings.Controls.Add(this.picture_Cikis);
            this.gbx_Settings.Controls.Add(this.tbx_YeniUcret);
            this.gbx_Settings.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbx_Settings.ForeColor = System.Drawing.Color.Gold;
            this.gbx_Settings.Location = new System.Drawing.Point(12, 12);
            this.gbx_Settings.Name = "gbx_Settings";
            this.gbx_Settings.Size = new System.Drawing.Size(395, 309);
            this.gbx_Settings.TabIndex = 34;
            this.gbx_Settings.TabStop = false;
            this.gbx_Settings.Text = "Ayarlar";
            // 
            // lbl_yeniUcret
            // 
            this.lbl_yeniUcret.AutoSize = true;
            this.lbl_yeniUcret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yeniUcret.Location = new System.Drawing.Point(35, 109);
            this.lbl_yeniUcret.Name = "lbl_yeniUcret";
            this.lbl_yeniUcret.Size = new System.Drawing.Size(65, 17);
            this.lbl_yeniUcret.TabIndex = 34;
            this.lbl_yeniUcret.Text = "Yeni Ücret:";
            // 
            // picture_Ucret
            // 
            this.picture_Ucret.BackColor = System.Drawing.Color.Transparent;
            this.picture_Ucret.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Ucret.BackgroundImage")));
            this.picture_Ucret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Ucret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_Ucret.Location = new System.Drawing.Point(198, 109);
            this.picture_Ucret.Name = "picture_Ucret";
            this.picture_Ucret.Size = new System.Drawing.Size(28, 24);
            this.picture_Ucret.TabIndex = 35;
            this.picture_Ucret.TabStop = false;
            this.picture_Ucret.Click += new System.EventHandler(this.picture_Ucret_Click);
            // 
            // picture_Otopark
            // 
            this.picture_Otopark.BackColor = System.Drawing.Color.Transparent;
            this.picture_Otopark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_Otopark.BackgroundImage")));
            this.picture_Otopark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_Otopark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picture_Otopark.Location = new System.Drawing.Point(198, 162);
            this.picture_Otopark.Name = "picture_Otopark";
            this.picture_Otopark.Size = new System.Drawing.Size(28, 24);
            this.picture_Otopark.TabIndex = 38;
            this.picture_Otopark.TabStop = false;
            this.picture_Otopark.Click += new System.EventHandler(this.picture_Otopark_Click);
            // 
            // lbl_OtoparkEkle
            // 
            this.lbl_OtoparkEkle.AutoSize = true;
            this.lbl_OtoparkEkle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OtoparkEkle.Location = new System.Drawing.Point(22, 162);
            this.lbl_OtoparkEkle.Name = "lbl_OtoparkEkle";
            this.lbl_OtoparkEkle.Size = new System.Drawing.Size(78, 17);
            this.lbl_OtoparkEkle.TabIndex = 37;
            this.lbl_OtoparkEkle.Text = "Otopark Ekle:";
            // 
            // tbx_YeniOtopark
            // 
            this.tbx_YeniOtopark.Location = new System.Drawing.Point(123, 162);
            this.tbx_YeniOtopark.Name = "tbx_YeniOtopark";
            this.tbx_YeniOtopark.Size = new System.Drawing.Size(60, 23);
            this.tbx_YeniOtopark.TabIndex = 36;
            this.tbx_YeniOtopark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_YeniOtopark_KeyPress);
            // 
            // lbl_Mevcut_Ucret
            // 
            this.lbl_Mevcut_Ucret.AutoSize = true;
            this.lbl_Mevcut_Ucret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mevcut_Ucret.Location = new System.Drawing.Point(260, 112);
            this.lbl_Mevcut_Ucret.Name = "lbl_Mevcut_Ucret";
            this.lbl_Mevcut_Ucret.Size = new System.Drawing.Size(80, 17);
            this.lbl_Mevcut_Ucret.TabIndex = 39;
            this.lbl_Mevcut_Ucret.Text = "Mevcut Ücret:";
            // 
            // lbl_Mevcut_Otopark
            // 
            this.lbl_Mevcut_Otopark.AutoSize = true;
            this.lbl_Mevcut_Otopark.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mevcut_Otopark.Location = new System.Drawing.Point(246, 165);
            this.lbl_Mevcut_Otopark.Name = "lbl_Mevcut_Otopark";
            this.lbl_Mevcut_Otopark.Size = new System.Drawing.Size(94, 17);
            this.lbl_Mevcut_Otopark.TabIndex = 40;
            this.lbl_Mevcut_Otopark.Text = "Mevcut Otopark:";
            // 
            // ParkotSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 344);
            this.Controls.Add(this.gbx_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParkotSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Cikis)).EndInit();
            this.gbx_Settings.ResumeLayout(false);
            this.gbx_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Ucret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Otopark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_Cikis;
        private System.Windows.Forms.TextBox tbx_YeniUcret;
        private System.Windows.Forms.GroupBox gbx_Settings;
        private System.Windows.Forms.Label lbl_yeniUcret;
        private System.Windows.Forms.PictureBox picture_Ucret;
        private System.Windows.Forms.PictureBox picture_Otopark;
        private System.Windows.Forms.Label lbl_OtoparkEkle;
        private System.Windows.Forms.TextBox tbx_YeniOtopark;
        private System.Windows.Forms.Label lbl_Mevcut_Otopark;
        private System.Windows.Forms.Label lbl_Mevcut_Ucret;
    }
}