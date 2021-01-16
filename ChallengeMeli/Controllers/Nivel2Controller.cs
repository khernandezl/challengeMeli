using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeMeli.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Nivel2Controller : ControllerBase
    {
        [HttpPost("TopSecret", Name = "TopSecret")]
        public ActionResult<Response> TopSecret(List<Satelite> satelites)
        {
            return Ok(new Response());
        }

        [HttpPost("Topsecret_split/{satellite_name}", Name = "Topsecret_split")]
        public ActionResult Topsecret_split(string satellite_name, [FromBody] Response_split response_Split)
        {

            return Ok(new { distance = 100, message = "Este es un mensaje" });
        }

        [HttpGet("Topsecret_split/{satellite_name}", Name = "Topsecret_split")]
        public ActionResult Topsecret_split_get(string satellite_name, [FromBody] Response_split response_Split)
        {
            return Ok(new { distance = 100, Position = new Position(1, 2) });
        }
    }
}
