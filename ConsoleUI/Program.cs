using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: "+car.Id);
                Console.WriteLine("Car BrandId: "+car.BrandId);
                Console.WriteLine("Car Color Id: "+car.ColorId);
                Console.WriteLine("Car Daily Price: "+car.DailyPrice);
                Console.WriteLine("Car Description: "+car.Description);

                Console.WriteLine("************************************");
            }

        }
    }
}
