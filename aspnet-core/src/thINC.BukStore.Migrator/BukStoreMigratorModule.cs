using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using thINC.BukStore.Configuration;
using thINC.BukStore.EntityFrameworkCore;
using thINC.BukStore.Migrator.DependencyInjection;

namespace thINC.BukStore.Migrator
{
    [DependsOn(typeof(BukStoreEntityFrameworkCoreModule))]
    public class BukStoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BukStoreMigratorModule(BukStoreEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(BukStoreMigratorModule).GetAssembly().GetDirectoryPathOrNull(), addUserSecrets: true
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                BukStoreConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}