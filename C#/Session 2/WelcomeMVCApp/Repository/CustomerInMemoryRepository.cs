using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.Models.BuisnessModels;

namespace WelcomeMVCApp.Repository
{
    public class CustomerInMemoryRepository
    {
        private List<Customer> _customers;

        public CustomerInMemoryRepository()
        {
            _customers = new List<Customer>();
            _customers.Add(new Customer
            {
                Id = 1,
                FirstName = "Customer A",
                LastName = "Customer A Last Name",
                DateOfBirth = new DateTime(1986, 10, 10),
                Location = "Andheri",
                City = "Mumbai"

            });
            _customers.Add(new Customer
            {
                Id = 2,
                FirstName = "Customer B",
                LastName = "Customer B Last Name",
                DateOfBirth = new DateTime(1986, 10, 10),
                Location = "Andheri",
                City = "Mumbai"

            });
            _customers.Add(new Customer
            {
                Id = 3,
                FirstName = "Customer C",
                LastName = "Customer C Last Name",
                DateOfBirth = new DateTime(1986, 10, 10),
                Location = "Andheri",
                City = "Mumbai"

            });
            _customers.Add(new Customer
            {
                Id = 4,
                FirstName = "Customer D",
                LastName = "Customer D Last Name",
                DateOfBirth = new DateTime(1986, 10, 10),
                Location = "Andheri",
                City = "Mumbai"

            });
        }

        public List<Customer> Customers { get { return _customers; } }
    }
}