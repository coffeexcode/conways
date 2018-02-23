using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The boat pattern:
    /// Size: 3x3
    /// </summary>
    public class Boat : Pattern
    {
        /// <summary>
        /// Create the boat pattern.
        /// </summary>
        public Boat() : base(3, 3) { }


        /// <summary>
        /// Build the boat pattern
        /// </summary>
        /// <returns>A 2D array of cells containing the boat pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[3, 3];

            cells[0, 0] = true;
            cells[0, 1] = true;
            cells[1, 0] = true;
            cells[1, 2] = true;
            cells[2, 1] = true;

            return cells; 
        }
    }
}
