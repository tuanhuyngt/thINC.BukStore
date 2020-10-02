using System.Threading.Tasks;
using Abp.Application.Services;
using thINC.BukStore.MultiTenancy.Payments.PayPal.Dto;

namespace thINC.BukStore.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
