using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISubmissionRepository _submissionRepository;
        public SubmissionService(ISubmissionRepository submissionRepository)
        {
            _submissionRepository = submissionRepository;
        }

        public async Task<List<SubmissionResponseModel>> GetAllSubmissions()
        {
            var submissions = await _submissionRepository.GetAllSubmissions();
            var submissionResponseModel = new List<SubmissionResponseModel>();
            foreach (var sub in submissions)
            {
                submissionResponseModel.Add(new SubmissionResponseModel
                {

                    //TODO
/*                    Id = sub.Id,
                    JobCode = sub.JobCode,
                    Title = sub.Title,
                    Description = sub.Description,
                    StartDate = sub.StartDate.GetValueOrDefault(),
                    NumberOfPositions = sub.NumberOfPositions,
                    IsActive = sub.IsActive,
                    CreatedOn = sub.CreatedOn.GetValueOrDefault()*/
                });


            }
            return submissionResponseModel;
        }

        public async Task<SubmissionResponseModel> GetSubmissionById(int id)
        {
            var submission = await _submissionRepository.GetSubmissionById(id);
            var submissionResponseModel = new SubmissionResponseModel
            {
/*                Id = job.Id,
                JobCode = job.JobCode,
                Title = job.Title,
                Description = job.Description,
                StartDate = job.StartDate.GetValueOrDefault(),
                NumberOfPositions = job.NumberOfPositions,
                IsActive = job.IsActive,
                CreatedOn = job.CreatedOn.GetValueOrDefault()*/
            };
            return submissionResponseModel;
        }
        public async Task<int> AddSubmission(SubmissionRequestModel model)
        {
            var candidateEntity = new Candidate
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                CreatedOn = DateTime.Now,
            };
            //TODO: MAKE NEW CANDIDATE SERVICE AND REPO

            var submissionEntity = new Submission
            {
                CandidateId = candidateEntity.Id,

/*                Title = model.Title,
                Description = model.Description,

                StartDate = model.StartDate,
                CreatedOn = DateTime.UtcNow,
                NumberOfPositions = model.NumberOfPositions,
                JobStatusLookupId = 1*/
            };
            var submission = await _submissionRepository.AddAsync(submissionEntity);
            return submission.Id;
        }

    }

}
