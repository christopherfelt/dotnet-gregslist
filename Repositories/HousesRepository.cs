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

                internal House Create(House newHouse)
        {
            string sql = @"
            INSERT INTO houses
            (title, description, price, location, imgUrl)
            VALUES
            (@Title, @Description, @Price, @Location, @ImgUrl);
            SELECT LAST_INSERT_ID();
            ";
            newHouse.Id = _db.ExecuteScalar<int>(sql, newHouse);
            return newHouse;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM houses WHERE id = @Id";
            _db.Execute(sql, new { id });
        }

        internal House GetById(int id)
        {
            string sql = @"
                SELECT * FROM houses
                WHERE id = @id;";
            return _db.QueryFirstOrDefault<House>(sql, new { id });
        }

    }
}