using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Generators
{
    /// <summary>
    /// The gosper gun pattern.
    /// Size: 
    /// </summary>
    public class GosperGun : Pattern
    {

        /// <summary>
        /// Create a new gosper gun pattern.
        /// </summary>
        public GosperGun() : base(9, 36) { }

        /// <summary>
        /// Build the gosper gun pattern.
        /// </summary>
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 25] = true;
            Cells[1, 22] = true;
            Cells[1, 23] = true;
            Cells[1, 24] = true;
            Cells[1, 25] = true;
            Cells[1, 30] = true;
            Cells[2, 13] = true;
            Cells[2, 21] = true;
            Cells[2, 22] = true;
            Cells[2, 23] = true;
            Cells[2, 24] = true;
            Cells[2, 30] = true;
            Cells[3, 12] = true;
            Cells[3, 14] = true;
            Cells[3, 21] = true;
            Cells[3, 24] = true;
            Cells[3, 34] = true;
            Cells[3, 35] = true;
            Cells[4, 11] = true;
            Cells[4, 15] = true;
            Cells[4, 16] = true;
            Cells[4, 21] = true;
            Cells[4, 22] = true;
            Cells[4, 23] = true;
            Cells[4, 24] = true;
            Cells[4, 34] = true;
            Cells[4, 35] = true;
            Cells[5, 0] = true;
            Cells[5, 1] = true;
            Cells[5, 11] = true;
            Cells[5, 15] = true;
            Cells[5, 16] = true;
            Cells[5, 22] = true;
            Cells[5, 23] = true;
            Cells[5, 24] = true;
            Cells[5, 25] = true;
            Cells[6, 0] = true;
            Cells[6, 1] = true;
            Cells[6, 11] = true;
            Cells[6, 15] = true;
            Cells[6, 16] = true;
            Cells[6, 25] = true;
            Cells[7, 12] = true;
            Cells[7, 14] = true;
            Cells[8, 13] = true;
        }
    }
}
