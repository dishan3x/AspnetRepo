using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCWebapp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // [ActionName("Default")] // when we need a diffenrenct name for action.
        //[HttpGet]
       // public ActionResult Index()
        //{
        //    return View("Index");
        //}

        //[HttpPost]
        //[RequireHttps] // need a http request
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
                ViewData["id"] = id.Value;
            else
                ViewData["id"]= 0;
            return View();
        }

        public ActionResult About(string id)
        {
            int? idt = ViewBag.id;
            if (id == null) return View();
            return View("Contact");
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}