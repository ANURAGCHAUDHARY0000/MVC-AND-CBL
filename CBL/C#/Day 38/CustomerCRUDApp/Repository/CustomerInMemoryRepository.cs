using CustomerCRUDApp.EF;
using CustomerCRUDApp.Models.Buisness_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerCRUDApp.Repository
{
    public class CustomerInMemoryRepository
    {
        private EntityDBContext _context;

        public CustomerInMemoryRepository()
        {
            _context = new EntityDBContext();
        }

        public void Add(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }

        public void Update(int id, Customer newCustomer)
        {
            var customer = _context.Customers.Find(id);
            customer.FirstName = newCustomer.FirstName;
            customer.LastName = newCustomer.LastName;
            customer.Location = newCustomer.Location;
            customer.City = newCustomer.City;
            customer.DateOfBirth = newCustomer.DateOfBirth;
            _context.SaveChanges();
        }

        public List<Customer> Customers { get { return _context.Customers.ToList(); } }
    }

    
}