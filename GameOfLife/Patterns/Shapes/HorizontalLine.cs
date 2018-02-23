using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    public class HorizontalLine : Pattern
    {

        public HorizontalLine(int width) : base(1, width) { }

        protected override bool[,] Build()
        {
            var cells = new bool[1, Width];

            for (int i = 0; i < Width; i++)
                cells[0, i] = true;

            return cells;
        }
    }
}
