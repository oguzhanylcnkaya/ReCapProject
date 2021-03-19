using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                           join b in context.Brands
                           on c.BrandId equals b.Id
                           join co in context.Colors
                           on c.ColorId equals co.Id
                           select new CarDetailDto
                           {
                               Id = c.Id,
                               BrandName = b.Name,
                               ColorName = co.Name,
                               DailyPrice = c.DailyPrice,
                               Description = c.Description,
                               ModelYear = c.ModelYear,
                               BrandId = b.Id,
                               ColorId = co.Id,
                               ImagePath = context.CarImages.Where(x => x.CarId == c.Id).FirstOrDefault().ImagePath
                           };
                return result.ToList();
            }

        }
    }
}
