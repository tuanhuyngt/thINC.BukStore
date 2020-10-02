namespace thINC.BukStore.MultiTenancy.Payments
{
    public class PaymentGatewayModel
    {
        public SubscriptionPaymentGatewayType GatewayType { get; set; }

        public bool SupportsRecurringPayments { get; set; }
    }
}