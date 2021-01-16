using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Nivel1
    {
        /// <summary>
        /// GetLocation
        /// </summary>
        /// <param name="distances">Distancia al emisor tal cual se recibe en cada satélite</param>
        /// <returns>Las coordenadas ‘x’ e ‘y’ del emisor del mensaje</returns>
        public Position GetLocation(decimal distances)
        {
            Position position = new Position(1, 0);
            return position;
        }

        /// <summary>
        /// GetMessage
        /// </summary>
        /// <param name="messages">el mensaje tal cual es recibido en cada satélite</param>
        /// <returns>el mensaje tal cual lo genera el emisor del mensaje</returns>
        public string GetMessage(List<string> messages)
        {
            string msj = string.Empty;
            messages.ForEach(_ => msj += string.Concat(_, " "));
            return msj;
        }
    }
}
