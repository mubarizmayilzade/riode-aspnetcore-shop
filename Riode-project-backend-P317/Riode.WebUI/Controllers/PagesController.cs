﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult details()
        {
            return View();
        }
    }
}
