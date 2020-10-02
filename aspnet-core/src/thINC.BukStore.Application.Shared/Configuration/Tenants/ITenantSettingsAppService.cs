using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Configuration.Tenants.Dto;

namespace thINC.BukStore.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
