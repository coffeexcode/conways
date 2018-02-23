using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The boss pattern.
    /// Size: 14x12
    /// Period 5 oscillator
    /// </summary>
    public class Boss : Oscillator
    {
        /// <summary>
        /// Create a new boss pattern.
        /// </summary>
        public Boss() : base(14, 12, 14, 12) { }

        /// <summary>
        /// Build the boss pattern.
        /// </summary>
        protected override void Build()
        { 
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 6] = true;
            Cells[1, 5] = true;
            Cells[1, 7] = true;
            Cells[2, 5] = true;
            Cells[2, 7] = true;
            Cells[3, 4] = true;
            Cells[3, 5] = true;
            Cells[3, 7] = true;
            Cells[3, 8] = true;
            Cells[4, 3] = true;
            Cells[4, 9] = true;
            Cells[5, 2] = true;
            Cells[5, 4] = true;
            Cells[5, 6] = true;
            Cells[5, 8] = true;
            Cells[5, 10] = true;
            Cells[6, 2] = true;
            Cells[6, 4] = true;
            Cells[6, 8] = true;
            Cells[6, 10] = true;
            Cells[7, 1] = true;
            Cells[7, 2] = true;
            Cells[7, 4] = true;
            Cells[7, 8] = true;
            Cells[7, 10] = true;
            Cells[7, 11] = true;
            Cells[8, 1] = true;
            Cells[8, 4] = true;
            Cells[8, 6] = true;
            Cells[8, 8] = true;
            Cells[8, 11] = true;
            Cells[9, 3] = true;
            Cells[9, 9] = true;
            Cells[10, 4] = true;
            Cells[10, 5] = true;
            Cells[10, 7] = true;
            Cells[10, 8] = true;
            Cells[11, 5] = true;
            Cells[11, 7] = true;
            Cells[12, 5] = true;
            Cells[12, 7] = true;
            Cells[13, 6] = true;
        }
    }
}
