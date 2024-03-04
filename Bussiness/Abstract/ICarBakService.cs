using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface ICarBakService
    {
        List<CarBak> GetAll();
        void Add(CarBak car);

    }
}
