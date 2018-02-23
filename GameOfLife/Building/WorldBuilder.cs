using GameOfLife.Patterns;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Building
{
    /// <summary>
    /// Class with the functionality to build and modify
    /// a game world using <see cref="Pattern"/> objects
    /// and direct manipulation.
    /// Default size is 50x50
    /// </summary>
    public class WorldBuilder
    {
        /// <summary>
        /// Default height to build worlds at.
        /// </summary>
        public int DefaultHeight { get; } = 50;

        /// <summary>
        /// Default width to build worlds at.
        /// </summary>
        public int DefaultWidth { get; } = 50;

        /// <summary>
        /// Height of the world currently being built.
        /// </summary>
        public int Height { get => World.Height; set => ChangeHeight(value); }

        /// <summary>
        /// Width of the world currently being built.
        /// </summary>
        public int Width { get => World.Width;  set => ChangeWidth(value); }

        /// <summary>
        /// The gameworld currently being built.
        /// </summary>
        public GameWorld World { get; private set; }

        /// <summary>
        /// Create a new WorldBuilder with a new game world object.
        /// </summary>
        public WorldBuilder()
        {
            World = new GameWorld(DefaultHeight, DefaultWidth);
        }

        /// <summary>
        /// Create a new WorldBuilder object with a game world of
        /// specific size.
        /// </summary>
        /// <param name="height">Height of game world.</param>
        /// <param name="width">Width of game world.</param>
        public WorldBuilder(int height, int width)
        {
            World = new GameWorld(height, width);
        }

        /// <summary>
        /// Directly modifies the game world at the specified cell.
        /// </summary>
        /// <param name="row">Row of cell to set.</param>
        /// <param name="col">Column of cell to set.</param>
        /// <param name="value">Value of cell to set.</param>
        /// <returns>True if the cell was successfully set.</returns>
        public bool Set(int row, int col, bool value)
        {
            if (!ValidatePosition(row, col))
            {
                return false;
            }

            World.Set(row, col, value);

            return true;
        }

        /// <summary>
        /// Places a pattern into the game world.
        /// See <see cref="Pattern"/> for details about how patterns are constructed.
        /// </summary>
        /// <param name="pattern">Pattern to place in the game world.</param>
        /// <param name="row">Row to place the pattern in.</param>
        /// <param name="col">Column to place the pattern in.</param>
        /// <param name="overwrite">True if the pattern's empty spaces should overwrite other cells. Default = true.</param>
        /// <returns>True if the pattern was successfully placed.</returns>
        public bool Place(Pattern pattern, int row, int col, bool overwrite = true)
        {
            if (!ValidatePlacement(pattern, row, col))
            {
                return false;
            }

            for (int i = 0; i < pattern.Height; i++)
            {
                for (int j = 0; j < pattern.Width; j++)
                {
                    bool cell = pattern.Get(i, j);

                    if (!cell && overwrite || cell)
                        World.Set(row + i, col + j, cell);
                }
            }

            return true;
        }

        /// <summary>
        /// Checks whether a pattern can be placed in the corresponding postition.
        /// See <see cref="Pattern"/> for details about positions
        /// </summary>
        /// <param name="pattern">Pattern to check placement</param>
        /// <param name="row">Row of cells to place pattern in.</param>
        /// <param name="col">Column of cells to place pattern in.</param>
        /// <returns>True if a pattern can be placed in the cell.</returns>
        public bool ValidatePlacement(Pattern pattern, int row, int col)
        {
            var isValidPosition = ValidatePosition(row, col);

            int height = pattern.Height;
            int width = pattern.Width;

            if (row + height >= World.Height)
            {
                return false;
            }

            if (col + width >= World.Width)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates the row and column in the world.
        /// </summary>
        /// <param name="row">Row to check.</param>
        /// <param name="col">Column to check.</param>
        /// <returns>True if the row and column are valid.</returns>
        public bool ValidatePosition(int row, int col)
        {
            if (row < 0 || row >= Height )
            {
                return false;
            }

            if (col < 0 || col >= Width)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Changes the height of the game world. Copies the all cells possible from
        /// the old world to the new world. New cells default to empty.
        /// </summary>
        /// <param name="value">New height of the world.</param>
        private void ChangeHeight(int value)
        {
            if (value < GameWorld.MinSize)
                return;

            if (value == Height)
                return;

            int max = Math.Max(Height, value);
            GameWorld newWorld = new GameWorld(value, Width);

            for (int i = 0; i < max; i++)
                for (int j = 0; j < Width; j++)
                    newWorld.Set(i, j, World.Get(i, j));

            World = newWorld;
        }

        /// <summary>
        /// Changes the width of the game world. Copies all the cells possible from
        /// the old world to the new world. New cells default to empty.
        /// </summary>
        /// <param name="value">New width of the world.</param>
        private void ChangeWidth(int value)
        {
            if (value < GameWorld.MinSize)
                return;

            if (value == Width)
                return;

            int max = Math.Max(Height, value);

            GameWorld newWorld = new GameWorld(Height, value);

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < max; j++)
                    newWorld.Set(i, j, World.Get(i, j));

            World = newWorld;
        }
    }
}
