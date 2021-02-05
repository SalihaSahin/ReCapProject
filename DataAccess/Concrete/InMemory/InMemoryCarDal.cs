using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId =1 , ColorId = 1, ModelYear = 2020, DailyPrice =1230000, Description ="Audi A3"},
                new Car { Id = 2, BrandId =1 , ColorId = 2, ModelYear = 2017, DailyPrice =138000, Description ="Ford Focus"},
                new Car { Id = 3, BrandId =2 , ColorId = 4, ModelYear = 2019, DailyPrice =126000, Description ="Toyota Corolla"},
                new Car { Id = 4, BrandId =3 , ColorId = 4, ModelYear = 2018, DailyPrice =184000, Description ="Renault Clio"},
                new Car { Id = 5, BrandId =4 , ColorId = 5, ModelYear = 2015, DailyPrice =123000, Description ="Volvo S90"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
