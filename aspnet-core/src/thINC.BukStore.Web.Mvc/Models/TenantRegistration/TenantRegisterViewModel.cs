using thINC.BukStore.Editions;
using thINC.BukStore.Editions.Dto;
using thINC.BukStore.MultiTenancy.Payments;
using thINC.BukStore.Security;
using thINC.BukStore.MultiTenancy.Payments.Dto;

namespace thINC.BukStore.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
