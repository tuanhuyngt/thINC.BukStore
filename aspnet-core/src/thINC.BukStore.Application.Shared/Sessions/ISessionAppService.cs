using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Sessions.Dto;

namespace thINC.BukStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
