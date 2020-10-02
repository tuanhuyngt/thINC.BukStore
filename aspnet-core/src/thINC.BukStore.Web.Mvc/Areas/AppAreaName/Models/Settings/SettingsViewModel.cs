using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Configuration.Tenants.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}