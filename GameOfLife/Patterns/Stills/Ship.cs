using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The ship pattern.
    /// Size: 3x3
    /// </summary>
    public class Ship : Pattern
    {

        /// <summary>
        /// Creat a ship pattern.
        /// </summary>
        public Ship() : base(3, 3) { }

        /// <summary>
        /// Build the ship pattern.
        /// </summary>
        protected override void Build()
        {
            var boat = new Boat();

            PatternBuilder.Place(boat, Cells, 0, 0);
            Cells[0, 0] = true;
        }
    }
}
