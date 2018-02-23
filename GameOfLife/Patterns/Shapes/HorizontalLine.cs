using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    /// <summary>
    /// The horizontal line pattern.
    /// Size: 1xn
    /// </summary>
    public class HorizontalLine : Pattern
    {

        /// <summary>
        /// Create a new horizontal line pattern.
        /// </summary>
        /// <param name="width">Width of the horizontal line</param>
        public HorizontalLine(int width) : base(1, width) { }

        /// <summary>
        /// Build the horizontal line pattern.
        /// </summary>
        protected override void Build()
        {
            for (int i = 0; i < Width; i++)
                Cells[0, i] = true;
        }
    }
}
