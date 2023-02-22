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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Colors colors)
        {
            _colorDal.Add(colors);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>>(_colorDal.GetAll(), Messages.ProductListed);
        }

        public IDataResult<Colors> GetById(int colorId)
        {
            return new SuccessDataResult<Colors>(_colorDal.Get(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_colorDal.GetCarDetails());
        }
    }
}
