using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Install.Dto;

namespace thINC.BukStore.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}