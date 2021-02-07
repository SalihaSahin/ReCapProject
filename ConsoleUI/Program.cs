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

            carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 160000, Description = "Fiat Doblo", ModelYear = 2013 });
            carManager.Update(new Car { Id = 5, BrandId = 2, ColorId = 1, DailyPrice = 2500000, Description = "Range Rover", ModelYear = 2020 });
            carManager.Delete(new Car { Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 2500000, Description = "Range Rover", ModelYear = 2020 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description+" = "+car.DailyPrice+"TL");
                
            }
            Console.WriteLine("*************************************");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+" "+car.ColorName+" renkli arabanın fiyatı=>"+car.DailyPrice);
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());

            colorsManager.Add(new Colors { Name = "yeşil" });
            colorsManager.Update(new Colors { Id = 2, Name = "turuncu" });
            colorsManager.Delete(new Colors { Id = 5, Name = "yeşil" });

            Console.WriteLine("ReENK SEÇENEKLERİ:");
            foreach (var color in colorsManager.GetAll())
            {
               
                Console.WriteLine(color.Name);

            }
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { Name = "Ferrari" });
            brandManager.Update(new Brand { Id = 2, Name = "Audi" });
            brandManager.Delete(new Brand { Id = 7, Name = "Ferrari" });

            Console.WriteLine("MARKALAR:");
            foreach (var brand in brandManager.GetAll())
            {

                Console.WriteLine(brand.Name);

            }

        }
    }
}
