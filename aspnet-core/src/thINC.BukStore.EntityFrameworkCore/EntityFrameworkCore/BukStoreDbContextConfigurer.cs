using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace thINC.BukStore.EntityFrameworkCore
{
    public static class BukStoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BukStoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BukStoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}