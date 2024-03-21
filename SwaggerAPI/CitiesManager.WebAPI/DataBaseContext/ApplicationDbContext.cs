using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DataBaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("6C2C7D04-EE16-4FB5-BE3B-6BB1F0F7B913"),
                CityName = "New York"
            });

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("B6017E6A-CBED-4FAB-BDA7-428BA7629952"),
                CityName = "Australia"
            });
        }


    }
}
