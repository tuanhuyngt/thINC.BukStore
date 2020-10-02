using Abp.Events.Bus;

namespace thINC.BukStore.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}