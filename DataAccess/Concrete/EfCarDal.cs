using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCarDal:EfEntitiyRespositoryBase<Car,PARKOTContext>,ICarDal
    {
        readonly PARKOTContext context = new PARKOTContext();
        public List<Car> GetByCitizenNoSearch(string key)
        {
            using (context)
            {
                return  context.Cars.Where(p=> p.CitizenshipNumber.Contains(key)).ToList();
            }
        }
    }
}
