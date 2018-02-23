using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Spaceships
{
    /// <summary>
    /// The lightweight spaceship pattern
    /// Size: 4x5
    /// </summary>
    public class LightweightSpaceship : Pattern
    {
        /// <summary>
        /// Create a new lightweight spaceship pattern.
        /// </summary>
        public LightweightSpaceship() : base(4, 5) { }

        /// <summary>
        /// Build a lightweight spaceship pattern.
        /// </summary>
        /// <returns>A 2D array of cells containg the lightweight spaceship pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 3] = true;
            cells[1, 4] = true;
            cells[2, 0] = true;
            cells[2, 4] = true;
            cells[3, 1] = true;
            cells[3, 2] = true;
            cells[3, 3] = true;
            cells[3, 4] = true;

            return cells;
        }
    }
}
