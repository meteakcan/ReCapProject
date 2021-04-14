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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int CarId);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetByPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetByColor(int colorId);
        IDataResult<List<CarDetailDto>> GetByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
