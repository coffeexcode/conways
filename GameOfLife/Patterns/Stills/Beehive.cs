using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    /// <summary>
    /// The beehive pattern.
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
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[0, 2] = true;
            Cells[1, 0] = true;
            Cells[1, 3] = true;
            Cells[2, 1] = true;
            Cells[2, 2] = true;
        }
    }
}
