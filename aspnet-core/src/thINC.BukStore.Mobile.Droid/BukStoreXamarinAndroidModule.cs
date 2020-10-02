using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore
{
    [DependsOn(typeof(BukStoreXamarinSharedModule))]
    public class BukStoreXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreXamarinAndroidModule).GetAssembly());
        }
    }
}