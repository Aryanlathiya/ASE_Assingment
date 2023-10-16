using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatiom_1
{
    public class Shape_Values
    {
        static Color _penColor;
        static Boolean _isUnitTestValid;
        static Boolean _isFill;
        static SolidBrush _fillColor;
        static private Bitmap _newPicture = new Bitmap(640, 480);
        private static int _x;
        private static int _y;

        public static Color penColor
        {
            get { return _penColor; }
            set { _penColor = value; }
        }

        public static Boolean IsUnitTestValid
        {
            get { return _isUnitTestValid; }
            set { _isUnitTestValid = value; }

        }

        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set { _isFill = value;}
        }

        public static SolidBrush fillColor
        {
            get
            {
                return _fillColor;
            }
            set { _fillColor = value; }
        }

        public static Bitmap newPicture
        {
            get
            {
                return _newPicture;
            }
            set { _newPicture = value; }
        }

        public static int x
        {
            get
            {
                return _x;
            }
            set { _x = value; }
        }

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
