using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class PARKOTContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
