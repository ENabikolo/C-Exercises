using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mathematics.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Calculations(int No1, int No2)
        {
            int c = No1 + No2;
            ViewData["Result"] = c;
                  return View("Result");
        }
        public ActionResult Addition(int a, int b)
        {
            int c = a + b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;
            if (c > 50)
            {
                ViewData["result"] = "You have passed";
            }
            else
            {
                ViewData["result"] = "You have failed";
            }
            return View("Result");
        }

        public ActionResult Subtraction(int a, int b)
        {
            int c = a - b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;
            if (c > 50)
            {
                ViewData["result"] = "You have passed";
            }
            else
            {
                ViewData["result"] = "You have failed";
            }
            return View();
        }
        public ActionResult Multiplication(int a, int b)
        {
            int c = a * b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;
            if (c > 50)
            {
                ViewData["result"] = "You have passed";
            }
            else
            {
                ViewData["result"] = "You have failed";
            }
            return View();
        }
        public ActionResult Division(int a, int b)
        {
            int c = a / b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;
            if (c > 50)
            {
                ViewData["result"] = "You have passed";
            }
            else
            {
                ViewData["result"] = "You have failed";
            }
            return View();
        }
    }
}