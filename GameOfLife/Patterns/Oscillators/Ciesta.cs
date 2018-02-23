using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The ciesta pattern.
    /// Size: 12x16
    /// Period 5 oscillator
    /// </summary>
    public class Ciesta : Pattern
    {
        /// <summary>
        /// Create the ciesta pattern
        /// </summary>
        public Ciesta() : base(12, 16) { }

        /// <summary>
        /// Build the ciesta pattern
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 11] = true;
            Cells[0, 12] = true;
            Cells[1, 3] = true;
            Cells[1, 4] = true;
            Cells[1, 10] = true;
            Cells[1, 12] = true;
            Cells[2, 3] = true;
            Cells[2, 5] = true;
            Cells[2, 10] = true;
            Cells[3, 5] = true;
            Cells[3, 9] = true;
            Cells[3, 10] = true;
            Cells[3, 12] = true;
            Cells[4, 3] = true;
            Cells[4, 5] = true;
            Cells[4, 6] = true;
            Cells[4, 12] = true;
            Cells[4, 13] = true;
            Cells[4, 14] = true;
            Cells[5, 1] = true;
            Cells[5, 2] = true;
            Cells[5, 3] = true;
            Cells[5, 9] = true;
            Cells[5, 11] = true;
            Cells[5, 15] = true;
            Cells[6, 0] = true;
            Cells[6, 4] = true;
            Cells[6, 6] = true;
            Cells[6, 12] = true;
            Cells[6, 13] = true;
            Cells[6, 14] = true;
            Cells[7, 1] = true;
            Cells[7, 2] = true;
            Cells[7, 3] = true;
            Cells[7, 9] = true;
            Cells[7, 10] = true;
            Cells[7, 12] = true;
            Cells[8, 3] = true;
            Cells[8, 5] = true;
            Cells[8, 6] = true;
            Cells[8, 10] = true;
            Cells[9, 5] = true;
            Cells[9, 10] = true;
            Cells[9, 12] = true;
            Cells[10, 3] = true;
            Cells[10, 5] = true;
            Cells[10, 11] = true;
            Cells[10, 12] = true;
            Cells[11, 3] = true;
            Cells[11, 4] = true;
        }
    }
}
