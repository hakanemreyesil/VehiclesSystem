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
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetList()
        {
            return _carDal.GetListAll();
        }

        public List<Car> GetCarListWithColor(string color)
        {
            return _carDal.GetListWithColor(color);
        }

        public void TAdd(Car t)
        {
            _carDal.Insert(t);
        }

        public void TDelete(Car t)
        {
            _carDal.Delete(t);
        }

        public Car TGetById(int id)
        {
            return _carDal.GetByID(id);
        }

        public void TUpdate(Car t)
        {
            _carDal.Update(t);
        }


    }
}
