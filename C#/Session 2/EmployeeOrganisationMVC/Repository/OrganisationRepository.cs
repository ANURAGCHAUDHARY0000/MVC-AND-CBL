using EmployeeOrganisationMVC.Models.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Repository
{
    public class OrganisationRepository
    {
        private List<Organisation> _organisation;

        public OrganisationRepository ()
        {
            _organisation = new List<Organisation>();
            _organisation.Add(new Organisation
            {
                OrganisationId = 121,
                OrganisationName = "Microsoft",
                OrganisationAddress = "Mumbai",
            });
                       
        }

        public List<Organisation> Organisations { get { return _organisation; } }
    }
}