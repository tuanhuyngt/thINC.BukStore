using Abp.AspNetCore.Mvc.Views;

namespace thINC.BukStore.Web.Views
{
    public abstract class BukStoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BukStoreRazorPage()
        {
            LocalizationSourceName = BukStoreConsts.LocalizationSourceName;
        }
    }
}
