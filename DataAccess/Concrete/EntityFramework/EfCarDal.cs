using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var result = from c in context.Cars
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarId = c.CarId,
                                 ColorName = clr.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                             };
                return result.ToList();
            }

        }
    }
}

