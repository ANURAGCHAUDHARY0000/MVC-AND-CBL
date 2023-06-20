using CustomerCRUDApp.Models.Buisness_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerCRUDApp.Repository
{
    public class CustomerInMemoryRepository
    {
        public List<Customer> _customers;

        private static CustomerInMemoryRepository _instance; 
        
        public static CustomerInMemoryRepository Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new CustomerInMemoryRepository();
                return _instance;
            }
        }

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

        public void Add(Customer c)
        {
            _customers.Add(c);  
        }

        public void Update(int id, Customer newCustomer)
        {
            var customer = _customers.Find(x => x.Id == id);
            customer.FirstName = newCustomer.FirstName;
            customer.LastName = newCustomer.LastName;
            customer.Location = newCustomer.Location;
            customer.City = newCustomer.City;
            customer.DateOfBirth = newCustomer.DateOfBirth;
        }

        public List<Customer> Customers { get { return _customers; } }

    }
}