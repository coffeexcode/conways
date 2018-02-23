using System;

namespace GameOfLife
{
    /// <summary>
    /// Class defining a game world.
    /// 
    /// Represented by an 2D array of bools.
    /// True -> Cell is alive.
    /// False -> Cell is dead.
    /// </summary>
    public class GameWorld
    {
        /// <summary>
        /// Minimum height and width of the game world
        /// </summary>
        public static int MinSize { get; } = 5;

        /// <summary>
        /// The height of the game world
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// The width of the game world
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Whether to enable wrapping. If a cell is on the right ecge, it's right neigbour is 
        /// on the left edge. Default = false
        /// </summary>
        public bool Wrap { get; set; } = false;

        /// <summary>
        /// The generation of the game world.
        /// </summary>
        public decimal Generation { get; private set; }

        /// <summary>
        /// Underyling structure of the game world
        /// True -> Cell is alive
        /// False -> Cell is dead
        /// </summary>
        private bool[,] World { get; set; }

        /// <summary>
        /// Construct a new game world of given height and width
        /// </summary>
        /// <param name="height">The height of the game world.</param>
        /// <param name="width">The width of the game world.</param>
        public GameWorld(int height, int width)
        {
            if (height < MinSize || width < MinSize)
            {
                throw new Exception($"Height and width must be at least: {MinSize}");
            }

            Height = height;
            Width = width;
            World = new bool[height, width];
            Generation = 0;
        }

        /// <summary>
        /// Randomize all the cells in the game world to produce a
        /// random starting state.
        /// </summary>
        public void Randomize()
        {
            var r = new Random();
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (r.Next(10) > 8)
                        World[i, j] = true;
        }

        /// <summary>
        /// Update the game world to next generation.
        /// </summary>
        public void NextGeneration()
        {
            bool[,] newWorld = new bool[Height, Width];

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    newWorld[row, col] = IsAlive(row, col);
                }
            }

            World = newWorld;
            Generation++;
        }

        /// <summary>
        /// Sets the value of the cell.
        /// </summary>
        /// <param name="row">Row of the cell to set.</param>
        /// <param name="col">Column of the cell to set.</param>
        /// <param name="value">Value of the cell to set.</param>
        public void Set(int row, int col, bool value)
        {
            ValidatePosition(row, col);

            World[row, col] = value;
        }

        /// <summary>
        /// Get the value of the cell at postion [row, column]
        /// </summary>
        /// <param name="row">Row of cell to get.</param>
        /// <param name="col">Column of cell to get.</param>
        /// <returns>True if the cell is alive.</returns>
        public bool Get(int row, int col)
        {
            ValidatePosition(row, col);

            return World[row, col];
        }

        /// <summary>
        /// Checks whether a position is valid or not. If the position is 
        /// not valid, throws an error.
        /// </summary>
        /// <param name="row">Row of the cell.</param>
        /// <param name="col">Column of the cell.</param>
        private void ValidatePosition(int row, int col)
        {
            if (row < 0 || row >= Height)
            {
                throw new IndexOutOfRangeException("Row is not in the bounds of the game world.");
            }

            if (col < 0 || col >= Width)
            {
                throw new IndexOutOfRangeException("Column is not in the bounds of the game world.");
            }
        }

        /// <summary>
        /// Check whether a given cell should be alive or dead for the next 
        /// generation.
        /// </summary>
        /// <param name="row">Row of the cell to check.</param>
        /// <param name="col">Column of the cell to check.</param>
        /// <returns></returns>
        private bool IsAlive(int row, int col)
        {
            sbyte alive = 0;

            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {
                    if (Check(row + r, col + c))
                    {
                        alive++;
                    }
                }
            }

            if (Check(row, col))
            {
                alive--;
            }

            if (alive == 3 || (Check(row, col) && alive == 2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the value of a current cell. If wrapping is enabled, gets the value of the
        /// wrapped cell.
        /// </summary>
        /// <param name="row">Row of the cell to check.</param>
        /// <param name="col">Column of the cell to check.</param>
        /// <returns>True if the cell is alive.</returns>
        private bool Check(int row, int col)
        {
            if (Wrap)
            {
                if (row < 0)
                {
                    row = Height - 1;
                }
                else if (row >= Height)
                {
                    row = 0;
                }

                if (col < 0)
                {
                    col = Width - 1;
                }
                else if (col >= Width)
                {
                    col = 0;
                }

                return World[row, col];
            }
            else
            {
                if (row < 0 || row >= Height || col < 0 || col >= Width)
                {
                    return false;
                }

                return World[row, col];
            }
        }
    }
}
