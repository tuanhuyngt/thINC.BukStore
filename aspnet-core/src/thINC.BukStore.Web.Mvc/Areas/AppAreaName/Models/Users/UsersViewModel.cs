using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Authorization.Permissions.Dto;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Common;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}