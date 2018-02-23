using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    /// <summary>
    /// Defines an oscillating pattern.
    /// 
    /// Oscillating patterns have multiple phases. The object has
    /// a <see cref="TotalHeight"/> and <see cref="TotalWidth"/>
    /// that correspondes with the maximum height and width of the 
    /// pattern. 
    /// 
    /// TODO: Implement method to warn user placements that will move outside 
    ///         the bounds of the game world.
    /// TODO: Implement something for Total(Height/Width) to reflect oscillators
    ///         that temporarily move up and down.
    /// </summary>
    public abstract class Oscillator : Pattern
    {
        /// <summary>
        /// The total width of the pattern.
        /// </summary>
        public int TotalWidth { get; }

        /// <summary>
        /// The total height of the pattern
        /// </summary>
        public int TotalHeight { get; }

        /// <summary>
        /// Create an oscillator pattern.
        /// </summary>
        /// <param name="height">Initial height of the pattern.</param>
        /// <param name="width">Initial width of the pattern.</param>
        /// <param name="totalWidth">Total height of the pattern (includes all phases).</param>
        /// <param name="totalHeight">Total width of the pattern (inclues all phases).</param>
        public Oscillator(int height, int width, int totalWidth, int totalHeight) : base(height, width) { }
    }
}
