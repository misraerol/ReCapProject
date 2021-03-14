using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>>GetCarByColorId(int colorId);
        IDataResult<List<Car>> GetCarByBrandId(int brandId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
