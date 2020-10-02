using System.Collections.Generic;
using thINC.BukStore.Editions.Dto;
using thINC.BukStore.MultiTenancy.Payments;

namespace thINC.BukStore.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}