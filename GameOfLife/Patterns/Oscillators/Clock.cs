using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The clock pattern.
    /// Intial size: 4x4
    /// Max size: 4x4
    /// </summary>
    public class Clock : Oscillator
    {

        /// <summary>
        /// Creates a new clock pattern.
        /// </summary>
        public Clock() : base(4, 4, 4, 4) { }

        /// <summary>
        /// Build the clock pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[1, 2] = true;
            Cells[1, 3] = true;
            Cells[2, 0] = true;
            Cells[2, 1] = true;
            Cells[3, 2] = true;
        }
    }
}
