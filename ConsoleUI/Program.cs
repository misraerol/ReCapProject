using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("----First Added");
            carManager.Add(new Car { BrandId = 3, DailyPrice = 300000, ColorId = 2, Description = "Bi", ModelYear = 2015 });
            Console.WriteLine("----Second Added");
            carManager.Add(new Car { BrandId = 3, DailyPrice = 0, ColorId = 2, Description = "İkinci", ModelYear = 2015 });
            Console.WriteLine("----Third Added");
            carManager.Add(new Car { CarId = 1, BrandId = 3, DailyPrice = 3000, ColorId = 2, Description = "Birinci", ModelYear = 2015 });



        }
    }
}
