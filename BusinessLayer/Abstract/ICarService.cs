﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> GetCarListWithColor(string color);
    }
}
