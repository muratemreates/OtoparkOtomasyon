using System;
using System.Windows.Forms;
using Bussiness.Abstract;
using Bussiness.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace PARKOT.WindowsFormUI
{
    public partial class SignIn : Form
    {
        IMemberService _memberService;
        public SignIn()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetIstance<IMemberService>();
        }

        private void pctr_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctr_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
        }


        #region Metotlarim

        private void pctr_Cikis_MouseEnter(object sender, EventArgs e)
        {
            lbl_Cikis.Visible = true;
        }

        private void pctr_Cikis_MouseLeave(object sender, EventArgs e)
        {
            lbl_Cikis.Visible = false;

        }

        private void pctr_Geri_MouseEnter(object sender, EventArgs e)
        {
            lbl_Geri.Visible = true;
        }

        private void pctr_Geri_MouseLeave(object sender, EventArgs e)
        {
            lbl_Geri.Visible = false;

        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            KayitEkleme();
        }

        private void KayitEkleme()
        {
            if (!_memberService.GetUserName(txb_Kullanici.Text))
            {
                if (txb_Sifre.Text == txb_SifreTekrar.Text)
                {
                    KayitZamanlayici.Start();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler birbiriyle uyuşmamaktadır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı daha önce alınmıştır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitZamanlayici_Tick(object sender, EventArgs e)
        {
            yuklemeBari.Visible = true;
            yuklemeBari.Value += 10;

            if (yuklemeBari.Value == 100)
            {
                KayitZamanlayici.Stop();

                try
                {
                    _memberService.Add(new Member
                    {
                        Name = txb_Ad.Text,
                        Surname = txb_Soyad.Text,
                        UserName = txb_Kullanici.Text,
                        Password = txb_Sifre.Text,
                        Email = txb_Email.Text,
                        Gsm = mtxb_Gsm.Text,
                        MerbershipDate = DateTime.Now

                    });
                    MessageBox.Show("Kayıt Oluşturuldu..", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    yuklemeBari.Value = 0;

                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    yuklemeBari.Value = 0;
                }

            }
        }

        private void pctr_Goster_MouseEnter(object sender, EventArgs e)
        {
            txb_Sifre.UseSystemPasswordChar = false;
            txb_SifreTekrar.UseSystemPasswordChar = false;
        }

        private void pctr_Goster_MouseLeave(object sender, EventArgs e)
        {
            txb_Sifre.UseSystemPasswordChar = true;
            txb_SifreTekrar.UseSystemPasswordChar = true;
        }

        //private bool TextBoxKontrolcusu()
        //{
        //    return !String.IsNullOrEmpty(txb_Ad.Text) &&
        //           !String.IsNullOrEmpty(txb_Soyad.Text) &&
        //           !String.IsNullOrEmpty(txb_Kullanici.Text) &&
        //           !String.IsNullOrEmpty(txb_Sifre.Text) &&
        //           !String.IsNullOrEmpty(txb_SifreTekrar.Text) &&
        //           !String.IsNullOrEmpty(txb_Email.Text) &&
        //           mtxb_Gsm.MaskFull;
        //}

        private void mtxb_Gsm_Click(object sender, EventArgs e)
        {
            mtxb_Gsm.SelectionStart = 2;
        }
        #endregion


    }
}
