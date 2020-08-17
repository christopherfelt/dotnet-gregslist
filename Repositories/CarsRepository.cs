using System;
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

        internal Car Create(Car newCar)
        {
            string sql = @"
            INSERT INTO cars
            (title, description, price, imgUrl)
            VALUES
            (@Title, @Description, @Price, @ImgUrl);
            SELECT LAST_INSERT_ID();
            ";
            newCar.Id = _db.ExecuteScalar<int>(sql, newCar);
            return newCar;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM cars WHERE id = @Id";
            _db.Execute(sql, new { id });
        }

        internal Car GetById(int id)
        {
            string sql = @"
                SELECT * FROM cars
                WHERE id = @id;";
            return _db.QueryFirstOrDefault<Car>(sql, new { id });
        }
    }
}