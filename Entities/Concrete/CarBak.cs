using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class CarBak:IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CitizenshipNumber { get; set; }
        public string Gsm { get; set; }
        public string CarBrand { get; set; }
        public string NumberPlate { get; set; }
        public string CarPark { get; set; }
        public DateTime ParkingDate { get; set; }
    }
}
