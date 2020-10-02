using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Configuration.Host.Dto;
using thINC.BukStore.Editions.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}