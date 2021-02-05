using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Brand brand, Car car)
        {
            if (brand.Name.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine(brand.Name+ " adlı marka başarıyla eklendi." );
                Console.WriteLine("Günlük Fiyatı: " + car.DailyPrice);

            }
            else
            {
                Console.WriteLine("!!Araba ismi minimum 2 karakter ve günlük fiyatı 0'dan büyük olmalıdır.!!\nLüten tekrar deneyiniz.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorsId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
