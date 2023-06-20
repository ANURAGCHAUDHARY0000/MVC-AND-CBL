using EmployeeOrganisationMVC.Models.BuisnessModels;
using EmployeeOrganisationMVC.Models.DTO;
using EmployeeOrganisationMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeOrganisationMVC.Services
{
    public class OrganisationService
    {
        private OrganisationRepository _organisationRepository;
        public OrganisationService()
        {
            _organisationRepository = new OrganisationRepository();

        }

        public List<OrganisationDTO> GetOrganisations()
        {
            return _organisationRepository.Organisations
                   .Select(x => ConvertOrganisationToDTO(x))
                   .ToList();
        }

        private OrganisationDTO ConvertOrganisationToDTO(Organisation organisation)
        {
            var DTO = new OrganisationDTO
            {
              OrganisationID = organisation.OrganisationId,
              OrganisationName = organisation.OrganisationName,
              OrganisationAddress = organisation.OrganisationAddress
            };
            return DTO;
        }


    }
}