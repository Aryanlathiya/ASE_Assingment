using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp_Reassesent
{


    /// <summary>
    /// The Shape Factory. For shapes such as Point, Line, Polygon, Circle, etc.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Gets the type of the shape.
        /// </summary>
        public abstract string ShapeType { get; }

        /// <summary>
        /// Gets or sets the x-coordinate of the pen location.
        /// </summary>
        public abstract int penLocationX { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of the pen location.
        /// </summary>
        public abstract int penLocationY { get; set; }

        /// <summary>
        /// Gets or sets the color of the pen.
        /// </summary>
        public abstract Color penColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the shape should be filled.
        /// </summary>
        public abstract bool fill { get; set; }
    }
}
