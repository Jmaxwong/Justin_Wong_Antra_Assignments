using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JobsMongoDbService: IJobService
    {
        public List<JobResponseModel> GetAllJobs()
        {
            var jobs = new List<JobResponseModel>()
            {
                new JobResponseModel {Id =1, Title = ".NET Developer", Description = "Need to be good with C# and EF Core and .NET"},
                new JobResponseModel {Id =2, Title = "Software Net Developer", Description = "Need to be good with Typescript, C# and EF Core and .NET"},
                new JobResponseModel {Id =3, Title = "Java Developer", Description = "Need to be good with Java"},
                new JobResponseModel {Id =4, Title = "JavaScript Developer", Description = "Need to be good with JavaScript"}
            };
            return jobs;
        }

        public JobResponseModel GetJobById(int id)
        {
            return new JobResponseModel { Id = 4, Title = "JavaScript Developer", Description = "Need to be good with JavaScript" };
        }
    }
}
