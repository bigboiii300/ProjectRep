using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalDrawingApplication
{
    /// <summary>
    /// A child of a fractal by the name of Pythagorean tree.
    /// </summary>
    public class PythTree : Fractal
    {
        public double Angle1 { get; internal set; }
        public double Angle2 { get; internal set; }
        public double Coefficient { get; internal set; }
        /// <summary>
        /// Pythagorean tree constructor.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="lineSegmentLength"></param>
        /// <param name="angle1"></param>
        /// <param name="angle2"></param>
        /// <param name="coefficient"></param>
        public PythTree(int x, int y, double lineSegmentLength, double angle1, double angle2, double coefficient)
        {
            this.x = x;
            this.y = y;
            LineSegmentLength = lineSegmentLength;
            Angle1 = angle1;
            Angle2 = angle2;
            Coefficient = coefficient;
        }
    }
}
