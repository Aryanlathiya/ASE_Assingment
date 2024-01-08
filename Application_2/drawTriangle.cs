using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_2
{


    /// <summary>
    /// Represents a triangle shape that inherits from the Shape base class.
    /// </summary>
    public class drawTriangle :Shape
    {
        private Point[] pnt;


        /// <summary>
        /// Constructor for initializing the triangle with specified vertices.
        /// </summary>
        /// <param name="pnt">An array of Points representing the vertices of the triangle.</param>
        public drawTriangle(Point[] pnt)
        {

            this.pnt = pnt;
        }



        /// <summary>
        /// Default constructor for the triangle.
        /// </summary>
        public drawTriangle() { }




        /// <summary>
        /// Sets the position and vertices of the triangle using the provided coordinates and points.
        /// </summary>
        /// <param name="x">The x-coordinate of the triangle.</param>
        /// <param name="y">The y-coordinate of the triangle.</param>
        /// <param name="points">An array of Points representing the vertices of the triangle.</param>
        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.pnt = points;
        }



        /// <summary>
        /// Draws the triangle using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the triangle.</param>
        /// <param name="brush">The Brush used to fill the triangle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            if(pnt.Length == 3)
            {
                g.DrawPolygon(pen, pnt);
                g.FillPolygon(brush, pnt);
            }
            else
            {
                MessageBox.Show("Invalid number of points for a triangle", "Error");

            }
        }
    }
}
