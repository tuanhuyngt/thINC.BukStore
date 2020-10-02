using Abp.Authorization;
using thINC.BukStore.Authorization.Roles;
using thINC.BukStore.Authorization.Users;

namespace thINC.BukStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
