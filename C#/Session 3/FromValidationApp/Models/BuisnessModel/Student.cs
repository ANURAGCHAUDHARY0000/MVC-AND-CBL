using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FromValidationApp.Models.BuisnessModel
{
    public class Student
    {
        [Range (0,100)]
        [Required]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
    }
}