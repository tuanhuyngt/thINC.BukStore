using System.Collections.Generic;
using thINC.BukStore.Authorization.Delegation;
using thINC.BukStore.Authorization.Users.Delegation.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
