﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeedStore.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Weed()
        {
            return View();
        }
    }
}
