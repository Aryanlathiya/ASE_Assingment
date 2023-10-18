using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatiom_1
{
    internal class Draw_Shapes
    {

        // Variables Declaration

        int x, y; // Declare integer variables 'X' and 'Y' to store the current coordinates.
        Pen pen; // Declare a 'Pen' object to define the drawing chatacteristics, such as color and width.
        Graphics graphics; // Declare a 'Graphics' object to interact with the drawing surface and perform various drawing operations.
        Rectangle currPos; // Declare a 'Rectangle' variable 'currPos' to represent the current position or area of interest.
        Rectangle currShape; // Declare a 'Rectangle' variable 'currShape' to represent the current shape being draw or manipulated.


        // Constructor for the 'Draw_Shapes' class.
        public Draw_Shapes() 
        {
            // Initialize a 'Graphics' instance using the 'Bitmap' from 'Shape_Values.newPicture'.
            this.graphics = Graphics.FromImage(Shape_Values.newPicture);
            // Initialize a 'Pen' with a black color and a width of 1.
            pen = new Pen(Color.Black,1);
            // Assign the value of 'X' and 'Y' from the 'Shape_Values' class using getter methods.
            x = Shape_Values.x;
            y = Shape_Values.y;
        }

        // Print a message on the graphics context
        // The message to be displayed.
        public void PrintMessage (string msg)
        {
            try
            {
                //Create a new font with Arial family and size 15.
                using (Font myFonts = new Font("Arial", 15))
                {
                    // Draw the message on the graphics context at position (5, 5) using a black brush. 
                    graphics.DrawString(msg, myFonts, Brushes.Black, new Point(5, 5));
                }
            }
            catch (Exception exc) 
            {
                // Handle and log any exceptions that occur during message printing.
                Console.WriteLine("Error in PrintMessage: " + exc.Message);
            }

        }


        // Draw a line on the graphics context from the current position to the specified position.
        public void DrawLine(int xpos, int ypos)
        {
            try
            {
                // Check if the shape should be filled.
                if (Shape_Values.isFill)
                {
                    // Create a Pen with the specified pen coloe and a width of 1.
                    pen = new Pen(Shape_Values.penColor, 1);
                    // Draw a line on the graphics context from the current position (x, y) to the specified position (xpos, ypos).
                    this.graphics.DrawLine(pen , x, y, xpos, ypos);
                }
                else
                {
                    // Draw a line on the graphics context from the current position (x, y) to the specified position (xpos, ypos).
                    this.graphics.DrawLine(pen, x, y, xpos, ypos);

                    // Reset the Pen to the default color (black) and a width of 1.
                    pen = new Pen(Color.Black, 1);

                    // Set a flag to indicate that the unit test is valid.
                    Shape_Values.IsUnitTestValid = true;
                }
            }
            catch (Exception exc) 
            {
                // Handle any exceptions that occur during line drawing.
                // Print an error message with the details of the exception.
                PrintMessage("Error in DrawLine: " + exc.Message);

                // Set a flag to indicate that the unit test is not valid.
                Shape_Values.IsUnitTestValid= false;
            }
        }
        
    }
}
