using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAllByBrandId(int id)
        {
            return _CarDal.GetAll(c => c.BrindId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);

        }
    }
}
