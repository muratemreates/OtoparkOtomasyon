using System;
using System.Media;
using System.Windows.Forms;

namespace PARKOT.WindowsFormUI
{
    public partial class UserLogin : Form
    {
        private SoundPlayer soundPlayer;

        public UserLogin()
        {
            InitializeComponent();
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
            Parkot parkot = new Parkot();
            parkot.Show();
            soundPlayer.Stop();
            this.Hide();
        }
    }
}
