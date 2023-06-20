using EmployeeOrganisationMVC.Models.BuisnessModels;
using EmployeeOrganisationMVC.Models.IndexViewModel;
using EmployeeOrganisationMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace EmployeeOrganisationMVC.Controllers
{
    public class OrganisationController : Controller
    {
        private OrganisationSingletonService _organisationSingletonService = OrganisationSingletonService.GetInstance();
        // GET: Organisation
        public ActionResult Index()
        {
            OrganisationService organisationService = new OrganisationService();
            IndexViewModel organisation = new IndexViewModel();
            organisation.Organisations = organisationService.GetOrganisations();
            return View(organisation);
        }

        [HttpPost]
        public ActionResult AddOrganisation(Organisation organisation)
        {
            if(!ModelState.IsValid)
            {
                return View(organisation);
            }
            _organisationSingletonService.AddOrganisation(organisation);
            return RedirectToAction("Index");

        }

    }
}