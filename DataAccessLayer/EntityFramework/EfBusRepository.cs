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
    public class EfBusRepository : GenericRepository<Bus>, IBusDal
    {
        public List<Bus> GetListWithColor(string color)
        {
                using (var c = new Context())
                {
                    return c.Buses.Where(x => x.Color == color).ToList();
                }
            }
        }
    }

