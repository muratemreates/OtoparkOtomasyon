using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Bussiness.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetIstance<T>()
        {
            var kernel = new StandardKernel(new BussinesModule());
            return kernel.Get<T>();
        }
    }
}
