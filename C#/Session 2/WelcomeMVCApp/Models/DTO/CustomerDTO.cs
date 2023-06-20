using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.Models.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

    }
}