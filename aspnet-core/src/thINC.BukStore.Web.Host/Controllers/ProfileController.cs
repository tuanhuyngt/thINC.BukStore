using Abp.AspNetCore.Mvc.Authorization;
using thINC.BukStore.Storage;

namespace thINC.BukStore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}