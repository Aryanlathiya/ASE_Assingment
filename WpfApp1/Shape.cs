using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace WpfApp1
{
    public abstract class Shape
    {
        public abstract string shapeType { get; }

        public abstract string penLocationX { get; set;}

        public abstract string penLocationY { get; set;}

        public abstract Color penColor { get; set;}    

        public abstract bool fill {  get; set;}
    }
}
