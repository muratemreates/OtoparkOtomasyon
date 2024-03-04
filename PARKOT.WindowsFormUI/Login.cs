using Bussiness.Abstract;
using System;
using System.Windows.Forms;
using Bussiness.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace PARKOT.WindowsFormUI
{
    public partial class Parkot : Form
    {
        private readonly ICarService _carService;
        private readonly IMemberService _memberService;
        private readonly ICarBakService _carBakService;
        public Parkot()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetIstance<ICarService>();
            _memberService = InstanceFactory.GetIstance<IMemberService>();
            _carBakService = InstanceFactory.GetIstance<ICarBakService>();
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
        private void btn_ParkAracGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_OtoParkYeri.SelectedIndex != -1 && cb_OtoParkYeri.Items.Count > 0)
                {
                    _carService.Add(new Car
                    {
                        Name = tbx_ParkAd.Text.ToUpper(),
                        Surname = tbx_ParkSoyad.Text.ToUpper(),
                        CitizenshipNumber = tbx_ParkTcNo.Text,
                        Gsm = tbx_ParkTelefonNo.Text,
                        CarBrand = tbx_ParkMarka.Text.ToUpper(),
                        NumberPlate = tbx_ParkPlaka.Text.ToUpper(),
                        CarPark = cb_OtoParkYeri.SelectedItem.ToString(),
                        ParkingDate = DateTime.Now,
                    });

                    _carBakService.Add(new CarBak
                    {
                        Name = tbx_ParkAd.Text.ToUpper(),
                        Surname = tbx_ParkSoyad.Text.ToUpper(),
                        CitizenshipNumber = tbx_ParkTcNo.Text,
                        Gsm = tbx_ParkTelefonNo.Text,
                        CarBrand = tbx_ParkMarka.Text.ToUpper(),
                        NumberPlate = tbx_ParkPlaka.Text.ToUpper(),
                        CarPark = cb_OtoParkYeri.SelectedItem.ToString(),
                        ParkingDate = DateTime.Now,
                    });

                    MessageBox.Show("Araç park edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TExtBoxSil();
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("Lütfen Otopark Yeri Seçiniz","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
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

            if (message == DialogResult.Yes)
            {
                if (dgw_Cars.CurrentRow != null)
                {
                    _carService.Delete(new Car
                    {
                        Id = Convert.ToInt32(dgw_Cars.CurrentRow.Cells[0].Value),
                    });
                    MessageBox.Show("Araç park yerinden çıkarılfı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadCars();
                    TExtBoxSil();

                }
               
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
        void TExtBoxSil()
        {
            tbx_ParkAd.Text = "";
            tbx_ParkSoyad.Text = "";
            tbx_ParkTcNo.Text = "";
            tbx_ParkTelefonNo.Text = "";
            tbx_ParkMarka.Text = "";
            tbx_ParkPlaka.Text = "";
        }


        private void OtomatikHucreDoldur()
        {
            tbx_ParkAd.Text = dgw_Cars.CurrentRow.Cells[1].Value.ToString();
            tbx_ParkSoyad.Text = dgw_Cars.CurrentRow.Cells[2].Value.ToString();
            tbx_ParkTcNo.Text = dgw_Cars.CurrentRow.Cells[3].Value.ToString();
            tbx_ParkTelefonNo.Text = dgw_Cars.CurrentRow.Cells[4].Value.ToString();
            tbx_ParkMarka.Text = dgw_Cars.CurrentRow.Cells[5].Value.ToString();
            tbx_ParkPlaka.Text = dgw_Cars.CurrentRow.Cells[6].Value.ToString();
            //btn_ParkAracCikis.Enabled = true;
            lstbox_OtoPark.SelectedItem = dgw_Cars.CurrentRow.Cells[7].Value;
            lbl_Plakalar.Text = ($"{dgw_Cars.CurrentRow.Cells[1].Value} " +
                                 $"\t{dgw_Cars.CurrentRow.Cells[2].Value}" +
                                 $"\n{dgw_Cars.CurrentRow.Cells[6].Value}");

            // lbl_Ucret.Text = ($"\nÜCRET: {ÜcretHesapla().ToString("F2")}  ₺ ");
        }


        #endregion


    }
}
