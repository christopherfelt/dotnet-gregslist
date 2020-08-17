using System.Collections.Generic;
using System.Data;
using Dapper;
using gregslist_backend.Models;

namespace gregslist_backend.Repositories
{
    public class CarsRepository
    {
        private readonly IDbConnection _db;
        public CarsRepository(IDbConnection db)
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