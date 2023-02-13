using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Brand : IEntity
    {
        public int Id { get; set; }
        public int BrindId { get; set; }
        public string BrandName { get; set; }
    }
}
