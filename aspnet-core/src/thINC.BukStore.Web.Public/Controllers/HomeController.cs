﻿using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Public.Controllers
{
    public class HomeController : BukStoreControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}