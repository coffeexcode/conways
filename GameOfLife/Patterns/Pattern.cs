using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    /// <summary>
    /// Defines a pattern of cells that can be set in
    /// the game world. Corresponded to unique patterns
    /// that generally do something unique.
    /// 
    /// Patterns are defined from the top left corner. A pattern that is 3x3
    /// occupies cells in such a manner where 'o' is the cell that the pattern
    /// will be placed at.
    ///     
    /// Example:
    ///             0 1 2 
    ///          0  o x x
    ///          1  x x x
    ///          2  x x x
    /// </summary>
    public abstract class Pattern
    {
        /// <summary>
        /// Total height of the pattern
        /// </summary>
        public int Height { get; protected set; }

        /// <summary>
        /// Total width of the pattern
        /// </summary>
        public int Width { get; protected set; }

        /// <summary>
        /// The cells that make up the pattern. Empty cells
        /// are included in the pattern.
        /// </summary>
        public bool[,] Cells { get; protected set; }

        /// <summary>
        /// Create a default pattern object with a width and a height.
        /// </summary>
        /// <param name="height">Height of the pattern.</param>
        /// <param name="width">Width of the pattern.</param>
        public Pattern(int height, int width)
        {
            Height = height;
            Width = width;
            Cells = new bool[Height, Width];

            Build();
        }

        /// <summary>
        /// Method that is used to initialize the pattern
        /// </summary>
        protected abstract void Build();

        /// <summary>
        /// Get's the value of a specific cell in the pattern.
        /// </summary>
        /// <param name="row">Row of cell to get.</param>
        /// <param name="col">Column of cell to get.</param>
        /// <returns>Value of the cell at [row, column]</returns>
        public bool Get(int row, int col)
        {
            return Cells[row, col];
        }
    }
}
