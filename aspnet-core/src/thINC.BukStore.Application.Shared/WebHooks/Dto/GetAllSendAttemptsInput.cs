using thINC.BukStore.Dto;

namespace thINC.BukStore.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
