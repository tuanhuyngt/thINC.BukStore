using System.Collections.Generic;
using Abp.Localization;
using thINC.BukStore.Install.Dto;

namespace thINC.BukStore.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
