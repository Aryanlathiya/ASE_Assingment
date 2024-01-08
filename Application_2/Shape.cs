using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{

    /// <summary>
    /// Abstract base class for geometric shapes, implementing the ShapeInterface.
    /// </summary>
    public abstract class Shape : ShapeInterface
    {
        protected int x, y;


        /// <summary>
        /// Constructor for initializing the x and y coordinates of the shape.
        /// </summary>
        /// <param name="x">The x-coordinate of the shape.</param>
        /// <param name="y">The y-coordinate of the shape.</param>
        public Shape(int x, int y)
        {

            this.x = x;
            this.y = y;

        }


        /// <summary>
        /// Default constructor for the shape.
        /// </summary>
        public Shape()
        {
        }



        /// <summary>
        /// Sets the position of the shape using the provided list of parameters.
        /// </summary>
        /// <param name="list">An array of integers representing the x and y coordinates.</param>
        public virtual void set(params int[] list)
        {

            this.x = list[0];
            this.y = list[1];

        }


        /// <summary>
        /// Sets the position and vertices of a triangle shape.
        /// </summary>
        /// <param name="x">The x-coordinate of the triangle.</param>
        /// <param name="y">The y-coordinate of the triangle.</param>
        /// <param name="points">An array of Points representing the vertices of the triangle.</param>
        public virtual void setTriangle(int x, int y, Point[] points)
        {
            this.x = x;
            this.y = y;

        }


        public void Rotate(float angle)
        {
            // Rotate the shape by the specified angle
            // Example: graphics.RotateTransform(angle);
        }



        /// <summary>
        /// Abstract method for drawing the shape.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the shape.</param>
        /// <param name="brush">The Brush used to fill the shape.</param>
        public abstract void Draw(Graphics g, Pen pen, Brush brush);



        /// <summary>
        /// Overrides the ToString method to provide a string representation of the shape.
        /// </summary>
        /// <returns>A string representation of the shape's coordinates.</returns>
        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
