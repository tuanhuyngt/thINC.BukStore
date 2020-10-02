using Microsoft.Extensions.DependencyInjection;
using thINC.BukStore.HealthChecks;

namespace thINC.BukStore.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<BukStoreDbContextHealthCheck>("Database Connection");
            builder.AddCheck<BukStoreDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
