using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorsManager : IColorsService
    {
        IColorsDal _colorsDal;

        public ColorsManager(IColorsDal colorsDal)
        {
            _colorsDal = colorsDal;
        }

        public IResult Add(Colors color)
        {
            _colorsDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);

        }

        public IResult Delete(Colors color)
        {
            _colorsDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Colors>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Colors>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Colors>>(_colorsDal.GetAll(), Messages.ColorListed);
        }

        public IResult Update(Colors color)
        {
            _colorsDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);

        }
    }
}
