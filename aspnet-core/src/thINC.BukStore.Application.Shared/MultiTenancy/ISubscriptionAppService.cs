using System.Threading.Tasks;
using Abp.Application.Services;

namespace thINC.BukStore.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
