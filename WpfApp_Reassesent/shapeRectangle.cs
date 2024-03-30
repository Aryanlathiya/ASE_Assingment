using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp_Reassesent
{
     class shapeRectangle : Shape
    {
        private readonly string _shapeType;
        private int _penLocationX;
        private int _penLocationY;
        private Color _penColor;
        private bool _fill;
        private int _width;
        private int _height;
        private Color _fillColor;


        /// <summary>
        /// Gets the type of the shape (i.e., Rectangle).
        /// </summary>
        public override string ShapeType
        {
            get { return _shapeType; }
        }


        /// <summary>
        /// Gets or sets the x-coordinate of the pen location.
        /// </summary>
        public override int penLocationX
        {
            get { return _penLocationX; }
            set { _penLocationX = value; }
        }


        /// <summary>
        /// Gets or sets the y-coordinate of the pen location.
        /// </summary>
        public override int penLocationY
        {
            get { return _penLocationY; }
            set { _penLocationY = value; }
        }


        public override Color penColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }



        public override bool fill
        {
            get { return _fill; }
            set { _fill = value; }
        }



        public int width
        {
            get { return _width; }
            set { _width = value; }
        }


        public int height
        {
            get { return _height; }
            set { _height = value; }
        }


        public Color fillColor
        {
            get { return _fillColor; }
            set { _fillColor = value; }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeRectangle"/> class with specified properties.
        /// </summary>
        /// <param name="penLocationX">The x-coordinate of the pen location.</param>
        /// <param name="penLocationY">The y-coordinate of the pen location.</param>
        /// <param name="penColor">The color of the pen.</param>
        /// <param name="fill">A value indicating whether the shape should be filled.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="fillColor">The color used to fill the rectangle.</param>
        public shapeRectangle(int penLocationX, int penLocationY, Color penColor, bool fill, int width, int height, Color fillColor)
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
    }
}
