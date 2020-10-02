using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Domain.Repositories;
using Abp.Organizations;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Common.Modals;
using thINC.BukStore.Web.Areas.AppAreaName.Models.OrganizationUnits;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_OrganizationUnits)]
    public class OrganizationUnitsController : BukStoreControllerBase
    {
        private readonly IRepository<OrganizationUnit, long> _organizationUnitRepository;

        public OrganizationUnitsController(IRepository<OrganizationUnit, long> organizationUnitRepository)
        {
            _organizationUnitRepository = organizationUnitRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_OrganizationUnits_ManageOrganizationTree)]
        public PartialViewResult CreateModal(long? parentId)
        {
            return PartialView("_CreateModal", new CreateOrganizationUnitModalViewModel(parentId));
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_OrganizationUnits_ManageOrganizationTree)]
        public async Task<PartialViewResult> EditModal(long id)
        {
            var organizationUnit = await _organizationUnitRepository.GetAsync(id);
            var model = ObjectMapper.Map<EditOrganizationUnitModalViewModel>(organizationUnit);

            return PartialView("_EditModal", model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_OrganizationUnits_ManageMembers)]
        public PartialViewResult AddMemberModal(LookupModalViewModel model)
        {
            return PartialView("_AddMemberModal", model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_OrganizationUnits_ManageRoles)]
        public PartialViewResult AddRoleModal(LookupModalViewModel model)
        {
            return PartialView("_AddRoleModal", model);
        }
    }
}