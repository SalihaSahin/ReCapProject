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

            carManager.Delete(new Car { Id = 2 });
            carManager.Add(new Car { Id = 2, ColorId = 2, BrandId = 2, ModelYear = 2014, DailyPrice = 365000, Description = "Volvo" });
            carManager.Update(new Car { Id = 1, BrandId = 2, ColorId = 4, DailyPrice = 567895, ModelYear = 2000, Description = "Tofaşk" });

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + " = " + car.DailyPrice + "TL");

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("*************************************");
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.ColorName + " renkli arabanın fiyatı=>" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());

            colorsManager.Delete(new Colors { Id = 1 });
            colorsManager.Add(new Colors { Id = 1, Name = "Eflatun" });
            colorsManager.Update(new Colors { Id = 2, Name = "Mor" });

            Console.WriteLine("RENK SEÇENEKLERİ:");
            foreach (var color in colorsManager.GetAll().Data)
            {
               
                Console.WriteLine(color.Name);

            }
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Delete(new Brand { Id = 5 });
            brandManager.Add(new Brand { Id = 5, Name = "Jeep" });
            brandManager.Update(new Brand {Id = 4, Name = "Nissan" });

            Console.WriteLine("MARKALAR:");
            foreach (var brand in brandManager.GetAll().Data)
            {

                Console.WriteLine(brand.Name);

            }

        }
    }
}
