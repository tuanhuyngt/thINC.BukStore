using Abp.AspNetCore.Mvc.Authorization;
using thINC.BukStore.Authorization;
using thINC.BukStore.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace thINC.BukStore.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}