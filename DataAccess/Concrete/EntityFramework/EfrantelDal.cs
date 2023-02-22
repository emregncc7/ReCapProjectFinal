using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfrantelDal : EfEntityRepositoryBase<Rental, CarListsContext>, IRantelDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarListsContext context = new CarListsContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join c in context.Customers
                             on r.CustomerId equals c.UserId
                             join u in context.Users
                             on r.CustomerId equals u.Id
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new RentalDetailDto { CarName  = car.CarName, FirstName = u.FirstName, LastName = u.LastName, Description = car.Description, ModelYear = car.ModelYear.ToString(), 
                                 RentDate = r.RentDate, ReturnDate = r.ReturnDate, BrandName = b.BrandName, ColorName = color.ColorName };
                return result.ToList();





               
            }
        }
    }
}
