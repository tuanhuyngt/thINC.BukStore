using System.ComponentModel.DataAnnotations;

namespace thINC.BukStore.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}