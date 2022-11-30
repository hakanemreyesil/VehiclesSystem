using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCarRepository : GenericRepository<Car>, ICarDal
    {
        public List<Car> GetListWithColor(string color)
        {
            using (var c = new Context())
            {
                return c.Cars.Where(x => x.Color==color).ToList();
            }
        }
    }
}
