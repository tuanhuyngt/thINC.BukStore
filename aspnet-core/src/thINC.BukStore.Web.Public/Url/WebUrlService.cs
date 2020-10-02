using Abp.Dependency;
using thINC.BukStore.Configuration;
using thINC.BukStore.Url;
using thINC.BukStore.Web.Url;

namespace thINC.BukStore.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IAppConfigurationAccessor appConfigurationAccessor) :
            base(appConfigurationAccessor)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}