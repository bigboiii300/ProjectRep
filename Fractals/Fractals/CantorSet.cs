using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalDrawingApplication
{
    /// <summary>
    /// A child of a fractal by the name of Cantor set.
    /// </summary>
    public class CantorSet : Fractal
    {
        public int SpaceBetweenSegments { get; internal set; }
        public int x2 { get; internal set; }
        public int y2 { get; internal set; }
        /// <summary>
        /// Set's constructor.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="lineSegmentLength"></param>
        /// <param name="spaceBetweenSegments"></param>
        public CantorSet(int x, int y, int x2, int y2, double lineSegmentLength, int spaceBetweenSegments)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            LineSegmentLength = lineSegmentLength;
            SpaceBetweenSegments = spaceBetweenSegments;
        }
    }
}
