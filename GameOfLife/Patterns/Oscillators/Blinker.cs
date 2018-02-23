namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// A generic blinking oscillator.
    /// Size: nxn
    /// </summary>
    public abstract class Blinker : Oscillator
    {
        /// <summary>
        /// Create a blinker pattern.
        /// </summary>
        /// <param name="height">Height of the blinker</param>
        /// <param name="width">Width of the blinker</param>
        public Blinker(int height, int width) : base(height, width, 3, 3) { }
    }

    /// <summary>
    /// The vertical blinker pattern.
    /// Initial Size: 3x1
    /// Phase 2 size: 1x3
    /// Max size: 3x3
    /// </summary>
    public class VerticalBlinker : Blinker
    {
        /// <summary>
        /// Create the vertical blinker pattern.
        /// </summary>
        public VerticalBlinker() : base(3, 1) { }

        /// <summary>
        /// Build the vertical blinker pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 0] = true;
            Cells[1, 0] = true;
            Cells[2, 0] = true;
        }
    }

    /// <summary>
    /// The horizontal blinker pattern.
    /// Initial Size: 1x3
    /// Phase 2 size: 3x1
    /// Max size: 3x3
    /// </summary>
    public class HorizontalBlinker : Blinker
    {
        /// <summary>
        /// Create the horizontal blinker pattern
        /// </summary>
        public HorizontalBlinker() : base(1, 3) { }

        /// <summary>
        /// Build the horizontal blinker pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 0] = true;
            Cells[0, 1] = true;
            Cells[0, 2] = true;
        }
    }
}
