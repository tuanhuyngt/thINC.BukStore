using Abp.Application.Services;
using thINC.BukStore.Dto;
using thINC.BukStore.Logging.Dto;

namespace thINC.BukStore.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
