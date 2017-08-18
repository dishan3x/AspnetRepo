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
        [ActionName("Default")] // when we need a diffenrenct name for action.
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult About(string id)
        {
            if (id == null) return View();
            return View("Contact");
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}