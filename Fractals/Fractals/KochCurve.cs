using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalDrawingApplication
{
    /// <summary>
    /// A child of a fractal by the name of Koch's curve.
    /// </summary>
    public class KochCurve : Fractal
    {
        public int x2 { get; internal set; }
        public int y2 { get; internal set; }
        /// <summary>
        /// Curve's constructor.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="x2"></param>
        /// <param name="y"></param>
        /// <param name="y2"></param>
        public KochCurve(int x, int x2, int y, int y2)
        {
            this.x = x;
            this.x2 = x2;
            this.y = y;
            this.y2 = y2;
        }
    }
}
