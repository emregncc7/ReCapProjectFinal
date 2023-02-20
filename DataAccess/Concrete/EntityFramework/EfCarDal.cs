using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarListsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(CarListsContext context = new CarListsContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                            
                           
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = c.ColorId,
                                 ColorName = co.ColorName,
                                 CarName = c.CarName,
                                 DailyPrice = c.DailyPrice,                         
                             };
                return result.ToList();
            }
        }
    }
}
