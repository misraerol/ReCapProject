using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("--------------ADD--------------");
            carManager.Add(new Car {CarId=6,BrandId=3,DailyPrice=30000,ColorId=2,Description="Altıncı",ModelYear=2015 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------UPDATE--------------");
            carManager.Update(new Car { CarId = 6, BrandId = 3, DailyPrice = 300000, ColorId = 2, Description = "Altıncı Güncellendi", ModelYear = 2015 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------DELETE--------------");
            carManager.Delete(6);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------ID'ye Göre--------------");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Id= "+car.CarId+" Açıklama= "+car.Description );
            }
        }
    }
}
