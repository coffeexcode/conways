using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The sombreros pattern.
    /// Size: 11x18
    /// Period 6 oscillator
    /// </summary>
    public class Sombreros : Pattern
    {

        public Sombreros() : base(11, 18) { }

        /// <summary>
        /// Build the sombreros pattern.
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 3] = true;
            Cells[0, 4] = true;
            Cells[0, 13] = true;
            Cells[0, 14] = true;
            Cells[1, 3] = true;
            Cells[1, 5] = true;
            Cells[1, 12] = true;
            Cells[1, 14] = true;
            Cells[2, 5] = true;
            Cells[2, 12] = true;
            Cells[3, 3] = true;
            Cells[3, 5] = true;
            Cells[3, 6] = true;
            Cells[3, 11] = true;
            Cells[3, 12] = true;
            Cells[3, 14] = true;
            Cells[4, 1] = true;
            Cells[4, 2] = true;
            Cells[4, 3] = true;
            Cells[4, 14] = true;
            Cells[4, 15] = true;
            Cells[4, 16] = true;
            Cells[5, 0] = true;
            Cells[5, 4] = true;
            Cells[5, 6] = true;
            Cells[5, 11] = true;
            Cells[5, 13] = true;
            Cells[5, 17] = true;
            Cells[6, 1] = true;
            Cells[6, 2] = true;
            Cells[6, 3] = true;
            Cells[6, 14] = true;
            Cells[6, 15] = true;
            Cells[6, 16] = true;
            Cells[7, 3] = true;
            Cells[7, 5] = true;
            Cells[7, 6] = true;
            Cells[7, 11] = true;
            Cells[7, 12] = true;
            Cells[7, 14] = true;
            Cells[8, 5] = true;
            Cells[8, 12] = true;
            Cells[9, 3] = true;
            Cells[9, 5] = true;
            Cells[9, 12] = true;
            Cells[9, 14] = true;
            Cells[10, 3] = true;
            Cells[10, 4] = true;
            Cells[10, 13] = true;
            Cells[10, 14] = true;
        }
    }
}
