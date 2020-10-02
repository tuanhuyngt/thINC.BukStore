using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using thINC.BukStore.EntityFrameworkCore;

namespace thINC.BukStore.HealthChecks
{
    public class BukStoreDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public BukStoreDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("BukStoreDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("BukStoreDbContext could not connect to database"));
        }
    }
}
