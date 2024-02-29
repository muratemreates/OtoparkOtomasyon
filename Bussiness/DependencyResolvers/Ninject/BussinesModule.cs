using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Ninject.Modules;

namespace Bussiness.DependencyResolvers.Ninject
{
    public class BussinesModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<CarManager>().InSingletonScope();
            Bind<ICarDal>().To<EfCarDal>().InSingletonScope();

            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberdal>().To<EfMemberDal>().InSingletonScope();
        }
    }
}
