using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Repositories;

namespace gregslist_backend.Services
{
    public class CarsService
    {
        private readonly CarsRepository _repo;

        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Car> Get()
        {
            return _repo.Get();
        }

        internal Car Create(Car newCar)
        {
            return _repo.Create(newCar);
        }

        internal Car Delete(int id)
        {
            Car exists = Get(id);
            _repo.Delete(id);
            return exists;
        }

        private Car Get(int id)
        {
            Car exists = _repo.GetById(id);
            if(exists == null){
                throw new Exception("Invalid Keep Id");
            }
            return exists;

        }
    }
}