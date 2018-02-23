using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{

    /// <summary>
    /// The penta decathon pattern
    /// Size: 1x10
    /// Period 15 oscillator
    /// </summary>
    public class PentaDecathon : Oscillator
    {
        /// <summary>
        /// Create a penta decathon pattern
        /// </summary>
        public PentaDecathon() : base(1, 10, 5, 14) { }

        /// <summary>
        /// Build the penta decathon pattern
        /// </summary>
        protected override void Build()
        {
            Cells = new Shapes.HorizontalLine(10).Cells;
        }
    }
}
