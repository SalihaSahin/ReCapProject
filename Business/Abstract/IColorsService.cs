using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorsService
    {
        List<Colors> GetAll();
        void Add(Colors color);
        void Delete(Colors color);
        void Update(Colors color);
    }
}
