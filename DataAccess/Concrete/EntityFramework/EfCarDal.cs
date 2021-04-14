using Core.DataResult.EntityFramework;
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
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {

            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId

                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId,
                                 Model = c.Model,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 Price = c.Price,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description,
                                 ImagePath = (from carImages in context.CarImages 
                                              where carImages.CarId == c.CarId 
                                              select carImages.ImagePath).ToList(),
                                 CarImage = (from img in context.CarImages
                                             where (c.CarId == img.CarId)
                                             select new CarImage { Id = img.Id, CarId = c.CarId, Date = img.Date, ImagePath = img.ImagePath }).ToList()
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}