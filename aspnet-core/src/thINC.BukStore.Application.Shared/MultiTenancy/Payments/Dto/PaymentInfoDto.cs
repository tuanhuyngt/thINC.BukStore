using thINC.BukStore.Editions.Dto;

namespace thINC.BukStore.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < BukStoreConsts.MinimumUpgradePaymentAmount;
        }
    }
}
