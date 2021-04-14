using Core.DataResult.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDatabaseContext>, IRentalDal
    {
        public List<RentalDto> GetRentals()
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             select new RentalDto
                             {
                                 Id = r.Id,
                                 CarId=c.CarId,
                                 BrandName = b.BrandName,
                                 Model = c.Model,
                                 ColorName = co.ColorName,
                                 CompanyName = cu.CompanyName,
                                 Username = $"{u.FirstName} {u.LastName}",
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
