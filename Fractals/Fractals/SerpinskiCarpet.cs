using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalDrawingApplication
{
    /// <summary>
    /// A child of a fractal by the name of Serpinski carpet.
    /// </summary>
    public class SerpinskiCarpet : Fractal
    {
        public double Width { get; internal set; }
        public double Height { get; internal set; }
        /// <summary>
        /// Serpinski carpet constructor.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public SerpinskiCarpet(int x, int y, double width, double height)
        {
            this.x = x;
            this.y = y;
            Width = width;
            Height = height;
        }
    }
}
