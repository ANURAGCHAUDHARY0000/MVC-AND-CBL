using EmployeeOrganisationMVC.Models.BuisnessModels;
using EmployeeOrganisationMVC.Models.DTO;
using EmployeeOrganisationMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Services
{
    public class EmployeeService
    {
        private EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }   

        public List<EmployeeDTO> GetAllEmployees()
        {
            return _employeeRepository.Employees
                   .Select(x => ConvertEmployeeToDTO(x))
                   .ToList();
        }

        private EmployeeDTO ConvertEmployeeToDTO(Employee employee)
        {
            var DTO = new EmployeeDTO
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                EmployeeDesignation = employee.EmployeeDesignation,
                EmployeeAddress = employee.EmployeeAddress,
                City = employee.City,
                PinCode = employee.PinCode,
                OrganisationId = employee.OrganisationId,
                OrganisationName = employee.OrganisationName
            };
            return DTO;
        }
    }
}