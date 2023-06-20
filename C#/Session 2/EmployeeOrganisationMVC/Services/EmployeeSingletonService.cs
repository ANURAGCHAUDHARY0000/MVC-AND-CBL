using EmployeeOrganisationMVC.Models.BuisnessModels;
using EmployeeOrganisationMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Services
{
    public class EmployeeSingletonService
    {
        private  static EmployeeSingletonService instance;
        private EmployeeRepository _employeeRepository;

        public EmployeeSingletonService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public static EmployeeSingletonService GetInstance()
        {
            if (instance == null)
                instance = new EmployeeSingletonService();

            return instance;
        }

        public List<Employee> GetEmployees()
        {
            return _employeeRepository.Employees;
                
        }

        public int GetEmployeeCount()
        {
            return _employeeRepository.Employees.Count;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeRepository.Employees.Add(employee);
        }
    }
}