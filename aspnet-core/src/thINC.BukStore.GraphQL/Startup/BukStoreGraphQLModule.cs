using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace thINC.BukStore.Startup
{
    [DependsOn(typeof(BukStoreCoreModule))]
    public class BukStoreGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}