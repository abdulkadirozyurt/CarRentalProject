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
        public static string ColorAdded = "Color Added";
        public static string ColorDeleted = "Color Deleted";
        public static string ColorsListed = "Colors Listed";
        public static string ColorUpdated = "Color Updated";
        public static string ColorDetailsRetrieved = "Color Details Retrieved";

        public static string BrandDeleted = "Brand Deleted";
        public static string BrandAdded = "Brand Added Succesfully";
        public static string BrandsListed = "Brands Listed";

        public static string CarAdded = "Car Added";
        public static string CarNameInvalid = "Car Name Invalid";
        public static string CarDeleted = "Car Deleted";
        public static string CarsListed = "Cars Listed";
        public static string CarUpdated = "Car Updated";
        public static string CarDetailsListed = "Car Details Listed";

        public static string MaintenanceTime = "Time for Maintenance.";
    }
}
