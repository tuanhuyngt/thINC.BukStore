using System.ComponentModel.DataAnnotations;
using Abp.Localization;

namespace thINC.BukStore.Web.Models.Account
{
    public class VerifySecurityCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [AbpDisplayName(BukStoreConsts.LocalizationSourceName, "Code")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [AbpDisplayName(BukStoreConsts.LocalizationSourceName, "RememberThisBrowser")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }

        public bool IsRememberBrowserEnabled { get; set; }
    }
}