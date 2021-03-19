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
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, ReCapContext>, ICarImageDal
    {
        //public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var result = from c in context.Cars
        //                     join b in context.Brands
        //                     on c.BrandId equals b.Id
        //                     join co in context.Colors
        //                     on c.ColorId equals co.Id
        //                     select new CarDetailDto
        //                     {
        //                         Id = c.Id,
        //                         BrandName = b.Name,
        //                         ColorName = co.Name,
        //                         DailyPrice = c.DailyPrice,
        //                         Description = c.Description,
        //                         ModelYear = c.ModelYear,
        //                         BrandId = b.Id,
        //                         ColorId = co.Id,
        //                         ImagePath = (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault()
        //                     };
        //        return filter == null
        //            ? result.ToList()
        //            : result.Where(filter).ToList();
        //    }

        //}
    }
}
