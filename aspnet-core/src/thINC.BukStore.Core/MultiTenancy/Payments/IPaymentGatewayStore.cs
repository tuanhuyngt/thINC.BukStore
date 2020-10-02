using System.Collections.Generic;

namespace thINC.BukStore.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
