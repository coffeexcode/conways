using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    public class VerticalLine : Pattern
    {

        public VerticalLine(int height) : base(height, 1) { }

        protected override bool[,] Build()
        {
            var cells = new bool[Height, 1];

            for (int i = 0; i < Height; i++)
                cells[i, 0] = true;

            return cells;
        }
    }
}
