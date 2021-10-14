using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Configurations
{
    public class RentConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Carasdasd");
            builder.HasKey(x => x.Id);

            //builder.Property(x => x.Brand).IsRequired();
            //builder.Property(x => x.Color).IsRequired();
        }
    }
}
