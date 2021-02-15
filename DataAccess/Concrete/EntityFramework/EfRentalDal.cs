using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDatails()
        {
            using (RentCarDbContext context = new RentCarDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join u in context.Users on cu.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarId = c.CarId,
                                 ColorName = clr.ColorName,
                                 CompanyName = cu.CompanyName,
                                 Description = c.Description,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentalId = r.RentalId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
