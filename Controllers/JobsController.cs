using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class JobsController: ControllerBase
    {
        private readonly JobsService _js;
        public JobsController(JobsService js)
        {
            _js = js;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
                return Ok(_js.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
                [HttpPost]
        public ActionResult<Job> Post([FromBody] Job newJob)
        {
            try
            {
                return Ok(_js.Create(newJob));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Job> Delete(int id)
        {
            try
            {
                return Ok(_js.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}