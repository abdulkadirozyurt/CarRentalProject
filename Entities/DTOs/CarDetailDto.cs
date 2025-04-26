using Core.Entities;

namespace Entities.DTOs
{
    // Data Transformation Object -- Taşınacak nesneler.

    // birden fazla tablonun birkaç kolonu olabilir, veritabanı nesnesi değil (IEntity değil yani.)
    public class CarDetailDto : IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}


//      birden fazla tablonun join'i (birleşimi) olabilir.
