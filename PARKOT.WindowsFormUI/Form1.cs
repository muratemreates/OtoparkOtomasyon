using Bussiness.Abstract;
using DataAccess.Concrete;
using System;
using System.Windows.Forms;
using Bussiness.DependencyResolvers.Ninject;

namespace PARKOT.WindowsFormUI
{
    public partial class Form1 : Form
    {
        private readonly ICarService _carService;
        private readonly IMemberService _memberService;
        public Form1()
        {
            InitializeComponent();
            _carService = InstanceFactory.GetIstance<ICarService>();
            _memberService = InstanceFactory.GetIstance<IMemberService>();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            dgw_Cars.DataSource = _carService.GetAll();
        }
    }
}
