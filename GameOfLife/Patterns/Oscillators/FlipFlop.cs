using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The flip flop pattern.
    /// Size: 6x6
    /// Period 8 oscillator.
    /// </summary>
    public class FlipFlop : Oscillator
    {

        /// <summary>
        /// Create a flip flop pattern.
        /// </summary>
        public FlipFlop() : base(6, 6, 6, 6) { }

        /// <summary>
        /// Build the flip flop pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 0] = true;
            Cells[0, 1] = true;
            Cells[0, 2] = true;
            Cells[1, 0] = true;
            Cells[1, 1] = true;
            Cells[1, 2] = true;
            Cells[2, 0] = true;
            Cells[2, 1] = true;
            Cells[2, 2] = true;

            Cells[3, 3] = true;
            Cells[3, 4] = true;
            Cells[3, 5] = true;
            Cells[4, 3] = true;
            Cells[4, 4] = true;
            Cells[4, 5] = true;
            Cells[5, 3] = true;
            Cells[5, 4] = true;
            Cells[5, 5] = true;
        }
    }
}
