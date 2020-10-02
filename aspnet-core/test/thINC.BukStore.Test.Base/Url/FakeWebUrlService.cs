using System.Collections.Generic;
using thINC.BukStore.Url;

namespace thINC.BukStore.Test.Base.Url
{
    public class FakeWebUrlService : IWebUrlService
    {
        public string WebSiteRootAddressFormat { get; }

        public string ServerRootAddressFormat { get; }

        public bool SupportsTenancyNameInUrl { get; }

        public string GetSiteRootAddress(string tenancyName = null)
        {
            return "http://test.com/";
        }

        public string GetServerRootAddress(string tenancyName = null)
        {
            return "http://test.com/";
        }

        public List<string> GetRedirectAllowedExternalWebSites()
        {
            return new List<string>();
        }
    }
}