using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCWebapp.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult SayHello(string fname, string lname)
        {
            ViewBag.FirstName = fname;
            ViewBag.LastName = lname; 
            return View();
        }
    }
}