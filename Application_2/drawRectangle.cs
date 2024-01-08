using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{


    /// <summary>
    /// Represents a rectangle shape that inherits from the Shape base class.
    /// </summary>
    public class drawRectangle : Shape
    {
        private int width;
        private int height;



        /// <summary>
        /// Constructor for initializing the rectangle with specified coordinates, width, and height.
        /// </summary>
        /// <param name="x">The x-coordinate of the rectangle.</param>
        /// <param name="y">The y-coordinate of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public drawRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;
        }


        /// <summary>
        /// Default constructor for the rectangle.
        /// </summary>
        public drawRectangle() { }



        /// <summary>
        /// Sets the position, width, and height of the rectangle using the provided list of parameters.
        /// </summary>
        /// <param name="list">An array of integers representing the x-coordinate, y-coordinate, width, and height.</param>
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }




        /// <summary>
        /// Draws the rectangle using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the rectangle.</param>
        /// <param name="brush">The Brush used to fill the rectangle.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            g.FillRectangle(brush, x, y, width, height);
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}
