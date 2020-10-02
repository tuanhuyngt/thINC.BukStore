using Microsoft.Extensions.Configuration;

namespace thINC.BukStore.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
