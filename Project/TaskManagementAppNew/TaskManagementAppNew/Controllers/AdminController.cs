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
    public class AdminController : Controller
    {
        // GET: Admin
        private UserService _service = UserService.GetInstance();
        public ActionResult Home()
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            UserVM userVM = new UserVM();
            userVM.Users = _service.GetAllUser();
            userVM.Count  = _service.GetAllUser().Count;
            return View(userVM);
        }
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            _service.AddUser(user);
            return RedirectToAction("Home");
        }
        public ActionResult DisableUser(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            _service.DisableUser(id);
            return RedirectToAction("Home");
        }

        public ActionResult EnableUser(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            _service.EnableUser(id);
            return RedirectToAction("Home");
        }

        public ActionResult EditUser(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            var user  = _service.GetAllUser().Find(x=>x.Id == id);
            return View(user);
        }
        [HttpPost]
        public ActionResult EditUser(int id,User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _service.EditUser(id, user);
            return RedirectToAction("Home");
        }
    }
}