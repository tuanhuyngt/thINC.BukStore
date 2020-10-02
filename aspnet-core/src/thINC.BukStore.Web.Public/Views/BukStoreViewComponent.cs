using Abp.AspNetCore.Mvc.ViewComponents;

namespace thINC.BukStore.Web.Public.Views
{
    public abstract class BukStoreViewComponent : AbpViewComponent
    {
        protected BukStoreViewComponent()
        {
            LocalizationSourceName = BukStoreConsts.LocalizationSourceName;
        }
    }
}