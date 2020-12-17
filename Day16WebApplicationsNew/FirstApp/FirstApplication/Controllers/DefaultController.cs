using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult hello(int id)
        {
            string demo = "this is demo text";
            ViewBag.name = demo;
            int value = id;
            ViewBag.id = value;
            return View();
        }
    }
}