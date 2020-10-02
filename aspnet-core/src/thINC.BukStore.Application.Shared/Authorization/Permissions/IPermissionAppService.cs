using Abp.Application.Services;
using Abp.Application.Services.Dto;
using thINC.BukStore.Authorization.Permissions.Dto;

namespace thINC.BukStore.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
