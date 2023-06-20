using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagementAppNew.Models.BusinessModel;
using TaskManagementAppNew.Models.ViewModels;
using TaskManagementAppNew.Service;

namespace TaskManagementAppNew.Controllers
{
    public class LoginToController : Controller
    {
        // GET: LoginTo
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginVM vm)
        {
            User newUser = UserService.GetInstance().GetUser(vm.Email, vm.Password);
            if (newUser != null && newUser.IsAdmin == true)
            {
                Session["LoggedInUser"] = newUser.Name;
                Session["LoggedInId"] = newUser.Id;
                return RedirectToAction("Home", "Admin");
            }
            else if(newUser != null && newUser.IsAdmin == false && newUser.IsActive == true)
            {
                Session["LoggedInUser"] = newUser.Name;
                Session["LoggedInId"] = newUser.Id;
                return RedirectToAction("Home", "Task", new { id = Session["LoggedInId"] });

            }
            else
            {
                vm.LoginErrorMessage = "Invalid username or password!!";
                return View(vm);
            }

        }
        [AllowAnonymous]
        public ActionResult Logout()
        {
            
            HttpRuntime.UnloadAppDomain();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}