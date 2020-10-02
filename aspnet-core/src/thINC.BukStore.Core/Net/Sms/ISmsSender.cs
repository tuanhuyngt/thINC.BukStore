using System.Threading.Tasks;

namespace thINC.BukStore.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}