using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The tub pattern:
    /// Size: 3x3
    /// </summary>
    public class Tub : Pattern
    {
        /// <summary>
        /// Create the tub pattern.
        /// </summary>
        public Tub() : base(3, 3) { }


        /// <summary>
        /// Build the tub pattern
        /// </summary>
        /// <returns>A 2D array of cells containing the tub pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[3, 3];

            cells[0, 1] = true;
            cells[2, 0] = true;
            cells[2, 2] = true;
            cells[2, 1] = true;

            return cells;
        }
    }
}
