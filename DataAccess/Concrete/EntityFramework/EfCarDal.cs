using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var cars = from c in context.Cars
                           join b in context.Brands on c.BrandId equals b.Id
                           join co in context.Colors on c.ColorId equals co.Id
                           select new CarDetailDto
                           {
                                Id = c.Id,
                                BrandName = b.Name,
                                ColorName = co.Name,
                                DailyPrice = c.DailyPrice,
                                Description = c.Description,
                                ModelYear = c.ModelYear
                           };
                return cars.ToList();

            }

        }
    }
}
