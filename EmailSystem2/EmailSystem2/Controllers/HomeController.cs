using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmailSystem2.Models;

namespace EmailSystem2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Player Nneka = new Player();
            Nneka.name = "Ogwumike";
            Nneka.playingNo = 7;
            Nneka.Email = "Ogwumike@useremail.com";

            return View("Index", Nneka);

        }
        public ActionResult Index1()
        {

            Player Donne = new Player();
            Donne.name = "Della Donne";
            Donne.playingNo = 12;
            Donne.Email = "DellaD@useremail.com";

            return View("Index1", Donne);
        }
    }
}