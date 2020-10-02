using System.Collections.Generic;
using MvvmHelpers;
using thINC.BukStore.Models.NavigationMenu;

namespace thINC.BukStore.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}