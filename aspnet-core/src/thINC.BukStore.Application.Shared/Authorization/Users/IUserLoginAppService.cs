using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using thINC.BukStore.Authorization.Users.Dto;

namespace thINC.BukStore.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
