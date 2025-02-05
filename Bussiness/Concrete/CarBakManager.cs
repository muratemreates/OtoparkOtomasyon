﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Bussiness.Utilities;
using Bussiness.Validationrules.Fulentvalidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class CarBakManager : ICarBakService
    {
        private readonly ICarBakDal _carBakDal;

        public CarBakManager(ICarBakDal carBakDal)
        {
            _carBakDal = carBakDal;
        }

        public List<CarBak> GetAll()
        {
            return _carBakDal.GetAll();
        }

        public void Add(CarBak car)
        {
                _carBakDal.Add(car);
        }
    }
}
