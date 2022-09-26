using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InterceptorReproduction.EntityFrameworkCore
{
    public static class InterceptorReproductionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InterceptorReproductionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InterceptorReproductionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
