using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VueCore.EntityFrameworkCore
{
    public static class VueCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VueCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VueCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
