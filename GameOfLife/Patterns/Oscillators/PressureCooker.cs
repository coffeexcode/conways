using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The pressure cooker pattern
    /// Size: 12x11
    /// Period 3 oscillator
    /// </summary>
    public class PressureCooker : Pattern
    {
        /// <summary>
        /// Create a new pressure cooker pattern
        /// </summary>
        public PressureCooker() : base(12, 11) { }

        /// <summary>
        /// Build the pressure cooker pattern
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 5] = true;
            Cells[1, 4] = true;
            Cells[1, 6] = true;
            Cells[2, 4] = true;
            Cells[2, 6] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 6] = true;
            Cells[3, 7] = true;
            Cells[4, 0] = true;
            Cells[4, 2] = true;
            Cells[4, 8] = true;
            Cells[4, 10] = true;
            Cells[5, 0] = true;
            Cells[5, 1] = true;
            Cells[5, 3] = true;
            Cells[5, 5] = true;
            Cells[5, 7] = true;
            Cells[5, 9] = true;
            Cells[5, 10] = true;
            Cells[6, 3] = true;
            Cells[6, 7] = true;
            Cells[7, 3] = true;
            Cells[7, 7] = true;
            Cells[8, 4] = true;
            Cells[8, 5] = true;
            Cells[8, 6] = true;
            Cells[10, 3] = true;
            Cells[10, 5] = true;
            Cells[10, 6] = true;
            Cells[11, 3] = true;
            Cells[11, 4] = true;
            Cells[11, 6] = true;

        }
    }
}
