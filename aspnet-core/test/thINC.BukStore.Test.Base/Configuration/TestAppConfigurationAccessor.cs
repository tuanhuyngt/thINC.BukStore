using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using thINC.BukStore.Configuration;

namespace thINC.BukStore.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(BukStoreTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
