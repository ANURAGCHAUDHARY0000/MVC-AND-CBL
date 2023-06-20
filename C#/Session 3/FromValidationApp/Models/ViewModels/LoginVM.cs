using FromValidationApp.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FromValidationApp.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "User Id Required ")]

        public string UserId { get; set; }

        [Required(ErrorMessage = "User Password Required")]
        [UserIdValidation(ErrorMessage = "{0} can only contain letters and numbers.")]

        public string Password { get; set; }
    }
}