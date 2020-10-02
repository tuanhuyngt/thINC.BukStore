using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Editions;
using thINC.BukStore.Web.Controllers;
using thINC.BukStore.Web.Session;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : BukStoreControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}