using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{


    /// <summary>
    /// Represents a square shape that inherits from the drawRectangle class.
    /// </summary>
    internal class drawSquare : drawRectangle
    {
        readonly int size;


        /// <summary>
        /// Constructor for initializing the square with specified coordinates and size.
        /// </summary>
        /// <param name="x">The x-coordinate of the square.</param>
        /// <param name="y">The y-coordinate of the square.</param>
        /// <param name="size">The size of the square (width and height are equal).</param>
        public drawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }




        /// <summary>
        /// Draws the square using the specified Graphics object, Pen, and Brush.
        /// </summary>
        /// <param name="g">The Graphics object used for drawing.</param>
        /// <param name="pen">The Pen used to outline the square.</param>
        /// <param name="brush">The Brush used to fill the square.</param>
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }
    }
}
