using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore
{
    [DependsOn(typeof(BukStoreClientModule), typeof(AbpAutoMapperModule))]
    public class BukStoreXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreXamarinSharedModule).GetAssembly());
        }
    }
}