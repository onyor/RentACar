using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RentACarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=rentACar;Uid=root;Pwd=1234");
        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Earning> earnings { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<Rent> rents { get; set; }
    }
}
