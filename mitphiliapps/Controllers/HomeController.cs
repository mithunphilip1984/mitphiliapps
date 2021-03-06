﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Mvc;

namespace mitphiliapps.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            object model1 = ConfigurationManager.AppSettings["Greeting"];
            return View(model1);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}