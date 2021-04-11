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
            //CarTest();

            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");
            //ColorTest();
            Console.WriteLine("*************************************");
            Console.WriteLine("*************************************");

            // BrandTest();


            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { CustomerId=2,UserId=3,CompanyName="ÖzŞahin İnşaat" });

         
        }

        private static void CarTest()
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
        }

        private static void ColorTest()
        {
            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());

            colorsManager.Delete(new Colors { Id = 1 });
            colorsManager.Add(new Colors { Id = 1, Name = "Eflatun" });
            colorsManager.Update(new Colors { Id = 2, Name = "Mor" });

            Console.WriteLine("RENK SEÇENEKLERİ:");
            foreach (var color in colorsManager.GetAll().Data)
            {

                Console.WriteLine(color.Name);

            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Delete(new Brand { BrandId = 5 });
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Jeep" });
            brandManager.Update(new Brand { BrandId = 4, BrandName = "Nissan" });

            Console.WriteLine("MARKALAR:");
            foreach (var brand in brandManager.GetAll().Data)
            {

                Console.WriteLine(brand.BrandName);

            }
        }
    }
}
