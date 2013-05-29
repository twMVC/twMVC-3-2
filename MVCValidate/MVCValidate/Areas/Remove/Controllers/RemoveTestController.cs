using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCValidate.Models;

namespace MVCValidate.Areas.Remove.Controllers
{
    public class RemoveTestController : Controller
    {
        //
        // GET: /Remove/RemoteTest/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TestModelsRemove c)
        {
            if (ModelState.IsValid)
            {
                return Content("<h1>驗證通過</h1>");
            }
            return Content("<h1>驗證失敗</h1>");
        }
    }
}
