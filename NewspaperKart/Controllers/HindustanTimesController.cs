﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class HindustanTimesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}