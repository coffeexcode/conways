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
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[1, 2] = true;
            Cells[2, 0] = true;
            Cells[2, 1] = true;
            Cells[2, 2] = true;
        }
    }
}
