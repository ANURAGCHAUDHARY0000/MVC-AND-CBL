using EmployeeOrganisationMVC.Models.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Repository
{
    public class EmployeeRepository
    {
        private List<Employee> _employess;

        public EmployeeRepository()
        {
            _employess = new List<Employee>();
            _employess.Add(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "abc",
                EmployeeDesignation = "Manager",
                EmployeeAddress = "Rampur",
                City = "Lucknow",
                PinCode = 12345,
             });

            _employess.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "def",
                EmployeeDesignation = "Contractor",
                EmployeeAddress = "Rampur",
                City = "Delhi",
                PinCode = 12345,
            });

            _employess.Add(new Employee
            {
                EmployeeId = 3,
                EmployeeName = "ghi",
                EmployeeDesignation = "Tester",
                EmployeeAddress = "Rampur",
                City = "Agra",
                PinCode = 12345,
            });

            _employess.Add(new Employee
            {
                EmployeeId = 4,
                EmployeeName = "jkl",
                EmployeeDesignation = "Developer",
                EmployeeAddress = "Jaipur",
                City = "Lucknow",
                PinCode = 12345,
            });

          
        }
        public List<Employee> Employees { get { return _employess; } }
    }
}