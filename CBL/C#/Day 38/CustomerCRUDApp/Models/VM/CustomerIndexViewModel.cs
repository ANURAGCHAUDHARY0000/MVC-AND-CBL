using CustomerCRUDApp.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerCRUDApp.Models.VM
{
    public class CustomerIndexViewModel
    {
        public List<CustomerDTO> Customers { get; set; }

        public int Count { get; set; }  
    }
}