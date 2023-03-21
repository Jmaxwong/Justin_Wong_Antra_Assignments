using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Recruiting.API.Controllers
{
    //attribute routing
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobsService;

        public JobsController(IJobService jobsService)
        {
            _jobsService = jobsService;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _jobsService.GetAllJobs();
            if (!jobs.Any())
            {
                // no jobs exists, then return 404
                return NotFound(new {error = " No open jobs found please try later"});
            }

            // F5 -> Debugging, put breakpoints
            // CTrl+F5 -> start without debugging
            // F10 -> next line
            // F11 Step into
            //return json object
            //serialization C# objescts into JSON Objects using System.Text

            return Ok(jobs);
        }
        [HttpGet]
        [Route("{id:int}" , Name= "GetJobDetails")]
        public async Task<IActionResult> GetJobDetails(int id)
        {   
            var job = await _jobsService.GetJobById(id);
            if (job == null)
            {
                return NotFound(new { errorMessage = "No Job found for this id" });
            }
            return Ok(job);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(JobRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var job = await _jobsService.AddJob(model);
            return CreatedAtAction("GetJobDetails", new { controller = "Job", id = job }, "Job Created");
        }

    }
}
