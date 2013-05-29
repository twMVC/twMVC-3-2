using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCValidate.Models;

namespace MVCValidate.Controllers
{
    public class CustomController : Controller
    {
        //
        // GET: /Custom/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomTestModels m)
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserModels model)
        {
            model.Quota = 4;

            //檢查資料是否驗證通過
            if (ModelState.IsValid)
            {
                //資料通過驗證執行項目
                try
                {
                    //真正執行寫入資料庫的方法

                    //執行成功回到列表頁
                    return Content("寫入成功");
                }
                catch (Exception)
                {
                    //發生例外
                    //記錄 Log 或是任何例外處理
                }
            }
            //資料寫入失敗導回資料頁
            return View(model);
        }
    }
}
