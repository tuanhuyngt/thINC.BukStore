using System.Collections.Generic;
using thINC.BukStore.Authorization.Permissions.Dto;

namespace thINC.BukStore.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}