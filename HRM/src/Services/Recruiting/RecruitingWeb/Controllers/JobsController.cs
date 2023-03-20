using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;
        public JobsController(IJobService jobService) { 
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            //3 ways we can send data from controller/actionb method to view
            //1. ViewBag
            //2. ViewData
            //^^built-in

            //3. Strongly Typed Model Data ***most prefered way

            // return all the jobs so that candidates can apply to the job
        
            var jobs = await _jobService.GetAllJobs();
            return View(jobs);
        }

        //get the job detailed information
        [HttpGet] //this is an attribute
        public async Task<IActionResult> Details(int id)
        {
            //get job by id
            var job = await _jobService.GetJobById(id);

            return View(job);
        }

        // Authenticated and User should have role for creating new Job
        // HR/Manager
        [HttpPost]
        public IActionResult Create()
        {
            // take the information from the view and save to DB
            return View();
        }
    }
}
