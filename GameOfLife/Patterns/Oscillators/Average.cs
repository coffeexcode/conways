using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Movers
{
    /// <summary>
    /// The average pattern.
    /// Size: 13x12
    /// Period 5 oscillator.
    /// </summary>
    public class Average : Oscillator
    {

        /// <summary>
        /// Create the average pattern.
        /// </summary>
        public Average() : base(13, 12, 13, 12) { }

        /// <summary>
        /// Build the average pattern.
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 6] = true;
            Cells[1, 5] = true;
            Cells[1, 7] = true;
            Cells[2, 6] = true;
            Cells[4, 4] = true;
            Cells[4, 5] = true;
            Cells[4, 6] = true;
            Cells[4, 7] = true;
            Cells[4, 8] = true;
            Cells[5, 3] = true;
            Cells[5, 6] = true;
            Cells[5, 9] = true;
            Cells[6, 2] = true;
            Cells[6, 4] = true;
            Cells[6, 5] = true;
            Cells[6, 7] = true;
            Cells[6, 8] = true;
            Cells[6, 10] = true;
            Cells[7, 2] = true;
            Cells[7, 4] = true;
            Cells[7, 8] = true;
            Cells[7, 10] = true;
            Cells[8, 1] = true;
            Cells[8, 2] = true;
            Cells[8, 4] = true;
            Cells[8, 8] = true;
            Cells[8, 10] = true;
            Cells[8, 11] = true;
            Cells[9, 1] = true;
            Cells[9, 4] = true;
            Cells[9, 6] = true;
            Cells[9, 8] = true;
            Cells[9, 11] = true;
            Cells[10, 3] = true;
            Cells[10, 9] = true;
            Cells[11, 4] = true;
            Cells[11, 5] = true;
            Cells[11, 6] = true;
            Cells[11, 7] = true;
            Cells[11, 8] = true;
            Cells[12, 6] = true;
        }
    }
}
