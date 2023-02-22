using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRantelDal _rantelDal;
        public RentalManager(IRantelDal rantelDal)
        {
            _rantelDal = rantelDal;
        }
        public IResult Add(Rental rental)
        {

            _rantelDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rantelDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rantelDal.Get(c => c.Id == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rantelDal.GetRentalDetails());
        }
    }
}
