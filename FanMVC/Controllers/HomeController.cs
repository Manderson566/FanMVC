﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FanMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LignumVita()
        {
            return View();
        }

        public ActionResult AgarWood()
        {
            return View();
        }
        public ActionResult Dalbergia()
        {
            return View();
        }
        public ActionResult ExternalResources()
        {
            return View();
        }
        public ActionResult ContactMe()
        {
            return View();
        }
    }
}