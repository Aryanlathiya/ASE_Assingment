using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
                    Shape_Values.isUnitTestValid = true;
                }
            }
            catch (Exception exc) 
            {
                // Handle any exceptions that occur during line drawing.
                // Print an error message with the details of the exception.
                PrintMessage("Error in DrawLine: " + exc.Message);

                // Set a flag to indicate that the unit test is not valid.
                Shape_Values.isUnitTestValid= false;
            }
        }


        //Draw a circle at the current position with the specified width.
        public void DrawCircle (int width)
        {
            try
            {
                // Calculate the coordinates of the top-left corner of the circle's bounding rectangle. 
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                
                // Create a rectangle that defines the circle's bounding box.
                currShape = new Rectangle(xpos, ypos, width, width);

                // Check if the circle shoud be filled.
                if (Shape_Values.isFill)
                {

                    // Fill the circle with the spcified fill color.
                    this.graphics.FillEllipse(Shape_Values.fillColor, currShape);

                    // Draw the outline of the circle using the current pen.
                    this.graphics.DrawEllipse(pen, xpos, ypos, width, width);

                    // Set the flag to indicate a successfull drawing operation.
                    Shape_Values.isUnitTestValid = true;
                }
            }
            catch (Exception exc)
            {
                PrintMessage ("Error in DrawCircle" +exc.Message);
                
                // Set the flag to indicate an unsuccessful drawing operation.
                Shape_Values.isUnitTestValid = false;
            }

        }


        public void DrawSquare(int width)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (width / 2);
                currShape = new Rectangle(xpos, ypos, width, width);
                if (Shape_Values.isFill) 
                {
                    this.graphics.FillRectangle(Shape_Values.fillColor, currShape);
                    this.graphics.DrawRectangle(pen, currShape);
                    Shape_Values.isUnitTestValid = true;
                }
            }
            catch ( Exception exc) 
            {
                PrintMessage("Error in DrawSquare" + exc.Message);
                Shape_Values.isUnitTestValid = false;
            }
        }


        public void DrawRectangle(int  width, int height)
        {
            try
            {
                int xpos = x - (width / 2);
                int ypos = y - (height / 2);
                currShape = new Rectangle(xpos, ypos, width, height);
                if (Shape_Values.isFill)
                {
                    this.graphics.FillRectangle(Shape_Values.fillColor, currShape);
                    this.graphics.DrawRectangle(pen, currShape);
                    Shape_Values.isUnitTestValid = true;
                }
            }
            catch (Exception exc) 
            {
                PrintMessage("Error in DrawRectangle" + exc.Message);
                Shape_Values.isUnitTestValid = false;
            }
        }

        public void MovePointer(int xpos, int ypos)
        {
            try
            {
                pen = new Pen(SystemColors.ActiveBorder, 2);
                this.graphics.DrawRectangle(pen, currPos);
                pen = new Pen(Color.Red, 2);
                currPos = GetRectangle (xpos, ypos, 2, 2);
                this.graphics.DrawRectangle (pen, currPos);
                x = Shape_Values.x = xpos;
                y = Shape_Values.y = ypos;
                pen = new Pen(Color.Black, 2);
                Shape_Values.isUnitTestValid = true;

            }
            catch (Exception exc ) 
            {
                PrintMessage("Error in MovePointer" + exc.Message);
                Shape_Values.isUnitTestValid = false;
            }
        }
        
    }
}
