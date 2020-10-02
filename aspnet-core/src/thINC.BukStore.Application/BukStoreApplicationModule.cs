using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using thINC.BukStore.Authorization;

namespace thINC.BukStore
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(BukStoreApplicationSharedModule),
        typeof(BukStoreCoreModule)
        )]
    public class BukStoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreApplicationModule).GetAssembly());
        }
    }
}