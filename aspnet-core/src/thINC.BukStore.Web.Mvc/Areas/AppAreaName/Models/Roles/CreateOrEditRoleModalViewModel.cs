using Abp.AutoMapper;
using thINC.BukStore.Authorization.Roles.Dto;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Common;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}