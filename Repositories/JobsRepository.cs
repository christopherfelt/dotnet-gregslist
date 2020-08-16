using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using gregslist_backend.Models;

namespace gregslist_backend.Repositories
{
    public class JobsRepository
    {
        private readonly IDbConnection _db;
        public JobsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Car> Get()
        {
            string sql = "select * from cars";
            return _db.Query<Car>(sql);
        }
    }
}