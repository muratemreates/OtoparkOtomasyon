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
                if (_memberService.MemberSearch(txb_Kullanici.Text.Trim(), txb_Sifre.Text.Trim()))
                {
                    Giris_Zamanlayici.Start();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void Giris_Zamanlayici_Tick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.AppStarting;
            lbl_GirisOnayi.Visible = true;
            yuklenme_Bari.Value += 1;
            yuklenme_Bari.Visible = true;
            lbl_GirisOnayi.Text = $"Giriş Onaylandı..%{yuklenme_Bari.Value}";

            if (yuklenme_Bari.Value == 100)
            {
                Parkot parkot = new Parkot();
                parkot.Show();
                soundPlayer.Stop();
                Giris_Zamanlayici.Stop();
                this.Hide();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
