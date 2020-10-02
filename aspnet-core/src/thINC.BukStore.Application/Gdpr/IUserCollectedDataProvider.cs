using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using thINC.BukStore.Dto;

namespace thINC.BukStore.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
