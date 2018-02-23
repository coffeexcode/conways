using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Spaceships
{
    /// <summary>
    /// The middleweight spaceship pattern
    /// Size: 4x6
    /// </summary>
    public class MiddleweightSpaceship : Pattern
    {
        /// <summary>
        /// Create a new middle weight spaceship pattern
        /// </summary>
        public MiddleweightSpaceship() : base(4, 6) { }

        /// <summary>
        /// Build the middleweight spaceship pattern.
        /// </summary>
        /// <returns>A 2D array of cells containing the middleweight spaceship pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 4] = true;
            cells[1, 5] = true;
            cells[2, 0] = true;
            cells[2, 5] = true;
            cells[3, 1] = true;
            cells[3, 2] = true;
            cells[3, 3] = true;
            cells[3, 4] = true;
            cells[3, 5] = true;

            return cells;
        }
    }
}
