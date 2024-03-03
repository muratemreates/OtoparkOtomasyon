using System.Collections.Generic;
using Bussiness.Abstract;
using Bussiness.Utilities;
using Bussiness.Validationrules.Fulentvalidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        private readonly ICarDal _carDal;
        public void Add(Car car)
        {
            ValidationTool.Validate(new CarValidator(),car);
           _carDal.Add(car);
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByCar(string key)
        {
            return _carDal.GetByCitizenNoSearch(key);
        }
    }
}
