using System;
using System.Media;
using System.Windows.Forms;
using Bussiness.Abstract;
using Bussiness.DependencyResolvers.Ninject;
using DataAccess.Concrete;

namespace PARKOT.WindowsFormUI
{
    public partial class UserLogin : Form
    {
        private SoundPlayer soundPlayer;
        private IMemberService _memberService;

        public UserLogin()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetIstance<IMemberService>();
            soundPlayer = new SoundPlayer(@"Resources\ryder.wav");
        }


        private void UserLogin_Load(object sender, EventArgs e)
        {
            MusicPlayer();
        }

        private void MusicPlayer()
        {
            try
            {
                soundPlayer.PlayLooping();

            }
            catch (Exception e)
            {
                MessageBox.Show("Müzik çalınamıyor","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void pctr_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (TextBoxKontrolu())
            {
                if (_memberService.MemberSearch(txb_Kullanici.Text, txb_Sifre.Text))
                {
                    Parkot parkot = new Parkot();
                    parkot.Show();
                    soundPlayer.Stop();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da Şifre hatalı.Lütfen tekrar deneyiniz..!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          


        }

        #region Metotlarım

        bool TextBoxKontrolu()
        {
            return !String.IsNullOrEmpty(txb_Kullanici.Text) &&
                   !String.IsNullOrEmpty(txb_Sifre.Text);
        }

        #endregion
    }
}
