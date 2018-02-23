using GameOfLife.Patterns.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The pulsar pattern.
    /// Size: 13x13
    /// </summary>
    public class Pulsar : Oscillator
    {
        /// <summary>
        /// Create a pulsar pattern.
        /// </summary>
        public Pulsar() : base(13, 13, 15, 15) { }

        /// <summary>
        /// Build the pulsar pattern.
        /// </summary>
        protected override void Build()
        {
            var vLine = new VerticalLine(3);
            var hLine = new HorizontalLine(3);

            PatternBuilder.Place(vLine, Cells, 2, 0);
            PatternBuilder.Place(vLine, Cells, 8, 0);
            PatternBuilder.Place(vLine, Cells, 2, 5);
            PatternBuilder.Place(vLine, Cells, 8, 5);
            PatternBuilder.Place(vLine, Cells, 2, 7);
            PatternBuilder.Place(vLine, Cells, 8, 7);
            PatternBuilder.Place(vLine, Cells, 2, 12);
            PatternBuilder.Place(vLine, Cells, 8, 12);

            PatternBuilder.Place(hLine, Cells, 0, 2);
            PatternBuilder.Place(hLine, Cells, 0, 8);
            PatternBuilder.Place(hLine, Cells, 5, 2);
            PatternBuilder.Place(hLine, Cells, 5, 8);
            PatternBuilder.Place(hLine, Cells, 7, 2);
            PatternBuilder.Place(hLine, Cells, 7, 8);
            PatternBuilder.Place(hLine, Cells, 12, 2);
            PatternBuilder.Place(hLine, Cells, 12, 8);
        }
    }
}
