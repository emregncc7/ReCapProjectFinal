using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public Car GetAllByBrandId(int id)
        {
             return _CarDal.Get(b => b.BrandId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);

        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        }
    }
}
