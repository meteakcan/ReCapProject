using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int ColorId);
        IDataResult<Color> GetByName(string ColorName);
        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);
    }
}
