using System;
using System.Transactions;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using thINC.BukStore.EntityFrameworkCore;
using thINC.BukStore.Migrations.Seed.Host;
using thINC.BukStore.Migrations.Seed.Tenants;

namespace thINC.BukStore.Migrations.Seed
{
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<BukStoreDbContext>(iocResolver, SeedHostDb);
        }

        public static void SeedHostDb(BukStoreDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            //Host seed
            new InitialHostDbBuilder(context).Create();

            //Default tenant seed (in host database).
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();
        }

        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}
