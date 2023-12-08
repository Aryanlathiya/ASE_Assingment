using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{
    internal class drawSquare : drawRectangle
    {
        readonly int size;
        public drawSquare(int x, int y, int size) : base(x, y, size, size)
        {

            this.size = size;
        }


        public override void Draw(Graphics g, Pen pen, Brush brush)
        {
            base.Draw(g, pen, brush);
        }
    }
}
