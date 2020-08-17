using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Repositories;

namespace gregslist_backend.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;
        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<House> Get()
        {
            return _repo.Get();
        }

        internal House Create(House newHouse)
        {
            return _repo.Create(newHouse);
        }

        internal House Delete(int id)
        {
            House exists = Get(id);
            _repo.Delete(id);
            return exists;
        }

        private House Get(int id)
        {
            House exists = _repo.GetById(id);
            if(exists == null){
                throw new Exception("Invalid Keep Id");
            }
            return exists;

        }
    }
}