using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Rent(int carId)
        {
            var result = _rentalDal.GetAll(r => r.CarId == carId && r.ReturnDate == null);
            if (result.Count() > 0)
            {
                return new ErrorResult();
            }
            else
            {
                return new SuccessResult();
            }
                       
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            //var context = new ValidationContext<Rental>(rental);
            //RentalValidator rentalValidator = new RentalValidator();

            var result = Rent(rental.CarId);
            if (result.Success)
            {
                //var result2 = rentalValidator.Validate(context);

                //if (!result2.IsValid)
                //{
                //    throw new ValidationException(result2.Errors);
                //}

                //ValidationTool.Validate(rental, new RentalValidator());

                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }

            return new ErrorResult(Messages.RentalErrorRent);
            
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetById(r => r.Id == id), Messages.RentalGet);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalGetAll);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public bool IsCarAvailable(int carId)
        {
            var result = _rentalDal.GetAll(c => c.CarId == carId && c.ReturnDate == null);

            if(result.Count > 0)
            {
                return false;
            }
            return true;
        }

        public IDataResult<List<Rental>> GetRentalByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        
    }
}
