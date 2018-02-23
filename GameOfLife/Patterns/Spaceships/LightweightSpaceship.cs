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
        protected override void Build()
        {
            Cells[0, 3] = true;
            Cells[1, 4] = true;
            Cells[2, 0] = true;
            Cells[2, 4] = true;
            Cells[3, 1] = true;
            Cells[3, 2] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
        }
    }
}
