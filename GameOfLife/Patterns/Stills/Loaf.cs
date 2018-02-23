using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The loaf pattern:
    /// Size: 4x4
    /// </summary>
    public class Loaf : Pattern
    {
        /// <summary>
        /// Create the loaf pattern.
        /// </summary>
        public Loaf() : base(4, 4) { }


        /// <summary>
        /// Build the loaf pattern
        /// </summary>
        /// <returns>A 2D array of cells containing the loaf pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[5, 4];

            cells[0, 1] = true;
            cells[0, 2] = true;

            cells[1, 0] = true;
            cells[1, 3] = true;

            cells[2, 1] = true;
            cells[2, 3] = true;

            cells[3, 2] = true;

            return cells;
        }
    }
}
