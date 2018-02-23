using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    /// <summary>
    /// The beehive pattern:
    /// Size: 3x4
    /// </summary>
    public class Beehive : Pattern
    {
        /// <summary>
        /// Create the beehive pattern.
        /// </summary>
        public Beehive() : base(3, 4) { }

        /// <summary>
        /// Build the beehive pattern
        /// </summary>
        /// <returns>A 2D array of cells containing the beehive pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 1] = true;
            cells[0, 2] = true;
            cells[1, 0] = true;
            cells[1, 3] = true;
            cells[2, 1] = true;
            cells[2, 2] = true;

            return cells;
        }
    }
}
