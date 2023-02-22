using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CarName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
