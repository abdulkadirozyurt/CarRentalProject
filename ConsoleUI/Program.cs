using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test1();

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç Adı: " + car.CarName);
                    Console.WriteLine("Marka: " + car.BrandName);
                    Console.WriteLine("Renk: " + car.ColorName);
                    Console.WriteLine("Günlük Fiyat: " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void Test1()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car
            {
                Id = 1,
                BrandId = 1,
                CarName = "Ferrari",
                ColorId = 8,
                ModelYear = 2012,
                DailyPrice = 350,
                Description = "F12 berlinetta",
            };

            carManager.Add(car1);

            Car car2 = new Car
            {
                Id = 2,
                BrandId = 2,
                CarName = "Renault",
                ColorId = 3,
                ModelYear = 1994,
                DailyPrice = 50,
                Description = "12 Toros",
            };

            carManager.Add(car2);

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("Car Name: " + car.CarName);
                Console.WriteLine("Car BrandId: " + car.BrandId);
                Console.WriteLine("Car Color Id: " + car.ColorId);
                Console.WriteLine("Car Daily Price: " + car.DailyPrice);
                Console.WriteLine("Car Description: " + car.Description);

                Console.WriteLine("************************************");
            }
        }
    }
}
