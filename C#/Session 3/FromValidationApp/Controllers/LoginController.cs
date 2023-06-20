using FromValidationApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace FromValidationApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(LoginVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Session["UserId"] = vm.UserId;
            return RedirectToAction("Index", "Home");
        }
    }
}