using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_2
{
    public class drawTriangle :Shape
    {
        private Point[] pnt;
        public drawTriangle(Point[] pnt)
        {

            this.pnt = pnt;
        }
        public drawTriangle() { }

        public override void setTriangle(int x, int y, Point[] points)
        {
            base.set(x, y);
            this.pnt = points;
        }
        public override void Draw(Graphics g, Pen pen, Brush brush)
        {

            g.DrawPolygon(pen, pnt);
            g.FillPolygon(brush, pnt);
        }
    }
}
