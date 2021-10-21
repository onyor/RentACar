using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Helpers
{
    public static class MigrationHelper
    {
        public static void MigrateRentACarContext(DbContext context)
        {
            context.Database.Migrate();
            context.SaveChanges();
        }
    }
}
