using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using thINC.BukStore.Configure;
using thINC.BukStore.Startup;
using thINC.BukStore.Test.Base;

namespace thINC.BukStore.GraphQL.Tests
{
    [DependsOn(
        typeof(BukStoreGraphQLModule),
        typeof(BukStoreTestBaseModule))]
    public class BukStoreGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BukStoreGraphQLTestModule).GetAssembly());
        }
    }
}