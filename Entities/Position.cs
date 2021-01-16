using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Position
    {
        public Position(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Position x
        /// </summary>
        public decimal X { get; set; }
        /// <summary>
        /// Position y
        /// </summary>
        public decimal Y { get; set; }
    }
}
