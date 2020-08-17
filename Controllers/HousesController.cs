using System;
using System.Collections.Generic;
using gregslist_backend.Models;
using gregslist_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HousesController: ControllerBase
    {
        private readonly HousesService _hs;
        public HousesController(HousesService hs)
        {
            _hs = hs;
        }


        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            try
            {
                return Ok(_hs.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

                [HttpPost]
        public ActionResult<House> Post([FromBody] House newHouse)
        {
            try
            {
                return Ok(_hs.Create(newHouse));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<House> Delete(int id)
        {
            try
            {
                return Ok(_hs.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}