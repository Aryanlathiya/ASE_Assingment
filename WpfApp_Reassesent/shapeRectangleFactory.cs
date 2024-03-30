using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp_Reassesent
{

    /// <summary>
    /// Represents a factory for creating instances of rectangle shapes.
    /// </summary>
    class shapeRectangleFactory : shapeFactory
    {
        private string _shapeType;
        private int _penLocationX;
        private int _penLocationY;
        private Color _penColor;
        private bool _fill;
        private int _width;
        private int _height;
        private Color _fillColor;


        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeRectangleFactory"/> class with specified properties.
        /// </summary>
        /// <param name="penLocationX">The x-coordinate of the pen location.</param>
        /// <param name="penLocationY">The y-coordinate of the pen location.</param>
        /// <param name="penColor">The color of the pen.</param>
        /// <param name="fill">A value indicating whether the shape should be filled.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="fillColor">The color used to fill the rectangle.</param>
        public shapeRectangleFactory(int penLocationX, int penLocationY, Color penColor, bool fill, int width, int height, Color fillColor)
        {
            _shapeType = "Rectangle";
            _penLocationX = penLocationX;
            _penLocationY = penLocationY;
            _penColor = penColor;
            _fill = fill;
            _width = width;
            _height = height;
            _fillColor = fillColor;

        }



        /// <summary>
        /// Creates a new instance of a rectangle shape.
        /// </summary>
        /// <returns>A new instance of a rectangle shape.</returns>
        public override Shape GetShape()
        {
            return new shapeRectangle(_penLocationX, _penLocationY, _penColor, _fill, _width, _height, _fillColor);
        }
    }
}
