using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Spaceships
{
    /// <summary>
    /// The heavyweight spaceship pattern.
    /// Size: 4x7
    /// </summary>
    public class HeavyweightSpaceship : Pattern
    {
        /// <summary>
        /// Create a heavyweight spaceship pattern.
        /// </summary>
        public HeavyweightSpaceship() : base(4, 7) { }

        /// <summary>
        /// Builds a heavyweight spaceship pattern.
        /// </summary>
        /// <returns>A 2D array of cells containing the heavyweight spaceship pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 5] = true;
            cells[1, 6] = true;
            cells[2, 0] = true;
            cells[2, 6] = true;
            cells[3, 1] = true;
            cells[3, 2] = true;
            cells[3, 3] = true;
            cells[3, 4] = true;
            cells[3, 5] = true;
            cells[3, 6] = true;

            return cells;
        }
    }
}
