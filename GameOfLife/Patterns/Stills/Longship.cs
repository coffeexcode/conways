using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The longship pattern.
    /// Size: 4x4
    /// </summary>
    public class Longship : Pattern
    {

        /// <summary>
        /// Create a longship pattern.
        /// </summary>
        public Longship() : base(4, 4) { }

        /// <summary>
        /// Build the longship pattern.
        /// </summary>
        protected override void Build()
        {
            var longboat = new Longboat();

            PatternBuilder.Place(longboat, Cells, 0, 0);
            Cells[0, 0] = true;
        }
    }
}
