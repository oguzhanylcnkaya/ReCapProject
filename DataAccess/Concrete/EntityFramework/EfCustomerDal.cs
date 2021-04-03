using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 UserId = u.Id,
                                 CustomerId = c.Id,
                                 CompanyName = c.CompanyName,
                                 Email = u.Email,
                                 FirstName = u.Email,
                                 LastName = u.LastName,
                                 Status = u.Status,
                                 FullName = $"{u.FirstName} {u.LastName}"
                             };
                return result.ToList();
            }
        }
    }
}
