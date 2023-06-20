using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerCRUDApp.EF;
using CustomerCRUDApp.Models.Buisness_Model;
using CustomerCRUDApp.Models.DTO;
using CustomerCRUDApp.Repository;

namespace WelcomeMVCApp.Services
{
    public class CustomerService
    {
        private EntityDBContext _dbContext;

        public CustomerService()
        {
            _dbContext = new EntityDBContext();
        }

        public List<CustomerDTO> GetAllCustomers()
        {
            return _dbContext.Customers.ToList()
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
            return _dbContext.Customers.Count();
        }

        public void Add(Customer c)
        {
            _dbContext.Customers.Add(c);
            _dbContext.SaveChanges();
        }

        public void Update(int id, Customer newCustomer)
        {
            var customer = _dbContext.Customers.Find(id);
            customer.FirstName = newCustomer.FirstName;
            customer.LastName = newCustomer.LastName;
            customer.Location = newCustomer.Location;
            customer.City = newCustomer.City;
            customer.DateOfBirth = newCustomer.DateOfBirth;
            _dbContext.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.Find(id);
        }

        public void Delete(int id)
        {
            var customer = _dbContext.Customers.Find(id);
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}