using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.MultiTenancy.Payments.Dto;
using thINC.BukStore.MultiTenancy.Payments.Stripe.Dto;

namespace thINC.BukStore.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}