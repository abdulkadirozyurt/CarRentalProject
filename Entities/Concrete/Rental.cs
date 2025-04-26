using System;
using Core.Entities;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Rental : BaseEntity
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
