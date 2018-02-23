using GameOfLife.Patterns.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The longbarge pattern.
    /// Size: 5x5
    /// </summary>
    public class Longbarge : Pattern
    {

        /// <summary>
        /// Create a longbarge pattern
        /// </summary>
        public Longbarge() : base(5, 5) { }

        /// <summary>
        /// Build the longbarge pattern.
        /// </summary>
        protected override void Build()
        {
            var line = new DiagonalLine(4);

            PatternBuilder.Place(line, Cells, 0, 1);
            PatternBuilder.Place(line, Cells, 1, 0);
        }
    }
}
