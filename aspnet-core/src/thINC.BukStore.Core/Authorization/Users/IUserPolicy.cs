using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace thINC.BukStore.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
