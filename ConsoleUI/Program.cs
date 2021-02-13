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
            //CarDetailsTest(carManager);
            //CarGetAll(carManager);
            //CarGetById(carManager);
            //CarInsert(carManager);
            //CarUpdate(carManager);
            //CarDelete(carManager);

            //ColorGetAll(colorManager);
            //ColorGetById(colorManager);
            //ColorInsert(colorManager);
            //ColorUpdate(colorManager);
            //ColorDeleted(colorManager);

            //BrandGetAll(brandManager);
            //BrandGetById(brandManager);
            //BrandInsert(brandManager);
            //BrandUpdate(brandManager);
            //BrandDeleted(brandManager);

        }

        private static void BrandDeleted(BrandManager brandManager)
        {
            brandManager.Delete(new Brand { BrandId = 11 });
        }

        private static void BrandUpdate(BrandManager brandManager)
        {
            brandManager.Update(new Brand { BrandId = 11, BrandName = "Güncellendi" });
        }

        private static void BrandInsert(BrandManager brandManager)
        {
            brandManager.Add(new Brand { BrandId = 11, BrandName = "test" });
        }

        private static void BrandGetById(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetById(1))
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorUpdate(ColorManager colorManager)
        {
            colorManager.Update(new Color { ColorId = 6, ColorName = "Güncellendi" });
        }

        private static void ColorDeleted(ColorManager colorManager)
        {
            colorManager.Delete(new Color { ColorId = 6 });
        }

        private static void ColorInsert(ColorManager colorManager)
        {
            colorManager.Add(new Color { ColorId = 6, ColorName = "Orange" });
        }

        private static void ColorGetById(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetById(2))
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarDelete(CarManager carManager)
        {
            carManager.Delete(new Car { CarId = 3 });
        }

        private static void CarUpdate(CarManager carManager)
        {
            carManager.Update(new Car { CarId = 3, BrandId = 2, Description = "Güncellendi", DailyPrice = 1000000, ColorId = 2, ModelYear = 2017 });
        }

        private static void CarInsert(CarManager carManager)
        {
            carManager.Add(new Car { CarId = 3, BrandId = 3, ColorId = 1, ModelYear = 2018, DailyPrice = 1000000, Description = "Üçüncü" });
        }

        private static void CarGetById(CarManager carManager)
        {
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarGetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarDetailsTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" +
                    car.BrandName + "/" +
                    car.ColorName + "/" +
                    car.DailyPrice + "/" +
                    car.Description);
            }
        }

    }
}
