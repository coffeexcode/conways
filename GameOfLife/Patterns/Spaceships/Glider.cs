using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Spaceships
{
    /// <summary>
    /// The glider pattern.
    /// Size: 3x3
    /// </summary>
    public class Glider : Pattern
    {
        /// <summary>
        /// Create a new glider pattern.
        /// </summary>
        public Glider() : base(3, 3) { }

        /// <summary>
        /// Build the glider pattern.
        /// </summary>
        /// <returns>A 2D array of cells containing the glider pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 1] = true;
            cells[1, 2] = true;
            cells[2, 0] = true;
            cells[2, 1] = true;
            cells[2, 2] = true;

            return cells;
        }
    }
}
