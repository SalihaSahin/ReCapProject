using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description+" = "+car.DailyPrice+"TL");
                
            }
            carManager.Add(new Brand { Name = "Mercedes" }, new Car { DailyPrice = 100000 });
            carManager.Add(new Brand { Name = "a" }, new Car { DailyPrice = -1 });

        }
    }
}
