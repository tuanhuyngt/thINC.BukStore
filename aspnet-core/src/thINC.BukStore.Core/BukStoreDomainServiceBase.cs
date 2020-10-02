using Abp.Domain.Services;

namespace thINC.BukStore
{
    public abstract class BukStoreDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected BukStoreDomainServiceBase()
        {
            LocalizationSourceName = BukStoreConsts.LocalizationSourceName;
        }
    }
}
