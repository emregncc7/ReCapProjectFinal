using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>>(_colorDal.GetAll());
        }

        public IDataResult<Colors> Get(int id)
        {
            return new SuccessDataResult<Colors>(_colorDal.Get(c => c.ColorId == id));
        }

        public IResult Add(Colors color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Update(Colors color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }

        public IResult Delete(Colors color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }
    }
}
