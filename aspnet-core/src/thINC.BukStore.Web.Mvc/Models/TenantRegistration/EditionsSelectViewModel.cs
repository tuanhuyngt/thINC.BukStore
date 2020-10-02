using Abp.AutoMapper;
using thINC.BukStore.MultiTenancy.Dto;

namespace thINC.BukStore.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
