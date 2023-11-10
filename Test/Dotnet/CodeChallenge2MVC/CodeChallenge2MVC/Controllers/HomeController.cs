using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeChallenge2MVC.Models;

namespace CodeChallenge2MVC.Controllers
{
    public class HomeController : Controller
    {
        Northwind db = new Northwind();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Germany()
        {
            var gerCust = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(gerCust);
        }
        public ActionResult CustId(int orderId = 10248)
        {
            var customer = db.Customers
            .Where(c => c.Orders.Any(o => o.OrderID == orderId))
            .SingleOrDefault();
            return View(customer);
        }
    }
}