using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace thINC.BukStore.Web.Controllers
{
    public class HomeController : BukStoreControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
