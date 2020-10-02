using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Configuration.Dto;

namespace thINC.BukStore.Configuration
{
    public interface IUiCustomizationSettingsAppService : IApplicationService
    {
        Task<List<ThemeSettingsDto>> GetUiManagementSettings();

        Task UpdateUiManagementSettings(ThemeSettingsDto settings);

        Task UpdateDefaultUiManagementSettings(ThemeSettingsDto settings);

        Task UseSystemDefaultSettings();
    }
}
