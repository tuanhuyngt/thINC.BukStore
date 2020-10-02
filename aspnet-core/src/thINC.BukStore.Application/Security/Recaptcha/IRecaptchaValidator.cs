using System.Threading.Tasks;

namespace thINC.BukStore.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}