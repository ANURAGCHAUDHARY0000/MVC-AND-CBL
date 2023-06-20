using CustomerCRUDApp.Models.Buisness_Model;
using CustomerCRUDApp.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Services;

namespace CustomerCRUDApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private CustomerService _service = new CustomerService();
        public ActionResult Index()
        {
            CustomerIndexViewModel vm = new CustomerIndexViewModel();
            vm.Customers = _service.GetAllCustomers();
            vm.Count = _service.GetCustomerCount();
            return View(vm);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Customer customer = new Customer();
            return View(customer);   
        }



        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            _service.Add(customer);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int customerId)
        {
            _service.GetCustomerById(customerId);
            var customer = _service.GetCustomerById(customerId);    
             return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }
            _service.Update(customer.Id, customer);
            return RedirectToAction("Index");

        }

        
        public ActionResult Delete(int customerId)
        {
            _service.Delete(customerId);
            return RedirectToAction("Index");
        }


    }
}