using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public string CompanyName { get; set; }
    }
}
