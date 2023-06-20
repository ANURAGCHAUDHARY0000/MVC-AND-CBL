using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerCRUDApp.Models.Buisness_Model;
using CustomerCRUDApp.Models.DTO;
using CustomerCRUDApp.Repository;

namespace WelcomeMVCApp.Services
{
    public class CustomerService
    {
        private CustomerInMemoryRepository _customerInMemoryRepository;

        public  CustomerService()
        {
            _customerInMemoryRepository =   CustomerInMemoryRepository.Instance;
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

        public void Add(Customer c)
        {
            _customerInMemoryRepository.Add(c);
        }

        public void Update(int id, Customer newCustomer)
        {
            _customerInMemoryRepository.Update(id, newCustomer);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerInMemoryRepository.Customers.Find(c => c.Id == id);
        }

        public  void Delete(int id)
        {
           var customer =  _customerInMemoryRepository.Customers.Find(c => c.Id == id);
            _customerInMemoryRepository.Customers.Remove(customer);
        }
            
    }
}