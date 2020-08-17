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
    }
}