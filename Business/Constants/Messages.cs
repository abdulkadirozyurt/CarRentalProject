using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // static ---> newlemeden kullanabiliriz.
    // Temel mesajlarımızı bu class'a koyduk

    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi Geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarDetailsListed = "Araç detayı listelendi";
        public static string CarDetailsNotListed = "Araç detayı listelenmedi";
    }
}
