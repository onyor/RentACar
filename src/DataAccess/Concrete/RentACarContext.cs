using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        //}

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


            builder.Entity<RentCar>().HasKey(x => new { x.RentId, x.CarId});

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
