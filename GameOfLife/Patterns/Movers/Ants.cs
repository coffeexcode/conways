using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The ants pattern.
    /// Size: 5x40
    /// </summary>
    public class Ants : Pattern
    {
        /// <summary>
        /// Create an ants pattern.
        /// </summary>
        public Ants() : base(5, 40) { }

        /// <summary>
        /// Build the ants pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[0, 2] = true;
            Cells[0, 6] = true;
            Cells[0, 7] = true;
            Cells[0, 11] = true;
            Cells[0, 12] = true;
            Cells[0, 16] = true;
            Cells[0, 17] = true;
            Cells[0, 21] = true;
            Cells[0, 22] = true;
            Cells[0, 26] = true;
            Cells[0, 27] = true;
            Cells[0, 31] = true;
            Cells[0, 32] = true;
            Cells[0, 36] = true;
            Cells[0, 37] = true;
            Cells[1, 3] = true;
            Cells[1, 4] = true;
            Cells[1, 8] = true;
            Cells[1, 9] = true;
            Cells[1, 13] = true;
            Cells[1, 14] = true;
            Cells[1, 18] = true;
            Cells[1, 19] = true;
            Cells[1, 23] = true;
            Cells[1, 24] = true;
            Cells[1, 28] = true;
            Cells[1, 29] = true;
            Cells[1, 33] = true;
            Cells[1, 34] = true;
            Cells[1, 38] = true;
            Cells[1, 39] = true;
            Cells[2, 3] = true;
            Cells[2, 4] = true;
            Cells[2, 8] = true;
            Cells[2, 9] = true;
            Cells[2, 13] = true;
            Cells[2, 14] = true;
            Cells[2, 18] = true;
            Cells[2, 19] = true;
            Cells[2, 23] = true;
            Cells[2, 24] = true;
            Cells[2, 28] = true;
            Cells[2, 29] = true;
            Cells[2, 33] = true;
            Cells[2, 34] = true;
            Cells[2, 38] = true;
            Cells[2, 39] = true;
            Cells[3, 1] = true;
            Cells[3, 2] = true;
            Cells[3, 6] = true;
            Cells[3, 7] = true;
            Cells[3, 11] = true;
            Cells[3, 12] = true;
            Cells[3, 16] = true;
            Cells[3, 17] = true;
            Cells[3, 21] = true;
            Cells[3, 22] = true;
            Cells[3, 26] = true;
            Cells[3, 27] = true;
            Cells[3, 31] = true;
            Cells[3, 32] = true;
            Cells[3, 36] = true;
            Cells[3, 37] = true;
        }
    }
}
