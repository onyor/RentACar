using Entities.Concrete.Identity;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Reflection;

namespace DataAccess.Concrete
{
    public class RentACarDBContext : DbContext
    {
        public RentACarDBContext(DbContextOptions<RentACarDBContext> options)
          : base(options)
        { }

        string _connectionString;

        public RentACarDBContext(string connectionString) => _connectionString = connectionString;

        public RentACarDBContext()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseSqlServer(_connectionString);
            if (InsideLINQPad) optionsBuilder.EnableSensitiveDataLogging(true);
        }
        internal bool InsideLINQPad => AppDomain.CurrentDomain.FriendlyName.StartsWith("LINQPad");

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<RentCar> RentCars { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

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
