using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.Models.DTO;

namespace WelcomeMVCApp.Models.VM
{
    public class CustomerIndexViewModel
    {
        public List<CustomerDTO> Customers { get; set; }

        public int Count { get; set; }
    }
}