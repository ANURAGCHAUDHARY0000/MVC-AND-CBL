using EmployeeOrganisationMVC.Models.IndexViewModel;
using EmployeeOrganisationMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOrganisationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeOrganisation

        private EmployeeSingletonService _empSingletonService = EmployeeSingletonService.GetInstance();
        

        public ActionResult Index()
        {
            EmployeeService service = new EmployeeService();
            IndexViewModel  employee = new IndexViewModel();
            employee.Employees = service.GetAllEmployees();
            return View(employee);
        }
    }
}