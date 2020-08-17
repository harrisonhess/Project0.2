using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project0._2.Models;

namespace Project0._2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IVolunteerRepository _volunteerRepository;
        private readonly IOpportunityRepository _opportunityRepository;
        public HomeController(ILogger<HomeController> logger, IVolunteerRepository volunteerRepository, IOpportunityRepository opportunityRepository)
        {
            _logger = logger;
            _volunteerRepository = volunteerRepository;
            _opportunityRepository = opportunityRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult AdminIndex()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        [Authorize]
        public IActionResult VolunteerList()
        {
            ViewData.Model = _volunteerRepository.getVolunteers();
            return View();
        }
        [Authorize]
        public IActionResult OpportunityList()
        {
            ViewData.Model = _opportunityRepository.GetOpportunities();
            return View();
        }
        [Authorize]
        public IActionResult DeleteOpportunity(int id)
        {
            _opportunityRepository.DeleteOpportunity(id);
            return RedirectToAction("OpportunityList");
        }
        [HttpGet]
        public IActionResult OpportunityDetails(int id)
        {
            ViewData.Model = _opportunityRepository.GetOpportunity(id);
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult EditOpportunity(int id)
        {
            ViewData.Model = _opportunityRepository.GetOpportunity(id);
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult SaveOpportunity(Opportunity opportunity)
        {
            _opportunityRepository.SaveOpportunity(opportunity);
            return RedirectToAction("OpportunityList");
        }
        [HttpPost]
        [Authorize]
        public IActionResult CreateOpportunity(Opportunity opportunity)
        {
            _opportunityRepository.CreateOpportunity(opportunity);
            return RedirectToAction("OpportunityList");
        }
        [Authorize]
        public IActionResult CreateOpportunity()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchOpps(string SearchKey)
        {
            if (!String.IsNullOrEmpty(SearchKey))
            {
                ViewData.Model = _opportunityRepository.SearchOpps(SearchKey);
                return View("OpportunityList");
            }
            else
            {
                ViewData.Model = _opportunityRepository.GetOpportunities();
                return View("OpportunityList");
            }

        }
        [HttpGet]
        public IActionResult VolunteerDetails(int id)
        {
            ViewData.Model = _volunteerRepository.getVolunteer(id);
            return View();
        }
        [HttpGet]
        [Authorize]
        public IActionResult EditVolunteer(int id)
        {
            ViewData.Model = _volunteerRepository.getVolunteer(id);
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult SaveVolunteer(Volunteer volunteer)
        {
            _volunteerRepository.SaveVolunteer(volunteer);
            return RedirectToAction("VolunteerList");
        }
        [Authorize]
        public IActionResult DeleteVolunteer(int id)
        {
            _volunteerRepository.DeleteVolunteer(id);
            return RedirectToAction("VolunteerList");
        }
        [HttpPost]
        [Authorize]
        public IActionResult CreateVolunteer(Volunteer volunteer)
        {
            _volunteerRepository.createVolunteer(volunteer);
            return RedirectToAction("VolunteerList");
        }
        [Authorize]
        public IActionResult CreateVolunteer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search(string SearchString)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                ViewData.Model = _volunteerRepository.Search(SearchString);
                return View("VolunteerList");
            }
            else
            {
                ViewData.Model = _volunteerRepository.getVolunteers();
                return View("VolunteerList");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}