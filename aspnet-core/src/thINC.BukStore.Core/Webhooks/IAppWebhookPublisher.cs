using System.Threading.Tasks;
using thINC.BukStore.Authorization.Users;

namespace thINC.BukStore.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
