using GameOfLife.Patterns.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The barge pattern.
    /// Size: 4x4
    /// </summary>
    public class Barge : Pattern
    {
        /// <summary>
        /// Create a barge pattern.
        /// </summary>
        public Barge() : base(4, 4) { }

        /// <summary>
        /// Build the barge pattern.
        /// </summary>
        protected override void Build()
        {
            var line = new DiagonalLine(3);

            PatternBuilder.Place(line, Cells, 0, 1);
            PatternBuilder.Place(line, Cells, 1, 0);
        }
    }
}
