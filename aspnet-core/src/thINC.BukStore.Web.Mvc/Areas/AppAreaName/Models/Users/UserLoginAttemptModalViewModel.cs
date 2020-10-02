using System.Collections.Generic;
using thINC.BukStore.Authorization.Users.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}