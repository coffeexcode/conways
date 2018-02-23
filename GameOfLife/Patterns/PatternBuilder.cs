using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns
{
    static class PatternBuilder
    {
        /// <summary>
        /// Places a pattern into the game world.
        /// See <see cref="Pattern"/> for details about how patterns are constructed.
        /// </summary>
        /// <param name="pattern">Pattern to place in the game world.</param>
        /// <param name="cells">Array of cells to insert the pattern into.</param>
        /// <param name="row">Row to place the pattern in.</param>
        /// <param name="col">Column to place the pattern in.</param>
        /// <returns>True if the pattern was successfully placed.</returns>
        public static bool Place(Pattern pattern, bool[,] cells, int row, int col)
        {
            if (!ValidatePlacement(pattern, cells, row, col))
            {
                return false;
            }

            for (int i = 0; i < pattern.Height; i++)
            {
                for (int j = 0; j < pattern.Width; j++)
                {
                    bool cell = pattern.Get(i, j);

                    if (cell)
                        cells[row + i, col + j] = cell;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks whether a pattern can be placed in the corresponding postition.
        /// We substract 1 from the width/height since we are starting the placement at the current
        /// position.
        /// See <see cref="Pattern"/> for details about positions
        /// </summary>
        /// <param name="pattern">Pattern to check placement</param>
        /// <param name="cells">Array of cells to validate the placement in.</param>
        /// <param name="row">Row of cells to place pattern in.</param>
        /// <param name="col">Column of cells to place pattern in.</param>
        /// <returns>True if a pattern can be placed in the cell.</returns>
        public static bool ValidatePlacement(Pattern pattern, bool[,] cells, int row, int col)
        {
            var isValidPosition = ValidatePosition(cells, row, col);

            if (row + (pattern.Height - 1) >= cells.GetLength(0))
            {
                return false;
            }

            if (col + (pattern.Width - 1) >= cells.GetLength(1))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates the row and column in the world.
        /// </summary>
        /// <param name="row">Row to check.</param>
        /// <param name="cells">Array of cells to validate the row and column in.</param>
        /// <param name="col">Column to check.</param>
        /// <returns>True if the row and column are valid.</returns>
        public static bool ValidatePosition(bool[,] cells, int row, int col)
        {
            if (row < 0 || row >= cells.GetLength(0))
            {
                return false;
            }

            if (col < 0 || col >= cells.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
