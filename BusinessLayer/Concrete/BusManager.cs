using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }

        public List<Bus> GetBusListWithColor(string color)
        {
           return _busDal.GetListWithColor(color);
        }

        public List<Bus> GetList()
        {
            return _busDal.GetListAll();
        }

        public void TAdd(Bus t)
        {
            _busDal.Insert(t);
        }

        public void TDelete(Bus t)
        {
            _busDal.Delete(t);
        }

        public Bus TGetById(int id)
        {
            return _busDal.GetByID(id);
        }

        public void TUpdate(Bus t)
        {
            _busDal.Update(t);
        }
    }
}
