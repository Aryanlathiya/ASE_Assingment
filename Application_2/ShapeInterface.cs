using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{
    /// <summary>
    /// Interface for geometric shapes.
    /// </summary>
    interface ShapeInterface
    {

        /// <summary>
        /// Sets the parameters for the shape.
        /// </summary>
        /// <param name="list">An array of integers representing the parameters of the shape.</param>
        void set(params int[] list);

        /// <summary>
        /// Sets the parameters for a triangle shape.
        /// </summary>
        /// <param name="x">The x-coordinate of the triangle.</param>
        /// <param name="y">The y-coordinate of the triangle.</param>
        /// <param name="points">An array of Points representing the vertices of the triangle.</param>
        void setTriangle(int x, int y, Point[] points);

        /// <summary>
        /// Draws the shape using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the shape.</param>
        /// <param name="brush">The Brush used to fill the shape.</param>
        void Draw(Graphics g, Pen pen, Brush brush);
    }
}
