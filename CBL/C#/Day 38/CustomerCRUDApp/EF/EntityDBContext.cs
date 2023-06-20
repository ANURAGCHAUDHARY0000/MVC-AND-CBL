using CustomerCRUDApp.Models.Buisness_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerCRUDApp.EF
{
    public class EntityDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

    }
}