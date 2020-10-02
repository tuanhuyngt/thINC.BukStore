using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Auditing;
using thINC.BukStore.Auditing.Dto;
using thINC.BukStore.Authorization;
using thINC.BukStore.Web.Areas.AppAreaName.Models.AuditLogs;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : BukStoreControllerBase
    {
        private readonly IAuditLogAppService _auditLogAppService;

        public AuditLogsController(IAuditLogAppService auditLogAppService)
        {
            _auditLogAppService = auditLogAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> EntityChangeDetailModal(EntityChangeListDto entityChangeListDto)
        {
            var output = await _auditLogAppService.GetEntityPropertyChanges(entityChangeListDto.Id);

            var viewModel = new EntityChangeDetailModalViewModel(output, entityChangeListDto);

            return PartialView("_EntityChangeDetailModal", viewModel);
        }
    }
}