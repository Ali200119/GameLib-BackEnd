﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameLib.Controllers
{
    public class CartController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}