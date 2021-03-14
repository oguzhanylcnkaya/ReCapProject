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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var rentals = from r in context.Rentals
                              join c in context.Cars
                              on r.CarId equals c.Id
                              join cu in context.Customers
                              on r.CustomerId equals cu.Id

                              join b in context.Brands
                              on c.BrandId equals b.Id

                              join u in context.Users
                              on cu.UserId equals u.Id
                              select new RentalDetailDto
                              {
                                  Id = r.Id,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate,
                                  BrandName = b.Name,
                                  FullName = $"{u.FirstName} {u.LastName}"
                              };
                return rentals.ToList();
            }
        }
    }
}
