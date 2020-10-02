using Abp.AutoMapper;
using thINC.BukStore.MultiTenancy;
using thINC.BukStore.MultiTenancy.Dto;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Common;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}