using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Satelite
    {
        public Satelite()
        {
            Message = new List<string>();
        }
        /// <summary>
        /// Name satellite
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Distance 
        /// </summary>
        public decimal Distance { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public List<string> Message { get; set; }
    }
}
