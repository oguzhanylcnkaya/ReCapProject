using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    Description = "Birinci Araba",
                    DailyPrice = 50000,
                    ModelYear = "30/07/2020"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 1,
                    ColorId = 1,
                    Description = "ikinci Araba",
                    DailyPrice = 70000,
                    ModelYear = "30/07/2020"
                },
                new Car
                {
                    Id = 3,
                    BrandId = 1,
                    ColorId = 1,
                    Description = "Üçüncü Araba",
                    DailyPrice = 100000,
                    ModelYear = "30/07/2020"
                },
                new Car
                {
                    Id = 4,
                    BrandId = 1,
                    ColorId = 1,
                    Description = "Dördüncü Araba",
                    DailyPrice = 35350,
                    ModelYear = "30/07/2020"
                },
                new Car
                {
                    Id = 5,
                    BrandId = 1,
                    ColorId = 1,
                    Description = "Beşinci Araba",
                    DailyPrice = 60000,
                    ModelYear = "30/07/2020"
                }
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var deleteCar = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars.ToList();
        }
        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            var updateCar = _cars.SingleOrDefault(c => c.Id == entity.Id);

            updateCar.DailyPrice = entity.DailyPrice;
            updateCar.Description = entity.Description;
            updateCar.ModelYear = entity.ModelYear;
        }
    }
}
