using FromValidationApp.Models.BuisnessModel;
using FromValidationApp.Models.ViewModels;
using FromValidationApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FromValidationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
         private StudentService _studentService = new StudentService();
        //private SingletonService _studentService = SingletonService.GetInstance();
        public HomeController() { }

        public ActionResult Index()
        {
            List<Student> students = _studentService.Get();
            return View(students);
        }

       

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Add(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            _studentService.Add(student);
            return RedirectToAction("Index");
        }
    }
}