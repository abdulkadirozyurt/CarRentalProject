using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : BaseEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
