using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    /// <summary>
    /// A diagonal line pattern
    /// Size: nxn
    /// </summary>
    public class DiagonalLine : Pattern
    {
        /// <summary>
        /// Create a diagonal line.
        /// </summary>
        /// <param name="length">Length of the line.</param>
        public DiagonalLine(int length) : base(length, length) { }

        /// <summary>
        /// Build a diagonal line pattern.
        /// </summary>
        protected override void Build()
        {
            for (int i = 0; i < Height; i++)
                Cells[i, i] = true;
        }
    }
}
