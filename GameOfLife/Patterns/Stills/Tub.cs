using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The tub pattern:
    /// Size: 3x3
    /// </summary>
    public class Tub : Pattern
    {
        /// <summary>
        /// Create the tub pattern.
        /// </summary>
        public Tub() : base(3, 3) { }


        /// <summary>
        /// Build the tub pattern
        /// </summary>
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[2, 0] = true;
            Cells[2, 2] = true;
            Cells[2, 1] = true;
        }
    }
}
