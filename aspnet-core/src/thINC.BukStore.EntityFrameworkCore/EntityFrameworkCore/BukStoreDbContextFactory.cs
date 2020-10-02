using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using thINC.BukStore.Configuration;
using thINC.BukStore.Web;

namespace thINC.BukStore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BukStoreDbContextFactory : IDesignTimeDbContextFactory<BukStoreDbContext>
    {
        public BukStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BukStoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            BukStoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BukStoreConsts.ConnectionStringName));

            return new BukStoreDbContext(builder.Options);
        }
    }
}