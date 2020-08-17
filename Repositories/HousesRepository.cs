using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using gregslist_backend.Models;

namespace gregslist_backend.Repositories
{
    public class HousesRepository
    {
        private readonly IDbConnection _db;
        public HousesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<House> Get()
        {
            string sql = "select * from Houses";
            return _db.Query<House>(sql);
        }
    }
}