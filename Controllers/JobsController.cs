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
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(_js.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

    }
}