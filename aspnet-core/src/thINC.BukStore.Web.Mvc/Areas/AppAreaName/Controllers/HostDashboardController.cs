using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization;
using thINC.BukStore.DashboardCustomization;
using thINC.BukStore.Web.DashboardCustomization;
using System.Threading.Tasks;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(BukStoreDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}