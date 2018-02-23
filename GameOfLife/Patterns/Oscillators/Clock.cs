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
        /// <returns>A 2D array of cells containg the clock pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 1] = true;
            cells[1, 2] = true;
            cells[1, 3] = true;
            cells[2, 0] = true;
            cells[2, 1] = true;
            cells[3, 2] = true;

            return cells;
        }
    }
}
