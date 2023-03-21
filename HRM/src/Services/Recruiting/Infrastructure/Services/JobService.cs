using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository) { 
            _jobRepository= jobRepository;
        }

        public async Task<List<JobResponseModel>> GetAllJobs()
        {
            var jobs = await _jobRepository.GetAllJobs();
            var jobsResponseModel = new List<JobResponseModel>();
            foreach (var job in jobs)
            {
                jobsResponseModel.Add(new JobResponseModel
                {
                    Id = job.Id,
                    JobCode= job.JobCode,
                    Title = job.Title,
                    Description = job.Description, 
                    StartDate = job.StartDate.GetValueOrDefault(), 
                    NumberOfPositions=job.NumberOfPositions,
                    IsActive = job.IsActive,
                    CreatedOn = job.CreatedOn.GetValueOrDefault()
                });

                
            }
            return jobsResponseModel;
        }

        public async Task<JobResponseModel> GetJobById(int id)
        {
            var job = await _jobRepository.GetJobById(id);
            var jobResponseModel = new JobResponseModel
            {
                Id = job.Id,
                JobCode = job.JobCode,
                Title = job.Title,
                Description = job.Description,
                StartDate = job.StartDate.GetValueOrDefault(),
                NumberOfPositions = job.NumberOfPositions,
                IsActive = job.IsActive,
                CreatedOn = job.CreatedOn.GetValueOrDefault()
            };
            return jobResponseModel;
        }
        public async Task<int> AddJob(JobRequestModel model)
        {
            var jobEntity = new Job
            {
                Title = model.Title,
                Description = model.Description,
                JobCode = Guid.NewGuid(),
                StartDate = model.StartDate,
                CreatedOn = DateTime.UtcNow,
                NumberOfPositions = model.NumberOfPositions,
                JobStatusLookupId = 1
            };  
            var job = await _jobRepository.AddAsync(jobEntity);
            return job.Id;
        }
    }
}
