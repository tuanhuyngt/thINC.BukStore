using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Authorization.Permissions.Dto;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Common;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}