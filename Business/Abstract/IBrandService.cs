using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Brand> GetById(int brandId);
        IResult Add(Brand brand);
    }
}
