using System.Collections.Generic;
using thINC.BukStore.Editions;
using thINC.BukStore.Editions.Dto;
using thINC.BukStore.MultiTenancy.Payments;
using thINC.BukStore.MultiTenancy.Payments.Dto;

namespace thINC.BukStore.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
