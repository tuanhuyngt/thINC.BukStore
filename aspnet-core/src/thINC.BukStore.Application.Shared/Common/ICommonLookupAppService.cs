using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using thINC.BukStore.Common.Dto;
using thINC.BukStore.Editions.Dto;

namespace thINC.BukStore.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}