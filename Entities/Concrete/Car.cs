using Entities.Abstract;

namespace Entities.Concrete
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public short ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public short? MinFindeksScore { get; set; }
    }
}
