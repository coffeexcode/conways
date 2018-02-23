using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Movers
{
    public class BlinkerShip : Pattern
    {

        public BlinkerShip() : base(17, 31) { }
        protected override void Build()
        {
            // Generated with GameOfLifePatternParser
            // See project: https://github.com/beebopbrown/GameOfLifePatternParser
            Cells[0, 12] = true;
            Cells[0, 15] = true;
            Cells[1, 11] = true;
            Cells[2, 11] = true;
            Cells[2, 15] = true;
            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 11] = true;
            Cells[3, 12] = true;
            Cells[3, 13] = true;
            Cells[3, 14] = true;
            Cells[4, 2] = true;
            Cells[4, 3] = true;
            Cells[4, 4] = true;
            Cells[4, 5] = true;
            Cells[5, 1] = true;
            Cells[5, 2] = true;
            Cells[5, 4] = true;
            Cells[5, 5] = true;
            Cells[6, 2] = true;
            Cells[6, 3] = true;
            Cells[6, 9] = true;
            Cells[6, 10] = true;
            Cells[6, 12] = true;
            Cells[6, 13] = true;
            Cells[6, 14] = true;
            Cells[7, 8] = true;
            Cells[7, 14] = true;
            Cells[7, 15] = true;
            Cells[7, 23] = true;
            Cells[7, 28] = true;
            Cells[7, 29] = true;
            Cells[7, 30] = true;
            Cells[8, 7] = true;
            Cells[8, 8] = true;
            Cells[8, 16] = true;
            Cells[8, 23] = true;
            Cells[8, 28] = true;
            Cells[8, 30] = true;
            Cells[9, 8] = true;
            Cells[9, 14] = true;
            Cells[9, 15] = true;
            Cells[9, 23] = true;
            Cells[9, 28] = true;
            Cells[9, 29] = true;
            Cells[9, 30] = true;
            Cells[10, 2] = true;
            Cells[10, 3] = true;
            Cells[10, 9] = true;
            Cells[10, 10] = true;
            Cells[10, 12] = true;
            Cells[10, 13] = true;
            Cells[10, 14] = true;
            Cells[11, 1] = true;
            Cells[11, 2] = true;
            Cells[11, 4] = true;
            Cells[11, 5] = true;
            Cells[12, 2] = true;
            Cells[12, 3] = true;
            Cells[12, 4] = true;
            Cells[12, 5] = true;
            Cells[13, 3] = true;
            Cells[13, 4] = true;
            Cells[13, 11] = true;
            Cells[13, 12] = true;
            Cells[13, 13] = true;
            Cells[13, 14] = true;
            Cells[14, 11] = true;
            Cells[14, 15] = true;
            Cells[15, 11] = true;
            Cells[16, 12] = true;
            Cells[16, 15] = true;
        }
    }
}
