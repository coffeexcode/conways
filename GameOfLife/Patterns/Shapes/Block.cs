using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    /// <summary>
    /// The block pattern:
    /// Size: nxn (default = 2x2)
    /// </summary>
    public class Block : Pattern
    {
        /// <summary>
        /// Create the block pattern.
        /// </summary>
        public Block() : base(2, 2) { }

        /// <summary>
        /// Create a block pattern of given size.
        /// </summary>
        /// <param name="size">Size of the block (sqaure).</param>
        public Block(int size): base(size, size) { }

        /// <summary>
        /// Build the block pattern
        /// </summary>
        protected override void Build()
        {
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    Cells[i, j] = true;
        }
    }
}
