using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The loaf pattern:
    /// Size: 4x4
    /// </summary>
    public class Loaf : Pattern
    {
        /// <summary>
        /// Create the loaf pattern.
        /// </summary>
        public Loaf() : base(4, 4) { }


        /// <summary>
        /// Build the loaf pattern
        /// </summary>
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[0, 2] = true;

            Cells[1, 0] = true;
            Cells[1, 3] = true;

            Cells[2, 1] = true;
            Cells[2, 3] = true;

            Cells[3, 2] = true;
        }
    }
}
