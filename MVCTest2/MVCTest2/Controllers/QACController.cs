﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest2.Controllers
{
    public class QACController : Controller
    {
        // GET: QAC
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View("AboutUs1");
        }
    }
}