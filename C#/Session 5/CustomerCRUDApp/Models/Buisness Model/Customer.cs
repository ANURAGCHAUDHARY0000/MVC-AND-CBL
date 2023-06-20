using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerCRUDApp.Models.Buisness_Model
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType (DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DateOfBirth { get; set; }

        public string Location { get; set; }

        public string City { get; set; }

        
    }
}