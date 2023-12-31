﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatiom_1
{
    public class Shape_Values
    {

        // Variables declare.
        static Color _penColor; // Stores the pen color used for drawing shapes.
        static Boolean _isUnitTestValid; // Indicate whether the unit tests for the application are valid.
        static Boolean _isFill; // Indicate whether shapes should be filled (true) or not (false).
        static SolidBrush _fillColor; // Stores the fill color for filled shapes.
        static private Bitmap _newPicture = new Bitmap(640, 480); // Stores a bitmap for drawing shapes, with an initial size of 640 * 480.
        private static int _x; // Stores the X coordinate for positioning shapes.
        private static int _y; // Stores the Y coordinate for positioning shapes.



        /// <summary>
        /// Provides access to the color of the pen used for drawing.
        /// </summary>
        // Property to access and modify the pen color used for drawing shapes.
        public static Color penColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }


        /// <summary>
        /// Provides access to the unit test validity status.
        /// </summary>
        // Property to access and modify the unit test validity status.
        public static Boolean isUnitTestValid
        {
            get { return _isUnitTestValid; }
            set { _isUnitTestValid = value; }

        }


        /// <summary>
        /// Provides access to the fill status for shapes.
        /// </summary>
        // Property to access and modify the fill status for shapes.
        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set { _isFill = value;}
        }


        /// <summary>
        /// Provides access to the fill color for filled shapes.
        /// </summary>
        // Property to access and modify the fill color for filled shapes.
        public static SolidBrush fillColor
        {
            get
            {
                return _fillColor;
            }
            set { _fillColor = value; }
        }


        /// <summary>
        /// Provides access to the bitmap used for drawing shapes.
        /// </summary>
        // Property to access and modify the bitmap used for drawing shapes.
        public static Bitmap newPicture
        {
            get
            {
                return _newPicture;
            }
            set { _newPicture = value; }
        }

        /// <summary>
        /// Provides access to the X coordinate for positioning shapes.
        /// </summary>
        // Property to access and modify the X coordinate for positioning shapes.
        public static int x
        {
            get
            {
                return _x;
            }
            set { _x = value; }
        }


        /// <summary>
        /// Provides access to the Y coordinate for positioning shapes.
        /// </summary>
        // Property to access and modify the Y coordinate for  positioning shapes.
        public static int y
        {
            get
            {
                return _y;
            }
            set { _y = value; }
        }

    }
}
