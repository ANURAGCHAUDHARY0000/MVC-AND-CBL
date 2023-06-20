using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.Models.BuisnessModels;
using WelcomeMVCApp.Models.DTO;
using WelcomeMVCApp.Repository;

namespace WelcomeMVCApp.Services
{
    public class CustomerService
    {
        private CustomerInMemoryRepository _customerInMemoryRepository;

        public CustomerService()
        {
            _customerInMemoryRepository =  new CustomerInMemoryRepository();
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return _customerInMemoryRepository.Customers
                .Select(x => ConvertCustomerToDTO(x))
                .ToList();

        }

        private CustomerDTO ConvertCustomerToDTO(Customer c)
        {
            int age = DateTime.Now.Year - c.DateOfBirth.Year;
            var DTO = new CustomerDTO
            {
                Id = c.Id,
                Address = c.Location + "-" + c.City,
                FullName = c.FirstName + "-" + c.LastName,
                Age = age,
            };
            return DTO;
        }

        public int GetCustomerCount()
        {
            return _customerInMemoryRepository.Customers.Count();
        }
    }
}