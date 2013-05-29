using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCValidate.Models;

namespace MVCValidate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Required()
        {
            return View();
        }
        public ActionResult StringLength()
        {
            return View();
        }
        public ActionResult Regex()
        {
            return View();
        }

        public ActionResult Compare()
        {
            return View();
        }
        public ActionResult Remote()
        {
            return View();
        }
     
        public ActionResult AllowHtml()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AllowHtml(TestModelsAllowHtml c)
        {
            ViewData["A"] = c.AllowHtml;
            ViewData["D"] = c.Disallow;

            //ViewData["A"] = c["AllowHtml"];
            //ViewData["D"] = c["Disallow"];
            return View();
        }
    }
}
