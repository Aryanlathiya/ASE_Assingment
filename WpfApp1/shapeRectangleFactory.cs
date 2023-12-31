﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
     class shapeRectangleFactory : shapeFactory
    {
        private string _shapeType;
        private int _penLocationX;
        private int _penLocationY;
        private int _width;
        private int _height;
        private Color _penColor;
        private Color _fillColor;
        private bool _fill;

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

        public override Shape GetShape()
        {
            return new shapeRectangle(_penLocationX, _penLocationY, _penColor, _fill, _width, _height, _fillColor);
        }
    }
}
