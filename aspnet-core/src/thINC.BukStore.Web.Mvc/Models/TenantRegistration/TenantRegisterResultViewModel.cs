using Abp.AutoMapper;
using thINC.BukStore.MultiTenancy.Dto;

namespace thINC.BukStore.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}