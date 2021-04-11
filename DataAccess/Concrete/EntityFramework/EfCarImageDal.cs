using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal: EfEntityRepositoryBase<CarImage, ReCapContext>, ICarImageDal
    {
        public List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var result = from image in filter == null ? context.CarImages : context.CarImages.Where(filter)
                             join car in context.Cars
                             on image.CarId equals car.Id
                             select new CarImageDto
                             {
                                 CarId = car.Id,
                                 ImagePath = image.ImagePath,
                                 Id = image.Id
                             };
                return result.ToList();
            }
        }
    }
}
