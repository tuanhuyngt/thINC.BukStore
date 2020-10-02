using Xunit;

namespace thINC.BukStore.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        private readonly bool _multiTenancyEnabled = BukStoreConsts.MultiTenancyEnabled;

        public MultiTenantFactAttribute()
        {
            if (!_multiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}
