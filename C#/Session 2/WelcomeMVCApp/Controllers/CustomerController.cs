using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models.DTO;
using WelcomeMVCApp.Models.VM;
using WelcomeMVCApp.Services;


namespace WelcomeMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerService Service = new CustomerService();   
            CustomerIndexViewModel cutomer = new CustomerIndexViewModel();
            cutomer.Customers = Service.GetAllCustomers();
            cutomer.Count = Service.GetCustomerCount();
            return View(cutomer);
        }

        public ActionResult IndexV2()
        {
            CustomerService Service = new CustomerService();
            List<CustomerDTO> vm = Service.GetAllCustomers();
            return View(vm);
        }
    }
}