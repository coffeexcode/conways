using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The beacon pattern.
    /// Initial Size: 4x4
    /// Max Size: 4x4
    /// </summary>
    public class Beacon : Oscillator
    {
        /// <summary>
        /// Creates a new beacon patter
        /// </summary>
        public Beacon() : base(4, 4, 4, 4) { }

        /// <summary>
        /// Builds the beacon pattern.
        /// </summary>
        /// <returns>A 2D array of cells containing the beacon pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Height, Width];

            cells[0, 0] = true;
            cells[0, 1] = true;
            cells[1, 0] = true;

            cells[2, 3] = true;
            cells[3, 2] = true;
            cells[3, 3] = true;

            return cells;
        }
    }
}
