using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

           


            Car car1 = new Car
            {
                BrandId = 1,
                CarName = "Ferrari",
                ColorId = 8,
                ModelYear = 2012,
                DailyPrice=350,
                Description="F12 berlinetta"
                
            };

            carManager.Add(car1);



            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: " + car.CarName);
                Console.WriteLine("Car BrandId: " + car.BrandId);
                Console.WriteLine("Car Color Id: " + car.ColorId);
                Console.WriteLine("Car Daily Price: " + car.DailyPrice);
                Console.WriteLine("Car Description: " + car.Description);

                Console.WriteLine("************************************");
            }



            CarManager carManager2 = new CarManager(new InMemoryCarDal());

            

        }
    }
}
