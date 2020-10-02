using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Authorization.Delegation;
using thINC.BukStore.Authorization.Users.Delegation;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Layout;
using thINC.BukStore.Web.Views;

namespace thINC.BukStore.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameActiveUserDelegationsCombobox
{
    public class AppAreaNameActiveUserDelegationsComboboxViewComponent : BukStoreViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AppAreaNameActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
