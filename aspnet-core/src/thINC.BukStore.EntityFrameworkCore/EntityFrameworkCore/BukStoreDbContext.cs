using Abp.IdentityServer4;
using Abp.Organizations;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using thINC.BukStore.Authorization.Delegation;
using thINC.BukStore.Authorization.Roles;
using thINC.BukStore.Authorization.Users;
using thINC.BukStore.Chat;
using thINC.BukStore.Editions;
using thINC.BukStore.Friendships;
using thINC.BukStore.MultiTenancy;
using thINC.BukStore.MultiTenancy.Accounting;
using thINC.BukStore.MultiTenancy.Payments;
using thINC.BukStore.Storage;

namespace thINC.BukStore.EntityFrameworkCore
{
    public class BukStoreDbContext : AbpZeroDbContext<Tenant, Role, User, BukStoreDbContext>, IAbpPersistedGrantDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public BukStoreDbContext(DbContextOptions<BukStoreDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
