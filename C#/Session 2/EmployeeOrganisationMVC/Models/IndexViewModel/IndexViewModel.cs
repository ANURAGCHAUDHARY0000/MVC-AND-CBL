using EmployeeOrganisationMVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Models.IndexViewModel
{
    public class IndexViewModel
    {
        public List<OrganisationDTO> Organisations { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
    }
}