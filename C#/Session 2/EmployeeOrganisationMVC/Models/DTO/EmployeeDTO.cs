using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Models.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeAddress { get; set; }
        public string City { get; set; }
        public int PinCode { get; set; }
        public int OrganisationId { get; set; }
        public string OrganisationName { get; set; }    

    }
}