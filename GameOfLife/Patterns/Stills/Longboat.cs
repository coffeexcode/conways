using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The longboat pattern.
    /// Size: 4x4
    /// </summary>
    public class Longboat : Pattern
    {

        /// <summary>
        /// Create a longboat pattern
        /// </summary>
        public Longboat() : base(4, 4) { }

        /// <summary>
        /// Build the longboat pattern.
        /// </summary>
        protected override void Build()
        {
            var barge = new Barge();

            PatternBuilder.Place(barge, Cells, 0, 0);
            Cells[3, 3] = true;
        }
    }
}
