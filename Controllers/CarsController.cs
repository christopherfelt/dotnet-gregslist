using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly CarsService _cs;
        public CarsController(CarsService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                return Ok(_cs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car newCar)
        {
            try
            {
                return Ok(_cs.Create(newCar));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(int id)
        {
            try
            {
                return Ok(_cs.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    
    }
}