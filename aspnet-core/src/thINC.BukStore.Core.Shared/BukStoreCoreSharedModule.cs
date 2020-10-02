using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore
{
    public class BukStoreCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreCoreSharedModule).GetAssembly());
        }
    }
}