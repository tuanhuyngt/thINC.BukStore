using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.DynamicEntityParameters;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization;
using thINC.BukStore.DynamicEntityParameters;
using thINC.BukStore.Web.Areas.AppAreaName.Models.EntityDynamicParameters;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameters)]
    public class EntityDynamicParameterController : BukStoreControllerBase
    {
        private readonly IDynamicParameterAppService _dynamicParameterAppService;
        private readonly IDynamicEntityParameterDefinitionManager _dynamicEntityParameterDefinitionManager;

        public EntityDynamicParameterController(
            IDynamicParameterAppService dynamicParameterAppService,
            IDynamicEntityParameterDefinitionManager dynamicEntityParameterDefinitionManager
            )
        {
            _dynamicParameterAppService = dynamicParameterAppService;
            _dynamicEntityParameterDefinitionManager = dynamicEntityParameterDefinitionManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameters_Create)]
        public async Task<IActionResult> CreateModal()
        {
            var model = new CreateEntityDynamicParameterViewModel()
            {
                DynamicParameters = (await _dynamicParameterAppService.GetAll()).Items.ToList(),
                AllEntities = _dynamicEntityParameterDefinitionManager.GetAllEntities()
            };

            return PartialView("_CreateModal", model);
        }
    }
}