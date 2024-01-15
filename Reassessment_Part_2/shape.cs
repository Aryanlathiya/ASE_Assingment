using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reassessment_Part_2
{
    public abstract class shape
    {
        public abstract string ShapeType { get; }
        public abstract int penLocationX { get; set; }
        public abstract int penLocationY { get; set; }
        public abstract Color penColor { get; set; }
        public abstract bool fill { get; set; }
    }
}
