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
            dgw_Cars.DataSource = _carService.GetAll();
        }
        private void btn_ParkAracGiris_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.Add(new Car
                {
                    Name = tbx_ParkAd.Text,
                    Surname = tbx_ParkSoyad.Text,
                    CitizenshipNumber = tbx_ParkTcNo.Text,
                    Gsm = tbx_ParkTelefonNo.Text,
                    CarBrand = tbx_ParkMarka.Text,
                    NumberPlate = tbx_ParkPlaka.Text,
                    CarPark = cb_OtoParkYeri.SelectedItem.ToString(),
                    ParkingDate = DateTime.Now,
                });

            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
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


        #endregion

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            TExtBoxSil();
        }

        
    }
}
