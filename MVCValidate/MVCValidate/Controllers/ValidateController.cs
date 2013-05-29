using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidate.Controllers
{
    public class ValidateController : Controller
    {
        //
        // GET: /Validate/

        public JsonResult CheckUserName(string userName)
        {
            bool isValidate = false;

            //利用 IsLocalUrl檢查是否為網站呼叫的
            //借此忽略一些不必要的流量
            if (Url.IsLocalUrl(Request.Url.AbsoluteUri))
            {
                if (userName != "demoshop")
                {
                    //因連資料庫麻煩
                    //所以假裝示範不可以註冊某一名字
                    isValidate = true;
                }
            }
            // Remote 驗證是使用 Get 因此要開放
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}
