using Xunit;

namespace thINC.BukStore.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        private readonly bool _multiTenancyEnabled = BukStoreConsts.MultiTenancyEnabled;
      
        public MultiTenantTheoryAttribute()
        {
            if (!_multiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}