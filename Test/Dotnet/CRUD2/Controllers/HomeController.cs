using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD2.Controllers
{
    public class HomeController : Controller
    {
        MovieDBConnect _connect = new MovieDBConnect();
        public ActionResult Index()
        {
            var listofData = _connect.Movielists.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movielist model)
        {
            _connect.Movielists.Add(model);
            _connect.SaveChanges();
            ViewBag.Message = "Data Insert Successfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _connect.Movielists.Where(x => x.Mid == id).First();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Movielist Model)
        {
            var data = _connect.Movielists.Where(x => x.Mid == Model.Mid).First();
            if (data != null)
            {
                data.Moviename = Model.Moviename;
                data.DateofRelease = Model.DateofRelease;
                _connect.SaveChanges();
            }
            return RedirectToAction("index");
        }
        public ActionResult Details(int id)
        {
            var data = _connect.Movielists.Where(x => x.Mid == id).First();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var data = _connect.Movielists.Where(x => x.Mid == id).First();
            _connect.Movielists.Remove(data);
            _connect.SaveChanges();
            ViewBag.Message = "Record deleted Successfully ";
            return RedirectToAction("index");
        }
    }
}