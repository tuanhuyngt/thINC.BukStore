using Abp.Auditing;
using thINC.BukStore.Configuration.Dto;

namespace thINC.BukStore.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}