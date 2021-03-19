using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
        //List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
    }
}
