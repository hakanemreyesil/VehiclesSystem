using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBoatRepository : GenericRepository<Boat>, IBoatDal
    {
        public List<Boat> GetListWithColor(string color)
        {
            using (var c = new Context())
            {
                return c.Boats.Where(x => x.Color == color).ToList();
            }
        }
    }
}
