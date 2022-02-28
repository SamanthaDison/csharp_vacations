
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using csharp_vacations.Models;
using csharp_vacations.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace csharp_vacations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CruisesController : ControllerBase
    {
        private readonly CruisesService _cs;
        public CruisesController(CruisesService cs)
        {
            _cs = cs;
        }

        [HttpGet]
        public ActionResult<List<Cruise>> GetAll()
        {
            try
            {
                return Ok(_cs.GetAll());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Cruise> GetById(int id)
        {
            try
            {
                Cruise foundCruise = _cs.GetById(id);
                return Ok(foundCruise);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Cruise> Create([FromBody] Cruise newData)
        {
            try
            {
                Cruise newCruise = _cs.Create(newData);
                return Ok(newData);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult<Cruise>> Edit([FromBody] Cruise cruise, int id)
        {
            try
            {
                Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
                cruise.Id = id;
                return Ok(_cs.Edit(cruise, userInfo.Id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            try
            {
                Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
                _cs.Delete(id, userInfo.Id);
                return Ok("Cruise was deleted");

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}