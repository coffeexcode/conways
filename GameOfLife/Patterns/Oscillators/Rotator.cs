using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The rotator pattern.
    /// Size: 14x14
    /// Period 8 oscillator
    /// </summary>
    public class Rotator : Oscillator
    {

        /// <summary>
        /// Create a new rotator pattern
        /// </summary>
        public Rotator() : base(14, 14, 14, 14) { }

        /// <summary>
        /// Build the rotator pattern
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 1] = true;
            Cells[1, 1] = true;
            Cells[1, 2] = true;
            Cells[1, 3] = true;
            Cells[1, 12] = true;
            Cells[1, 13] = true;
            Cells[2, 4] = true;
            Cells[2, 12] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 10] = true;
            Cells[3, 12] = true;
            Cells[4, 10] = true;
            Cells[4, 11] = true;
            Cells[6, 5] = true;
            Cells[6, 6] = true;
            Cells[6, 7] = true;
            Cells[7, 5] = true;
            Cells[7, 8] = true;
            Cells[8, 5] = true;
            Cells[9, 2] = true;
            Cells[9, 3] = true;
            Cells[9, 6] = true;
            Cells[9, 10] = true;
            Cells[10, 1] = true;
            Cells[10, 3] = true;
            Cells[10, 10] = true;
            Cells[11, 1] = true;
            Cells[11, 9] = true;
            Cells[12, 0] = true;
            Cells[12, 1] = true;
            Cells[12, 10] = true;
            Cells[12, 11] = true;
            Cells[12, 12] = true;
            Cells[13, 12] = true;
        }
    }
}
