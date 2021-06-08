using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalDrawingApplication
{
    /// <summary>
    /// A child of a fractal by the name of Serpinski triangle.
    /// </summary>
    public class SerpinskiTriangle
    {
        public Point P1;
        public Point P2;
        public Point P3;
        /// <summary>
        /// Serpinski triangle's constructor.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        public SerpinskiTriangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
    }
}
