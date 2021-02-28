using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckInsertLimit(carImage.CarId));
            if(result != null)
            {
                return result;  
            }

            carImage.ImagePath = FileHelper.Add(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(c => c.CarId == id));
        }

        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            carImage.Date = DateTime.Now;
            carImage.ImagePath = FileHelper.Update(_carImageDal.GetById(c => c.CarId == carImage.CarId).ImagePath, formFile);
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> ListPhotoGetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfPicture(carId));
        }

        //BusinessCode

        private IResult CheckInsertLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if(result > 5)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }

        private List<CarImage> CheckIfPicture(int carId)
        {
            var path = @"\Images\CarsPhoto\oguzhanyalcinkaya.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();

            if (!result)
            {
                return new List<CarImage>
                {
                    new CarImage
                    {
                        CarId = carId,
                        Date = DateTime.Now,
                        ImagePath = path
                    }  
                };
            }

            return _carImageDal.GetAll(c => c.CarId == carId);
        }

        
    }
}
