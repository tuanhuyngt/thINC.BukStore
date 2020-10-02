using System.Threading.Tasks;
using thINC.BukStore.Sessions.Dto;

namespace thINC.BukStore.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
