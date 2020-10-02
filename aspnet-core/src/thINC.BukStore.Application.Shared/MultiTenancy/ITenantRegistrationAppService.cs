using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.Editions.Dto;
using thINC.BukStore.MultiTenancy.Dto;

namespace thINC.BukStore.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}