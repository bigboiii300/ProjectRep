using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalDrawingApplication
{
    public partial class Form1 : Form
    {
        private int depth;
        public Form1()
        {
            this.depth = 1;
            InitializeComponent();
        }
        /// <summary>
        /// Draws Pythagorean tree.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="e"></param>
        /// <param name="depthCopy"></param>
        /// <param name="angle"></param>
        public void DrawTreeFractal(PythTree tree, Graphics e, int depthCopy, double angle)
        {
            if (depthCopy == 0) return;
            double x1;
            double y1;
            // Calculate new coordinates via circle equation.
            x1 = (tree.x + tree.LineSegmentLength * Math.Sin(angle * Math.PI * 2 / 360.0));
            y1 = (tree.y + tree.LineSegmentLength * Math.Cos(angle * Math.PI * 2 / 360.0));
            e.DrawLine(new Pen(Color.Black), tree.x, FractalCanvas.Height - tree.y, (int)x1, FractalCanvas.Height - (int)y1);
            if (depthCopy > 2)
            {
                // First branch.
                DrawTreeFractal(new PythTree(
                    (int)x1,
                    (int)y1,
                    tree.LineSegmentLength / tree.Coefficient,
                    tree.Angle1,
                    tree.Angle2,
                    tree.Coefficient
                    ), e, depthCopy - 1, tree.Angle1 + angle);

                // Second branch.
                DrawTreeFractal(new PythTree(
                    (int)x1,
                    (int)y1,
                    tree.LineSegmentLength / tree.Coefficient,
                    tree.Angle1,
                    tree.Angle2,
                    tree.Coefficient
                    ), e, depthCopy - 1, angle - tree.Angle2);
            }
        }
        /// <summary>
        /// Draws Koch's curve.
        /// </summary>
        /// <param name="curve"></param>
        /// <param name="e"></param>
        /// <param name="depthCopy"></param>
        public void DrawKochFractal(KochCurve curve, Graphics e, int depthCopy)
        {
            if (depthCopy <= 0)
            {
                e.DrawLine(new Pen(Color.Black), new Point(curve.x, curve.y), new Point(curve.x2, curve.y2));
                return;
            }

            // Pairs for the 1st and 2nd segments.
            double x3 = curve.x + (curve.x2 - curve.x) * 1 / 3;
            double y3 = curve.y + (curve.y2 - curve.y) * 1 / 3;
           
            // Pairs for the 3rd and 4th segments.
            double x4 = curve.x + (curve.x2 - curve.x) * 2 / 3;
            double y4 = curve.y + (curve.y2 - curve.y) * 2 / 3;
            double x5 = x3 + (x4 - x3) * Math.Cos(Math.PI / 3) - Math.Sin(Math.PI / 3) * (y4 - y3);
            double y5 = y3 + (x4 - x3) * Math.Sin(Math.PI / 3) + Math.Cos(Math.PI / 3) * (y4 - y3);

            DrawKochFractal(new KochCurve(curve.x, (int)x3, curve.y, (int)y3), e, depthCopy - 1);
            DrawKochFractal(new KochCurve((int)x3, (int)x5, (int)y3, (int)y5), e, depthCopy - 1);
            DrawKochFractal(new KochCurve((int)x5, (int)x4, (int)y5, (int)y4), e, depthCopy - 1);
            DrawKochFractal(new KochCurve((int)x4, curve.x2, (int)y4, curve.y2), e, depthCopy - 1);

        }
        
        /// <summary>
        /// Draws Serpinski triangle.
        /// </summary>
        /// <param name="triangle"></param>
        /// <param name="e"></param>
        /// <param name="depthCopy"></param>
        public void DrawTriangleFractal(SerpinskiTriangle triangle, Graphics e, int depthCopy)
        {
            // Exit case.
            if (depthCopy == 0) return;

            // Drawing the triangle.
            e.DrawLine(new Pen(Color.Black), triangle.P1, triangle.P2);
            e.DrawLine(new Pen(Color.Black), triangle.P1, triangle.P3);
            e.DrawLine(new Pen(Color.Black), triangle.P2, triangle.P3);

            // Calculate the midpoints.
            Point p1p2 = new Point(
                (triangle.P1.X + triangle.P2.X) / 2,
                (triangle.P1.Y + triangle.P2.Y) / 2);
            Point p1p3 = new Point(
                (triangle.P1.X + triangle.P3.X) / 2,
                (triangle.P1.Y + triangle.P3.Y) / 2);
            Point p2p3 = new Point(
                (triangle.P2.X + triangle.P3.X) / 2,
                (triangle.P2.Y + triangle.P3.Y) / 2);

            // Draw new triangles with the new points.
            DrawTriangleFractal(new SerpinskiTriangle(triangle.P1, p1p2, p1p3), e, depthCopy - 1);
            DrawTriangleFractal(new SerpinskiTriangle(p1p2, triangle.P2, p2p3), e, depthCopy - 1);
            DrawTriangleFractal(new SerpinskiTriangle(p1p3, p2p3, triangle.P3), e, depthCopy - 1);
        }
        /// <summary>
        /// Draws Cantor set.
        /// </summary>
        /// <param name="set"></param>
        /// <param name="e"></param>
        /// <param name="depthCopy"></param>
        public void DrawCantorSetFractal(CantorSet set, Graphics e, int depthCopy)
        {
            // Given xy, x2y2. Calculate x3y3...x5y5.
            if (depthCopy == 0)
            {
                e.DrawLine(new Pen(Color.Black), set.x, set.y, set.x2, set.y2);
                return;
            }
            double newSegment = set.LineSegmentLength / 3;
            double x3 = set.x;
            double x4 = x3 + newSegment;
            double x6 = set.x2;
            double x5 = x6 - newSegment;

            double y3 = set.y + set.SpaceBetweenSegments;
            double y6 = set.y2 + set.SpaceBetweenSegments;
            double y4 = y3;
            double y5 = y6;

            DrawCantorSetFractal(new CantorSet(set.x, set.y, set.x2, set.y2, set.LineSegmentLength, set.SpaceBetweenSegments),
                e,
                depthCopy - 1);
            DrawCantorSetFractal(new CantorSet((int)x3, (int)y3, (int)x4, (int)y4, newSegment, set.SpaceBetweenSegments),
                e,
                depthCopy - 1);
            DrawCantorSetFractal(new CantorSet((int)x5, (int)y5, (int)x6, (int)y6, newSegment, set.SpaceBetweenSegments),
                e,
                depthCopy - 1);
        }
        /// <summary>
        /// Draws serpinski carpet.
        /// </summary>
        /// <param name="carpet"></param>
        /// <param name="e"></param>
        /// <param name="depthCopy"></param>
        public void DrawSerpinskiCarpet(SerpinskiCarpet carpet, Graphics e, int depthCopy)
        {
            if (depthCopy == 0)
            {
                e.FillRectangle(Brushes.Black, carpet.x, carpet.y, (int)carpet.Width, (int)carpet.Height);
                return;
            }
            double width = carpet.Width / 3.0;
            double height = carpet.Height / 3.0;
            // Assign x-es.
            int x1 = carpet.x;
            int x2 = (int)(x1 + width);
            int x3 = (int)(x1 + 2 * width) - 1;

            // Assign y-s.
            int y1 = carpet.y;
            int y2 = (int)(y1 + height);
            int y3 = (int)(y1 + 2 * height);

            DrawSerpinskiCarpet(new SerpinskiCarpet(x1, y1, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x2, y1, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x3, y1, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x1, y2, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x3, y2, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x1, y3, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x2, y3, width, height), e, depthCopy - 1);
            DrawSerpinskiCarpet(new SerpinskiCarpet(x3, y3, width, height), e, depthCopy - 1);


        }
        /// <summary>
        /// When the tree button is clicked, we begin drawing a tree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tree_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            g.Clear(Color.White);
            DrawTreeFractal(new PythTree(
                FractalCanvas.Width / 2,
                0,
                150,
                Angle1Line.Value,
                Angle2Line.Value, 
                CoefField.Value), 
                g, this.depth, 0);
        }

        /// <summary>
        /// When the KochCurve button is clicked, we begin drawing a curve.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KochCurve_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            g.Clear(Color.White);
            DrawKochFractal(new KochCurve(
                0,
                FractalCanvas.Width,
                FractalCanvas.Height / 2,
                FractalCanvas.Height / 2
                ),
                g, this.depth);
        }

        /// <summary>
        /// When the triangle button is clicked, we begin drawing a Serpinski triangle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleSerpinskiy_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            g.Clear(Color.White);
            Point p1 = new Point((FractalCanvas.Width / 2), 1);
            Point p2 = new Point(1, (FractalCanvas.Height - 40));
            Point p3 = new Point(FractalCanvas.Width - 10, (FractalCanvas.Height - 40));
            DrawTriangleFractal(new SerpinskiTriangle(p1, p2, p3), g, this.depth);
        }
        /// <summary>
        /// Event handler for cantor button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cantor_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            int depth = CantorRecursionTrack.Value;
            g.Clear(Color.White);
            DrawCantorSetFractal(new CantorSet(
                0,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                CantorSpaceBetIter.Value
                ), g, depth);
        }
        /// <summary>
        /// Event handler for Serpinski button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serpinskiy_Click(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            int depth = SerpinskiCarpetRecursionTrack.Value;
            g.Clear(Color.White);
            DrawSerpinskiCarpet(new SerpinskiCarpet(0, 0, FractalCanvas.Width, FractalCanvas.Height), g, depth);
        }
        /// <summary>
        /// Recursion trackbar for the tree fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecursionDepthTree_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            double coefficient = double.Parse(CoefField.Value.ToString());
            g.Clear(Color.White);
            int depth = RecursionDepth.Value;
            DrawTreeFractal(new PythTree(
                FractalCanvas.Width / 2,
                0,
                150,
                Angle1Line.Value,
                Angle2Line.Value,
                coefficient * 0.75),
                g, depth, 0);
        }
        /// <summary>
        /// Line segments divisor coefficient trackbar for the tree fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CoefField_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            double coefficient = double.Parse(CoefField.Value.ToString());
            g.Clear(Color.White);
            int depth = RecursionDepth.Value;
            DrawTreeFractal(new PythTree(
                FractalCanvas.Width / 2,
                0,
                150,
                Angle1Line.Value,
                Angle2Line.Value,
                coefficient * 0.75),
                g, depth, 0);
        }
        /// <summary>
        /// Custom angle 1 trackbar for the tree fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angle1Line_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            double coefficient = double.Parse(CoefField.Value.ToString());
            g.Clear(Color.White);
            int depth = RecursionDepth.Value;
            DrawTreeFractal(new PythTree(
                FractalCanvas.Width / 2,
                0,
                150,
                Angle1Line.Value,
                Angle2Line.Value,
                coefficient * 0.75),
                g, depth, 0);
        }
        /// <summary>
        /// Custom angle 2 trackbar for the tree fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Angle2Line_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            double coefficient = double.Parse(CoefField.Value.ToString());
            g.Clear(Color.White);
            int depth = RecursionDepth.Value;
            DrawTreeFractal(new PythTree(
                FractalCanvas.Width / 2,
                0,
                150,
                Angle1Line.Value,
                Angle2Line.Value,
                coefficient * 0.75),
                g, depth, 0);
        }
        /// <summary>
        /// Recursion trackbar for the Koch curve fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KochRecursionTrack_Scroll(object sender, EventArgs e)
        {
            int depth = KochRecursionTrack.Value;
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            g.Clear(Color.White);
            DrawKochFractal(new KochCurve(
                0,
                FractalCanvas.Width,
                FractalCanvas.Height / 2,
                FractalCanvas.Height / 2
                ),
                g, depth);
        }

        /// <summary>
        /// Recursion trackbar for the Serpinski triangle fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRecursionTrack_Scroll(object sender, EventArgs e)
        {
            int depth = TriangleRecursionTrack.Value;
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            g.Clear(Color.White);
            Point p1 = new Point((FractalCanvas.Width / 2), 1);
            Point p2 = new Point(1, (FractalCanvas.Height - 40));
            Point p3 = new Point(FractalCanvas.Width - 10, (FractalCanvas.Height - 40));
            DrawTriangleFractal(new SerpinskiTriangle(p1, p2, p3), g, depth);
        }
        /// <summary>
        /// Recursion trackbar for the Cantor set fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CantorRecursionTrack_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            int depth = CantorRecursionTrack.Value;
            g.Clear(Color.White);
            DrawCantorSetFractal(new CantorSet(
                0,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                CantorSpaceBetIter.Value
                ), g, depth);
        }
        /// <summary>
        /// Recursion trackbar for the Serpinski carpet fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerpinskiCarpetRecursionTrack_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            int depth = SerpinskiCarpetRecursionTrack.Value;
            g.Clear(Color.White);
            DrawSerpinskiCarpet(new SerpinskiCarpet(0, 0, FractalCanvas.Width, FractalCanvas.Height), g, depth);
        }

        /// <summary>
        /// Redraws cantor set with new space parameter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CantorSpaceBetIter_Scroll(object sender, EventArgs e)
        {
            var g = Graphics.FromHwnd(FractalCanvas.Handle);
            int depth = CantorRecursionTrack.Value;
            g.Clear(Color.White);
            DrawCantorSetFractal(new CantorSet(
                0,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                FractalCanvas.Height / 6,
                FractalCanvas.Width,
                CantorSpaceBetIter.Value
                ), g, depth);
        }
    }
}
