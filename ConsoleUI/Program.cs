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
            carManager.Add(new Car { CarId = 1, BrandId = 3, DailyPrice = 300000, ColorId = 2, Description = "Bi", ModelYear = 2015 });
            carManager.Add(new Car { CarId = 2, BrandId = 3, DailyPrice = 0, ColorId = 2, Description = "İkinci", ModelYear = 2015 });


        }
    }
}
