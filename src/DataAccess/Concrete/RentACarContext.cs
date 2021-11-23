using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Concrete
{
    public class RentACarContext : DbContext
    {
        public RentACarContext(DbContextOptions<RentACarContext> options)
          : base(options)
        { }

        public RentACarContext()
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<RentCar> RentCars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RentCar>()
                .HasOne(e => e.Rent)
                .WithMany(e => e.RentCars)
                .HasForeignKey(e => e.RentId);

            builder.Entity<RentCar>()
                .HasOne(e => e.Car)
                .WithMany(e => e.RentCars)
                .HasForeignKey(e => e.CarId);


            builder.Entity<RentCar>().HasKey(x => new { x.RentId, x.CarId });

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
