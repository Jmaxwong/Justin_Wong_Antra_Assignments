using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // return all the jobs so that candidates can apply to the job
            return View();
        }

        //get the job detailed information
        [HttpGet] //this is an attribute
        public IActionResult Details(int id)
        {
            return View();
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
