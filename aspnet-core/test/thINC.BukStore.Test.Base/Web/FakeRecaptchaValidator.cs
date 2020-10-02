using System.Threading.Tasks;
using thINC.BukStore.Security.Recaptcha;

namespace thINC.BukStore.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
