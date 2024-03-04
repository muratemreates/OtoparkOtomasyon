using Bussiness.Abstract;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using Bussiness.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace PARKOT.WindowsFormUI
{
    public partial class Parkot : Form
    {
        private readonly ICarService _carService;
        //private readonly IMemberService _memberService;
        private readonly ICarBakService _carBakService;

        public Parkot()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetIstance<ICarService>();
            // _memberService = InstanceFactory.GetIstance<IMemberService>();
            _carBakService = InstanceFactory.GetIstance<ICarBakService>();
            ParkButonlarim();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            dgw_Cars.DataSource = _carService.GetAll();
        }
        private void dgw_Cars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OtomatikHucreDoldur();
        }

        void ParkButonlarim()
        {
            int left = 0;
            int top = 0;
            int sayac = 0;
            // var adet = Properties.Settings.Default.Adet;
            for (int i = 1; i <= 20; i++)
            {
                var buton = new Button();
                buton.Width = 50;//Properties.Settings.Default.ButonGenislik;
                buton.Height = 50; // Properties.Settings.Default.ButonYukseklik;

                buton.Left = left;
                buton.Top = top;
                left += 50;//Properties.Settings.Default.ButonSol;

                // buton.BackColor = Properties.Settings.Default.Yesil;
                buton.Text = i.ToString();
                buton.Tag = i.ToString();
                buton.Click += ClickOlayim;
                PanelPark.Controls.Add(buton); // panele ekleme yapıldı
                sayac++;

                if (sayac == 4)
                {
                    left = 0;
                    top += 50; //Properties.Settings.Default.ButonYukari;
                    sayac = 0;
                }
            }

        }

      

        private void btn_ParkAracGiris_Click(object sender, EventArgs e)
        {

            try
            {
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

                OtoParkEkleme();

                MessageBox.Show("Araç park edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TExtBoxSil();
                LoadCars();


            }
            catch (Exception exception)
            {
                if (exception == exception.InnerException)
                {
                    MessageBox.Show($"{exception.InnerException.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                MessageBox.Show($"{exception.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void OtoParkEkleme()
        {
           // var otoParkListem = Properties.Settings.Default.otoParkListem;
           
            lstbox_OtoPark.Items.Add(lbl_ParkYeriNo.Text);
            //otoParkListem.Add(lbl_ParkYeriNo.Text);
            //Properties.Settings.Default.Save();
        }

        void OtoParkSilme()
        {
           // var otoParkListem = Properties.Settings.Default.otoParkListem;
           var secilenPark = lstbox_OtoPark.SelectedItem;
           secilenPark = 
           lstbox_OtoPark.Items.Remove(dgw_Cars.);
        }

        private void btn_ParkAracCikis_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Araç otoparktan çkıakrtılsın mı ?", "ÇIKIŞ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (message == DialogResult.Yes && dgw_Cars.CurrentRow != null)
            {
                    _carService.Delete(new Car
                    {
                        Id = Convert.ToInt32(dgw_Cars.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("Araç park yerinden çıkarıldı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCars();
                    TExtBoxSil();
                    btn_ParkAracCikis.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen listedenn çıkarılacak aracı seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



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
        #endregion

        #region Metotlarım

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
                btn_ParkAracCikis.Enabled = true;
                lstbox_OtoPark.SelectedItem = dgw_Cars.CurrentRow.Cells[7].Value;
                lbl_Plakalar.Text = ($"{dgw_Cars.CurrentRow.Cells[1].Value} " +
                                     $"\t{dgw_Cars.CurrentRow.Cells[2].Value}" +
                                     $"\n{dgw_Cars.CurrentRow.Cells[6].Value}");

                // lbl_Ucret.Text = ($"\nÜCRET: {ÜcretHesapla().ToString("F2")}  ₺ ");
            }
            else
            {
              
            }
   
        }

        #endregion

        private void tbx_ParkTcNo_Click(object sender, EventArgs e)
        {
            tbx_ParkTcNo.SelectionStart = 0;

        }

        private void tbx_ParkTelefonNo_Click(object sender, EventArgs e)
        {
            tbx_ParkTelefonNo.SelectionStart = 6;

        }
    }
}
