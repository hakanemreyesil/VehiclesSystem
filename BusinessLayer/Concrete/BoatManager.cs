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
    public class BoatManager : IBoatService
    {
        IBoatDal _boatDal;

        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public List<Boat> GetBoatListWithColor(string color)
        {
            return _boatDal.GetListWithColor(color);
        }

        public List<Boat> GetList()
        {
            return _boatDal.GetListAll();
        }

        public void TAdd(Boat t)
        {
            _boatDal.Insert(t);
        }

        public void TDelete(Boat t)
        {
            _boatDal.Delete(t);
        }

        public Boat TGetById(int id)
        {
            return _boatDal.GetByID(id);
        }

        public void TUpdate(Boat t)
        {
            _boatDal.Update(t);
        }
    }
}
