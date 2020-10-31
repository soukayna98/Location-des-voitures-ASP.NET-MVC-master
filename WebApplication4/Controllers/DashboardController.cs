﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    [Authorize]
    
    public class DashboardController : Controller
    {
        // GET: Dashboard

        [Route("/Admin/Dashboard")]
        public ActionResult Index()
        {
            return View();
        }
    }
}