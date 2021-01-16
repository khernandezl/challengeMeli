using BLL;
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
    public class Nivel1Controller : ControllerBase
    {
        private readonly Nivel1 nivel1;

        public Nivel1Controller(Nivel1 nivel1)
        {
            this.nivel1 = nivel1;
        }

        /// <summary>
        /// GetLocation
        /// </summary>
        /// <param name="distances">Distancia al emisor tal cual se recibe en cada satélite</param>
        /// <returns>Las coordenadas ‘x’ e ‘y’ del emisor del mensaje</returns>
        [HttpPost("GetLocation", Name = "GetLocation")]
        public ActionResult GetLocation(decimal distances)
        {
            return Ok(nivel1.GetLocation(distances));
        }

        /// <summary>
        /// GetMessage
        /// </summary>
        /// <param name="messages">el mensaje tal cual es recibido en cada satélite</param>
        /// <returns>el mensaje tal cual lo genera el emisor del mensaje</returns>
        [HttpPost("GetMessage", Name = "GetMessage")]
        public ActionResult GetMessage(List<string> messages)
        {
            return Ok(nivel1.GetMessage(messages));
        }
    }
}
