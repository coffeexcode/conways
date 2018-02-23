using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    /// <summary>
    /// The block pattern:
    /// Size: 2x2
    /// </summary>
    public class Block : Pattern
    {
        /// <summary>
        /// Create the block pattern.
        /// </summary>
        public Block(int row, int col) : base(2, 2) { }

        /// <summary>
        /// Build the block pattern
        /// </summary>
        /// <returns>A 2D array of cells containing the block pattern.</returns>
        protected override bool[,] Build()
        {
            var cells = new bool[Width, Height];
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    cells[i, j] = true;
            return cells;
        }
    }
}
