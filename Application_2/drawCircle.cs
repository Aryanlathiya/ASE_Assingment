using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{

    /// <summary>
    /// Represents a circle shape that inherits from the Shape base class.
    /// </summary>
    public class drawCircle : Shape
    {
        int radius;




        /// <summary>
        /// Constructor for initializing the circle with specified coordinates and radius.
        /// </summary>
        /// <param name="x">The x-coordinate of the circle.</param>
        /// <param name="y">The y-coordinate of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public drawCircle(int x, int y, int radius) : base(x, y)
        {

            this.radius = radius;
        }


        /// <summary>
        /// Constructor for initializing the circle with a specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        public drawCircle(int radius)
        {
            this.radius = radius;
        }



        /// <summary>
        /// Default constructor for the circle.
        /// </summary>
        public drawCircle() : base()
        {
        }



        /// <summary>
        /// Draws the circle using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the circle.</param>
        /// <param name="brush">The Brush used to fill the circle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {


            g.FillEllipse(brush, x, y, radius * 2, radius * 2);
            g.DrawEllipse(pen, x, y, radius * 2, radius * 2);

        }


        /// <summary>
        /// Sets the position and radius of the circle using the provided list of parameters.
        /// </summary>
        /// <param name="list">An array of integers representing the x-coordinate, y-coordinate, and radius.</param>
        public override void set(params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.set(list[0], list[1]);
            this.radius = list[2];

        }



        /// <summary>
        /// Overrides the ToString method to provide a string representation of the circle.
        /// </summary>
        /// <returns>A string representation of the circle's coordinates and radius.</returns>
        public override string ToString()
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}
