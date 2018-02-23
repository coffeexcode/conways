using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The toad pattern.
    /// Initial size: 2x4
    /// Max size: 4x4
    /// </summary>
    public class Toad : Oscillator
    {
        /// <summary>
        /// Construct a new toad object.
        /// </summary>
        public Toad() : base(2, 4, 4, 4) { }

        /// <summary>
        /// Builds the toad pattern.
        /// </summary>
        /// <returns>2D array of cells containing the toad pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 1] = true;
            cells[0, 2] = true;
            cells[0, 3] = true;

            cells[1, 0] = true;
            cells[1, 1] = true;
            cells[1, 2] = true;

            return cells;
        }
    }
}
