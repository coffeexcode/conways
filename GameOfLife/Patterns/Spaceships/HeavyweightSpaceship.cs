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
        protected override void Build()
        {
            Cells[0, 5] = true;
            Cells[1, 6] = true;
            Cells[2, 0] = true;
            Cells[2, 6] = true;
            Cells[3, 1] = true;
            Cells[3, 2] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 5] = true;
            Cells[3, 6] = true;
        }
    }
}
