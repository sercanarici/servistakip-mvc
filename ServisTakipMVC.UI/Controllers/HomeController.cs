﻿using ServisTakipMVC.UI.Areas.Admin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakipMVC.UI.Controllers
{
    [AuthFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //return RedirectToAction("Index", "Home", new { area = "Admin" });    
            return View();
        }
    }
}