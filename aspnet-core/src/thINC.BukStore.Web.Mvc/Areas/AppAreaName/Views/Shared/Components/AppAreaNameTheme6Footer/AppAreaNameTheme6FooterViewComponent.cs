﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Layout;
using thINC.BukStore.Web.Session;
using thINC.BukStore.Web.Views;

namespace thINC.BukStore.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameTheme6Footer
{
    public class AppAreaNameTheme6FooterViewComponent : BukStoreViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme6FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
