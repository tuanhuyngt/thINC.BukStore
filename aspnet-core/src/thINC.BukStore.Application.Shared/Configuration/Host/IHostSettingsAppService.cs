using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Configuration.Host.Dto;

namespace thINC.BukStore.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
