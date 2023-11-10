using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeChallenge2MVC.Controllers
{
    public class NorthwindController : Controller
    {

        // GET: Northwind
        public ActionResult Index()
        {
            return View();
        }

        public string SayHi()
        {
            return "hi from 'SayHi'.";
        }
    }
}