﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Layout;
using thINC.BukStore.Web.Session;
using thINC.BukStore.Web.Views;

namespace thINC.BukStore.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameTheme9Brand
{
    public class AppAreaNameTheme9BrandViewComponent : BukStoreViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameTheme9BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
