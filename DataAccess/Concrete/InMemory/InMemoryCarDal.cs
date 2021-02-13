using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1, ModelYear=2014,DailyPrice=50000,Description="Birinci"},
                new Car{CarId=2,BrandId=1,ColorId=1, ModelYear=2015,DailyPrice=150000,Description="İkinci"},
                new Car{CarId=3,BrandId=3,ColorId=1, ModelYear=2016,DailyPrice=200000,Description="Üçüncü"},
                new Car{CarId=4,BrandId=2,ColorId=2, ModelYear=2017,DailyPrice=250000,Description="Dördüncü"},
                new Car{CarId=5,BrandId=2,ColorId=3, ModelYear=2018,DailyPrice=300000,Description="Beşinci"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Delete(int carId)
        {
            Car carToDelete = _cars.SingleOrDefault(s => s.CarId == carId);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(s => s.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }


        public List<Car> GetById(int carId)
        {
            return _cars.Where(s => s.CarId == carId).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
