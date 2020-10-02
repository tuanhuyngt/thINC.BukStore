using Abp.AutoMapper;
using thINC.BukStore.Sessions.Dto;

namespace thINC.BukStore.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}