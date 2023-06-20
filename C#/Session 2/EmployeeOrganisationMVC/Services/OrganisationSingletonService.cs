using EmployeeOrganisationMVC.Models.BuisnessModels;
using EmployeeOrganisationMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Services
{
    public class OrganisationSingletonService
    {
        private static OrganisationSingletonService instance;
        private OrganisationRepository _organisationRepository;

        public OrganisationSingletonService()
        {
            _organisationRepository = new OrganisationRepository();
        }

        public static OrganisationSingletonService GetInstance()
        {
            if (instance == null)
                instance = new OrganisationSingletonService();

            return instance;
        }

        public List<Organisation> GetOrganisations()
        {
            return _organisationRepository.Organisations;

        }

        public int GetOrganisationCount()
        {
            return _organisationRepository.Organisations.Count;
        }

        public void AddOrganisation(Organisation organisation)
        {
            _organisationRepository.Organisations.Add(organisation);    
        }
    }
}