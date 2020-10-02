using System.Collections.Generic;
using thINC.BukStore.Authorization.Permissions.Dto;

namespace thINC.BukStore.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}