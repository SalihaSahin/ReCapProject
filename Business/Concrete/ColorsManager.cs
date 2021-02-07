using Business.Abstract;
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

        public void Add(Colors color)
        {
            _colorsDal.Add(color);
        }

        public void Delete(Colors color)
        {
            _colorsDal.Delete(color);
        }

        public List<Colors> GetAll()
        {
            return _colorsDal.GetAll();
        }

        public void Update(Colors color)
        {
            _colorsDal.Update(color);
        }
    }
}
