using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Reassesent
{
    /// <summary>
    /// Represents an abstract factory for creating instances of shapes.
    /// </summary>
    abstract class shapeFactory
    {


        /// <summary>
        /// Gets a shape instance created by the factory.
        /// </summary>
        /// <returns>A shape instance.</returns>

        public abstract Shape GetShape();
    }
}
