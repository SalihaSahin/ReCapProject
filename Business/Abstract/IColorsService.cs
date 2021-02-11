using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorsService
    {
        IDataResult<List<Colors>> GetAll();
        IResult Add(Colors color);
        IResult Delete(Colors color);
        IResult Update(Colors color);
    }
}
