using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Repositories;

namespace gregslist_backend.Services
{
    public class JobsService
    {
        private readonly JobsRepository _repo;
        public JobsService(JobsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Job> Get()
        {
            return _repo.Get();
        }
        internal Job Create(Job newJob)
        {
            return _repo.Create(newJob);
        }

        internal Job Delete(int id)
        {
            Job exists = Get(id);
            _repo.Delete(id);
            return exists;
        }

        private Job Get(int id)
        {
            Job exists = _repo.GetById(id);
            if(exists == null){
                throw new Exception("Invalid Keep Id");
            }
            return exists;

        }
    }
}