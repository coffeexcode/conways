using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    /// <summary>
    /// The triangle pattern.
    /// Size: 2x2
    /// There are four triangle types: 
    ///     1. UpperLeft 
    ///     2. UpperRight 
    ///     3. BottomLeft 
    ///     4. BottomRight 
    /// The cell across from the named type is false.
    /// 
    /// Example:
    /// TriangleType.UpperLeft
    /// 
    ///           0 1
    ///         0 x x
    ///         1 x
    /// </summary>
    public class Triangle : Pattern
    {
        /// <summary>
        /// Type of triangle to make
        /// </summary>
        public TriangleType _type { get; set; }

        /// <summary>
        /// Create a triangle of given type.
        /// </summary>
        /// <param name="type">Type of triangle to produce.</param>
        public Triangle(TriangleType type) : base(2, 2)
        {
            _type = type;

            // Re-build the triangle with type information
            Build();
        }

        /// <summary>
        /// Build a triangle of specific type.
        /// </summary>
        protected override void Build()
        {
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    Cells[i, j] = true;

            switch (_type)
            {
                case TriangleType.UpperLeft:
                    Cells[1, 1] = false;
                    break;
                case TriangleType.UpperRight:
                    Cells[1, 0] = false;
                    break;
                case TriangleType.BottomLeft:
                    Cells[0, 1] = false;
                    break;
                default:
                    Cells[0, 0] = false;
                    break;
            }
        }
    }

    /// <summary>
    /// Types of triangles available
    /// </summary>
    public enum TriangleType
    {
        UpperLeft, UpperRight, BottomLeft, BottomRight
    }
}



