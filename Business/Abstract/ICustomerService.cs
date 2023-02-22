using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IDataResult<Customer> GetById(int customerId);
        IResult Add(Customer customer);
    }
}
