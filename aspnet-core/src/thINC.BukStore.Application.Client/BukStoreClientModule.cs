using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore
{
    public class BukStoreClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreClientModule).GetAssembly());
        }
    }
}
