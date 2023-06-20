using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMVCApp.Models.BuisnessModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}