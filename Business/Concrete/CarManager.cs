﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
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

        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        [SecuredOperation("car.delete,admin")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        [SecuredOperation("car.list,admin")]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<Car> GetById(int carId)
        {

            return new SuccessDataResult<Car>(_carDal.Get(s => s.CarId == carId));

        }

        public IDataResult<List<Car>> GetCarByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(s => s.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(s => s.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
