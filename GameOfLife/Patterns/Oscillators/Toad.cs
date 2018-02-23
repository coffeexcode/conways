using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The toad pattern.
    /// Initial size: 2x4
    /// Max size: 4x4
    /// </summary>
    public class Toad : Oscillator
    {
        /// <summary>
        /// Construct a new toad object.
        /// </summary>
        public Toad() : base(2, 4, 4, 4) { }

        /// <summary>
        /// Builds the toad pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 1] = true;
            Cells[0, 2] = true;
            Cells[0, 3] = true;

            Cells[1, 0] = true;
            Cells[1, 1] = true;
            Cells[1, 2] = true;
        }
    }
}
