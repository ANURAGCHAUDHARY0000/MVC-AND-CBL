using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using TaskManagementAppNew.Models.BusinessModel;
using TaskManagementAppNew.Models.ViewModels;
using TaskManagementAppNew.Service;

namespace TaskManagementAppNew.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        private TaskService _service = new TaskService();
        public ActionResult Home(int ? id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            TaskVM taskVM = new TaskVM();
            taskVM.Tasks = _service.GetAllTask(id);
            taskVM.Count = taskVM.Tasks.Count;
            return View(taskVM);
        }
        public ActionResult Index()
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            return View();
        }
        public ActionResult AddTask()
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddTask(Task task)
        {
            if (!ModelState.IsValid)
            {
                return View(task);
            }
            _service.AddTask(task);
            return RedirectToAction("Home");
        }

        public ActionResult DeleteTask(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            _service.DeleteTask(id);
            return RedirectToAction("Home");
        }




    }
}