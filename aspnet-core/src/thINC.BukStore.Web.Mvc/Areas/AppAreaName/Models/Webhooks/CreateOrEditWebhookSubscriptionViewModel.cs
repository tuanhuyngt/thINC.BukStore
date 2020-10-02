using Abp.Application.Services.Dto;
using Abp.Webhooks;
using thINC.BukStore.WebHooks.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
