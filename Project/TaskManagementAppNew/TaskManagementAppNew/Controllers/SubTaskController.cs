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
    public class SubTaskController : Controller
    {
        private SubTaskService _service = new SubTaskService();
        // GET: SubTask
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home(int?id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            Session["TaskId"] = id;
            SubTaskVM taskVM = new SubTaskVM();
            taskVM.SubTasks = _service.GetAllSubTask(id);
            taskVM.Count = _service.GetAllSubTask(id).Count();
            return View(taskVM);
        }

        public ActionResult AddSubTask()
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            return View();
        }
        [HttpPost]
        public ActionResult AddSubTask(SubTask task)
        {
            // Get the session ID value
            int sessionId = (int)Session["TaskId"];
            if (!ModelState.IsValid)
            {
                return View(task);
            }
            _service.AddSubTask(task);
            return RedirectToAction("Home", new { id = sessionId });
        }

        public ActionResult DeleteSubTask(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            int sessionId = (int)Session["TaskId"];
            _service.DeleteSubTask(id);
            return RedirectToAction("Home", new { id = sessionId });
        }

        public ActionResult EditSubtask(int id)
        {
            if (Session["LoggedInUser"] == null)
            {
                return RedirectToAction("Login", "LoginTo");
            }
            var subTask = _service.GetSubTaskById(id);
            return View(subTask);
        }

        [HttpPost]
        public ActionResult EditSubtask(int id, SubTask task)
        {
            int sessionId = (int)Session["TaskId"];
            if (!ModelState.IsValid)
            {
                return View();
            }
            _service.EditSubTask(id, task);
            return RedirectToAction("Home", new { id = sessionId });
        }

    }
}