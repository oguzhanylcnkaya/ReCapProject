using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> ListPhotoGetByCarId(int carId);
        //IDataResult<List<CarDetailDto>> GetCarImageByCarId(int CarId);
    }
}
