using Bussiness.Abstract;
using System;
using System.Linq;
using System.Windows.Forms;
using Bussiness.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace PARKOT.WindowsFormUI
{
    public partial class Parkot : Form
    {
        private readonly ICarService _carService;
        private readonly ICarBakService _carBakService;

        public Parkot()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetIstance<ICarService>();
            _carBakService = InstanceFactory.GetIstance<ICarBakService>();
            ParkButonlarim();
            ButonRenkYesil();
            ButonRenkKirmizi();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
        }


        #region AraçParkİşlemleri

        private void btn_ParkAracGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.OtoparkListem.Add(lbl_ParkYeriNo.Text);
                Properties.Settings.Default.Save();
                ButonRenkKirmizi();

                _carService.Add(new Car()
                {
                    Name = tbx_ParkAd.Text.ToUpper(),
                    Surname = tbx_ParkSoyad.Text.ToUpper(),
                    CitizenshipNumber = tbx_ParkTcNo.Text,
                    Gsm = tbx_ParkTelefonNo.Text,
                    CarBrand = tbx_ParkMarka.Text.ToUpper(),
                    NumberPlate = tbx_ParkPlaka.Text.ToUpper(),
                    CarPark = lbl_ParkYeriNo.Text,
                    ParkingDate = DateTime.Now,
                });

                _carBakService.Add(new CarBak()
                {
                    Name = tbx_ParkAd.Text.ToUpper(),
                    Surname = tbx_ParkSoyad.Text.ToUpper(),
                    CitizenshipNumber = tbx_ParkTcNo.Text,
                    Gsm = tbx_ParkTelefonNo.Text,
                    CarBrand = tbx_ParkMarka.Text.ToUpper(),
                    NumberPlate = tbx_ParkPlaka.Text.ToUpper(),
                    CarPark = lbl_ParkYeriNo.Text,
                    ParkingDate = DateTime.Now,
                });


                MessageBox.Show("Araç park edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TExtBoxSil();
                LoadCars();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_ParkAracCikis_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Araç otoparktan çkıakrtılsın mı ?", "ÇIKIŞ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (message == DialogResult.Yes && dgw_Cars.CurrentRow != null)
            {
                try
                {
                    var otoparkim = Properties.Settings.Default.OtoparkListem;
                    string parkim = dgw_Cars.CurrentRow.Cells[7].Value.ToString();

                    if (otoparkim.Contains(parkim))
                    {
                        otoparkim.Remove(parkim);
                        Properties.Settings.Default.Save();
                        ButonRenkYesil();

                    }

                    _carService.Delete(new Car
                    {
                        Id = Convert.ToInt32(dgw_Cars.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("Araç park yerinden çıkarıldı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    TExtBoxSil();
                    btn_ParkAracCikis.Enabled = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}");
                }
            }
            else if (message == DialogResult.No)
            {
                MessageBox.Show("Çıkış işlemi iptal edildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen listedenn çıkarılacak aracı seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region Çıkış Butonu işemleri

        private void picture_Cikis_Click(object sender, EventArgs e)
        {
            var secim = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz..?", "ÇIKIŞ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                Application.Exit(); // Uyulamadan çık
                Properties.Settings.Default.Save(); // Ayarları kaydet 

            }
            else
            {

            }
        }
        private void picture_Cikis_MouseEnter(object sender, EventArgs e)
        {
            lbl_Cikis.Visible = true;
        }

        private void picture_Cikis_MouseLeave(object sender, EventArgs e)
        {
            lbl_Cikis.Visible = false;
        }

        #endregion

        #region Diğer küçük işlemler



        private void checkbox_Verigizle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Verigizle.Checked)
            {

                dgw_Cars.Visible = false;
            }
            else
            {
                dgw_Cars.Visible = true;
            }
        }


        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            TExtBoxSil();
        }

        private void tbx_ParkTcNo_Click(object sender, EventArgs e)
        {
            tbx_ParkTcNo.SelectionStart = 0;

        }

        private void tbx_ParkTelefonNo_Click(object sender, EventArgs e)
        {
            tbx_ParkTelefonNo.SelectionStart = 6;

        }
        #endregion

        #region Metotlarım

        void ParkButonlarim()
        {
            int left = 0;
            int top = 0;
            int sayac = 0;
            var adet = Properties.Settings.Default.Adet;
            for (int i = 1; i <= adet; i++)
            {
                var buton = new Button();
                buton.Width = Properties.Settings.Default.ButonGenislik;
                buton.Height = Properties.Settings.Default.ButonYukseklik;

                buton.Left = left;
                buton.Top = top;
                left += Properties.Settings.Default.ButonGenislik;

                buton.BackColor = Properties.Settings.Default.Yesil;
                buton.Text = i.ToString();
                buton.Tag = i.ToString();
                buton.Click += ClickOlayim;
                PanelPark.Controls.Add(buton); // panele ekleme yapıldı
                sayac++;

                if (sayac == 7)
                {
                    left = 0;
                    top += Properties.Settings.Default.ButonYukseklik;
                    sayac = 0;
                }
            }

        }
        private void dgw_Cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OtomatikHucreDoldur();
        }
        private void LoadCars()
        {
            dgw_Cars.DataSource = _carService.GetAll();
        }
        void ButonRenkKirmizi()
        {
            var kirmizi = Properties.Settings.Default.Kirmizi;

            foreach (var item in Properties.Settings.Default.OtoparkListem)
            {
                foreach (Button button in PanelPark.Controls.OfType<Button>())
                {
                    if (item == button.Text)
                    {
                        button.BackColor = kirmizi;
                        Properties.Settings.Default.Save();
                        button.Enabled = false;
                        break;
                    }
                }
            }
        }

        void ButonRenkYesil()
        {
            var yesil = Properties.Settings.Default.Yesil;
            var kirmizi = Properties.Settings.Default.Kirmizi;

            foreach (Button button in PanelPark.Controls.OfType<Button>())
            {
                if (button.BackColor == kirmizi)
                {
                    button.BackColor = yesil;
                    Properties.Settings.Default.Save();
                    button.Enabled = true;
                    break;
                }
            }
        }

        private void ClickOlayim(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            lbl_ParkYeriNo.Text = clickedButton.Text;
        }

        void TExtBoxSil()
        {
            tbx_ParkAd.Text = "";
            tbx_ParkSoyad.Text = "";
            tbx_ParkTcNo.Text = "";
            tbx_ParkTelefonNo.Text = "";
            tbx_ParkMarka.Text = "";
            tbx_ParkPlaka.Text = "";
            lbl_Plakalar.Text = "";
            lbl_Ucret.Text = "";
            lbl_ParkYeriNo.Text = "";
            tbx_ParkTcNoArama.Text = "";
        }


        private void OtomatikHucreDoldur()
        {
            if (dgw_Cars.CurrentRow != null)
            {
                tbx_ParkAd.Text = dgw_Cars.CurrentRow.Cells[1].Value.ToString();
                tbx_ParkSoyad.Text = dgw_Cars.CurrentRow.Cells[2].Value.ToString();
                tbx_ParkTcNo.Text = dgw_Cars.CurrentRow.Cells[3].Value.ToString();
                tbx_ParkTelefonNo.Text = dgw_Cars.CurrentRow.Cells[4].Value.ToString();
                tbx_ParkMarka.Text = dgw_Cars.CurrentRow.Cells[5].Value.ToString();
                tbx_ParkPlaka.Text = dgw_Cars.CurrentRow.Cells[6].Value.ToString();
                lbl_ParkYeriNo.Text = dgw_Cars.CurrentRow.Cells[7].Value.ToString();
                btn_ParkAracCikis.Enabled = true;
                //lstbox_OtoPark.SelectedItem = dgw_Cars.CurrentRow.Cells[7].Value;
                lbl_Plakalar.Text = ($"{dgw_Cars.CurrentRow.Cells[1].Value} " +
                                     $"\t{dgw_Cars.CurrentRow.Cells[2].Value}" +
                                     $"\n{dgw_Cars.CurrentRow.Cells[6].Value}");

                 lbl_Ucret.Text = ($"\nÜCRET: {ÜcretHesapla().ToString("F2")}  ₺ ");
            }
            else
            {

            }

        }

        public double ÜcretHesapla()
        {
            var now = DateTime.Now;
            var ilkZaman = DateTime.Parse(dgw_Cars.CurrentRow.Cells[8].Value.ToString());

            TimeSpan zamanFarki = now - ilkZaman;

            double ucret = zamanFarki.TotalHours * 5.0;

            return ucret;
        }

        private void tbx_ParkTcNoArama_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbx_ParkTcNoArama.Text))
            {
                var result = _carService.GetByCar(tbx_ParkTcNoArama.Text);
                dgw_Cars.DataSource = result;
            }
            else
            {
                LoadCars();
            }

        }
    }
    #endregion


}
