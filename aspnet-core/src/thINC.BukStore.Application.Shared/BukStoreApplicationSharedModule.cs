using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore
{
    [DependsOn(typeof(BukStoreCoreSharedModule))]
    public class BukStoreApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreApplicationSharedModule).GetAssembly());
        }
    }
}