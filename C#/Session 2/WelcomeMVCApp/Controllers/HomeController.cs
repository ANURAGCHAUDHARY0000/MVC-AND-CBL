using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public ActionResult Greet()
        {
            int hours = DateTime.Now.Hour;
            if (hours < 12)
                return Content("Goodmorning");
            if (hours < 15)
                return Json(new
                {
                    Message = "Good After Noon"
                }, JsonRequestBehavior.AllowGet);
            else
                return Content("GoodEvening");

        }
    }
}