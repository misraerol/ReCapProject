using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        
        Car GetById(int carId);
        List<Car> GetAll();
        List<Car> GetCarByColorId(int colorId);
        List<Car> GetCarByBrandId(int brandId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
