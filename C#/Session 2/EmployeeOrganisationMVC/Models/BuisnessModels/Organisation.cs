using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Models.BuisnessModels
{
    public class Organisation
    {
        public Organisation()
        {
            Employees = new List<Employee>();
        }
        public int OrganisationId { get; set; }
        public string OrganisationName { get; set; }
        public string OrganisationAddress { get; set; }
        public List<Employee> Employees { get; set; }
    }
}