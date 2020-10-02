using System.Collections.Generic;
using thINC.BukStore.Authorization.Permissions.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}