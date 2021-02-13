using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2)
            {
                if (car.DailyPrice > 0)
                {
                    Console.WriteLine("Kayıt başarılı");
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
                }
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carId)
        {

            return _carDal.GetAll(s => s.CarId == carId);

        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            return _carDal.GetAll(s => s.BrandId == brandId);
        }

        public List<Car> GetCarByColorId(int colorId)
        {
            return _carDal.GetAll(s => s.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
