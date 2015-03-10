﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeShareDAL;

namespace HomeShareMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {     
            return View(new BienEchange());
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