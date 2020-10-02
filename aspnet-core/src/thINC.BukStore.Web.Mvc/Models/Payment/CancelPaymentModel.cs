using thINC.BukStore.MultiTenancy.Payments;

namespace thINC.BukStore.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}