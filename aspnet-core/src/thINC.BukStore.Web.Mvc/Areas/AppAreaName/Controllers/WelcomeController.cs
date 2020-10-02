using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : BukStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}