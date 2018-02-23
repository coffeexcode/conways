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
        protected override void Build()
        {
            Cells[0, 4] = true;
            Cells[1, 5] = true;
            Cells[2, 0] = true;
            Cells[2, 5] = true;
            Cells[3, 1] = true;
            Cells[3, 2] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 5] = true;
        }
    }
}
