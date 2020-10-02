using System.Threading.Tasks;
using Abp.Webhooks;

namespace thINC.BukStore.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
