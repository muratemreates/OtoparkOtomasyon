using System;
using System.Windows.Forms;

namespace PARKOT.WindowsFormUI
{
    public partial class ParkotSettings : Form
    {
        
        public ParkotSettings()
        {
            InitializeComponent();
            GuncelUcretVeOtoparkSayisi();
        }

        void GuncelUcretVeOtoparkSayisi()
        {
            var ucret = Properties.Settings.Default.Ucret.ToString();
            var otopark = Properties.Settings.Default.Adet.ToString();

            lbl_Mevcut_Ucret.Text =$"Mevcut Ücret:  {ucret}" ;
            lbl_Mevcut_Otopark.Text = $"Mevcut Otopark:  {otopark}";
        }

        private void picture_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam veya kontrol tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbx_YeniOtopark_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Sadece rakam veya kontrol tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picture_Ucret_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_YeniUcret.Text))
            {
                var result = MessageBox.Show($"Mevcut ücret {tbx_YeniUcret.Text} olarak güncellensin mi?", "BİLGİ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.Ucret = Convert.ToInt32(tbx_YeniUcret.Text);
                    Properties.Settings.Default.Save();
                    MessageBox.Show($"Ücret güncellemesi yapıldı.Yeni ücret  {tbx_YeniUcret.Text}","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    GuncelUcretVeOtoparkSayisi();
                }
                else
                {
                    MessageBox.Show("Ücret Güncellemesi iptal edildi !","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ücret giriniz !","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void picture_Otopark_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_YeniOtopark.Text))
            {
                var result = MessageBox.Show($"Mevcut otopark sayısı {tbx_YeniOtopark.Text} adet olarak güncellensin mi?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Parkot.PanelPark.Controls.Clear();
                    OtoparkAdetKaydi();
                    Parkot.ParkButonlarim();
                    Parkot.ButonRenkYesil();
                    Parkot.ButonRenkKirmizi();

                    MessageBox.Show($"Otopark güncellemesi yapıldı.Yeni otopark sayısı {tbx_YeniOtopark.Text}", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuncelUcretVeOtoparkSayisi();
                }
                else
                {
                    MessageBox.Show("Otopark sayısı güncellemesi iptal edildi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir adet giriniz !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OtoparkAdetKaydi()
        {
            Properties.Settings.Default.Adet = Convert.ToInt32(tbx_YeniOtopark.Text);
            Properties.Settings.Default.Save();
        }
    }
}
