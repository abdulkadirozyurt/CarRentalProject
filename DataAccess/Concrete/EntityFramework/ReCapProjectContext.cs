using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

    // context: Db tabloları ile proje class larını bağlamaya yarar.

    public class ReCapProjectContext : DbContext
    {
        // Öncelikle veritabanının yolunu belirtmeliyiz. (connection string)

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // bu metot projemizin ilişkili olduğu veritabanını belirteceğimiz yerdir.


            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = ReCapProjectDatabase; Trusted_Connection = true");

        }

        // şimdi, hangi nesnemizin, veritabanında hangi tabloyla ilişkili olduğunu göstereceğiz.


        // nesne adı  // Tablo adı
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }


    }
}
