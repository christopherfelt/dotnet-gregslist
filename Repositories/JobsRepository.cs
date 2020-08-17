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

        internal IEnumerable<Job> Get()
        {
            string sql = "select * from jobs";
            return _db.Query<Job>(sql);
        }

        internal Job Create(Job newJob)
        {
            string sql = @"
            INSERT INTO jobs
            (title, description, hours, rate, imgUrl)
            VALUES
            (@Title, @Description, @Hours, @Rate, @ImgUrl);
            SELECT LAST_INSERT_ID();
            ";
            newJob.Id = _db.ExecuteScalar<int>(sql, newJob);
            return newJob;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM jobs WHERE id = @Id";
            _db.Execute(sql, new { id });
        }

        internal Job GetById(int id)
        {
            string sql = @"
                SELECT * FROM jobs
                WHERE id = @id;";
            return _db.QueryFirstOrDefault<Job>(sql, new { id });
        }
    }
}