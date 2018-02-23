using GameOfLife.Patterns.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The snake pattern.
    /// Size: 2x4
    /// </summary>
    public class Snake : Pattern
    {

        /// <summary>
        /// Create a snake pattern.
        /// </summary>
        public Snake() : base(2, 4) { }

        /// <summary>
        /// Builds the snake pattern
        /// </summary>
        protected override void Build()
        {
            var left = new Triangle(TriangleType.BottomLeft);
            var right = new Triangle(TriangleType.UpperRight);

            PatternBuilder.Place(left, Cells, 0, 0);
            PatternBuilder.Place(right, Cells, 0, 2);
        }
    }
}
