using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace thINC.BukStore.Web.Public.Views
{
    public abstract class BukStoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected BukStoreRazorPage()
        {
            LocalizationSourceName = BukStoreConsts.LocalizationSourceName;
        }
    }
}
