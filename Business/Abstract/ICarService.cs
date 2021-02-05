using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorsId(int id);

        void Add(Brand brand, Car car);
    }
}
