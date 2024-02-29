using DataAccess.Concrete;
using System;
using System.Windows.Forms;

namespace PARKOT.WindowsFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly EfCarDal efCarDal  = new EfCarDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgw_Cars.DataSource = efCarDal.GetAll();
        }
    }
}
