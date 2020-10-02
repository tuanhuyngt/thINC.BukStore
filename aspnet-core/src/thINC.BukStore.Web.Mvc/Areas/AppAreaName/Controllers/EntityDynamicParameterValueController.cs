using System;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.DynamicEntityParameters;
using Abp.Extensions;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization;
using thINC.BukStore.Web.Areas.AppAreaName.Models.EntityDynamicParameterValues;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameterValue)]
    public class EntityDynamicParameterValueController : BukStoreControllerBase
    {
        private readonly IDynamicEntityParameterDefinitionManager _dynamicEntityParameterDefinitionManager;

        public EntityDynamicParameterValueController(IDynamicEntityParameterDefinitionManager dynamicEntityParameterDefinitionManager)
        {
            _dynamicEntityParameterDefinitionManager = dynamicEntityParameterDefinitionManager;
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameterValue_Edit)]
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameterValue_Create)]
        [HttpGet("/AppAreaName/EntityDynamicParameterValue/ManageAll/{entityFullName}/{entityId}")]
        public IActionResult ManageAll(string entityFullName, string entityId)
        {
            if (entityFullName.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(nameof(entityFullName));
            }

            if (entityId.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(nameof(entityId));
            }

            if (!_dynamicEntityParameterDefinitionManager.ContainsEntity(entityFullName))
            {
                throw new UserFriendlyException(L("UnknownEntityType", entityFullName));
            }

            return View(new EntityDynamicParameterValueManageAllViewModel
            {
                EntityFullName = entityFullName,
                EntityId = entityId
            });
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameterValue_Edit)]
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameterValue_Create)]
        public IActionResult ManageEntityDynamicParameterValuesModal(string entityFullName, string rowId)
        {
            if (entityFullName.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(nameof(entityFullName));
            }

            if (rowId.IsNullOrWhiteSpace())
            {
                throw new ArgumentNullException(nameof(rowId));
            }

            if (!_dynamicEntityParameterDefinitionManager.ContainsEntity(entityFullName))
            {
                throw new UserFriendlyException(L("UnknownEntityType", entityFullName));
            }

            return PartialView("_ManageEntityDynamicParameterValuesModal", new EntityDynamicParameterValueManageAllViewModel
            {
                EntityFullName = entityFullName,
                EntityId = rowId
            });
        }
    }
}