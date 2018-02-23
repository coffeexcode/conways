using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The snacker pattern
    /// Size: 11x20
    /// Period 9 oscillator
    /// </summary>
    public class Snacker : Oscillator
    {

        /// <summary>
        /// Create a new snacker pattern
        /// </summary>
        public Snacker() : base(11, 20, 11, 20) { }

        /// <summary>
        /// Build the snacker pattern
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 0] = true;
            Cells[0, 1] = true;
            Cells[0, 18] = true;
            Cells[0, 19] = true;
            Cells[1, 1] = true;
            Cells[1, 18] = true;
            Cells[2, 1] = true;
            Cells[2, 3] = true;
            Cells[2, 16] = true;
            Cells[2, 18] = true;
            Cells[3, 2] = true;
            Cells[3, 3] = true;
            Cells[3, 16] = true;
            Cells[3, 17] = true;
            Cells[4, 7] = true;
            Cells[4, 12] = true;
            Cells[5, 5] = true;
            Cells[5, 6] = true;
            Cells[5, 8] = true;
            Cells[5, 9] = true;
            Cells[5, 10] = true;
            Cells[5, 11] = true;
            Cells[5, 13] = true;
            Cells[5, 14] = true;
            Cells[6, 7] = true;
            Cells[6, 12] = true;
            Cells[7, 2] = true;
            Cells[7, 3] = true;
            Cells[7, 16] = true;
            Cells[7, 17] = true;
            Cells[8, 1] = true;
            Cells[8, 3] = true;
            Cells[8, 16] = true;
            Cells[8, 18] = true;
            Cells[9, 1] = true;
            Cells[9, 18] = true;
            Cells[10, 0] = true;
            Cells[10, 1] = true;
            Cells[10, 18] = true;
            Cells[10, 19] = true;
        }
    }
}
