using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class SubmissionsController : Controller
    {
        private readonly ISubmissionService _submissionService;
        private readonly IJobService _jobService;
        public SubmissionsController(ISubmissionService submissionService)
        {
            _submissionService = submissionService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var submissions = await _submissionService.GetAllSubmissions();
            return View(submissions);
        }

        //get the job detailed information
        [HttpGet] //this is an attribute
        public async Task<IActionResult> Details(int id)
        {
            //get job by id
            var submission = await _submissionService.GetSubmissionById(id);
            return View(submission);

        }

        [HttpGet]
        public IActionResult Create(int id)
        {

            //await _jobService.GetJobById(id);
            // take the information from the view and save to DB
            return View();
            
        }


        [HttpPost]
        public async Task<IActionResult> Create(SubmissionRequestModel model)
        {
            /*
            if (!ModelState.IsValid)
            {
                return View(6);
            }

            //if email exists in submissions

            await _submissionService.AddSubmission(model);
            return RedirectToAction("Index");
            */
            return View();

        }
    }
}
