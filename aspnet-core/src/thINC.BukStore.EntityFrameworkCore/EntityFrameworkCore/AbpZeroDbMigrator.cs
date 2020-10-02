using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;

namespace thINC.BukStore.EntityFrameworkCore
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<BukStoreDbContext>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IDbContextResolver dbContextResolver) :
            base(
                unitOfWorkManager,
                connectionStringResolver,
                dbContextResolver)
        {

        }
    }
}
