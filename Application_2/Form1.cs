using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Application_2
{
    public partial class Form1 : Form
    {

        private int x = 0, y = 0;
        private int lmax;
        private int lstart;
        private int lend;
        private int lcount;
        private int errorno = 0;

        //used to command partition
        private string[] elements;
        private string[] commands = new string[50];
        private int[] cParams = new int[50];
        private int[] cError = new int[50];

        //variable for looping
        private bool loopflag = false;
        private bool ifResult = false;
        private bool iffaslse = false;
        private bool check = false;

        //universal colour
        private Color pencolor = Color.Black;
        private Color brushcolor = Color.Cyan;
        private Random rndm = new Random();

        //Shape Factory
        private Shape shape1;
        private shapeFactory factory = new shapeFactory();

        private bool insideLoop = false;
        private int loopCounter = 0;


        private ArrayList Currentline = new ArrayList();
        private List<string> syntaxErrors = new List<string>();
        private SolidBrush currentBrush;

        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }




       


        public void excecuteCommand(ArrayList Currentline, string[] lines, int linecount)
        {


            int counter = 0;
            int jump = 0;


            while (lines.Length >= counter)
            {
                Graphics g = Graphics.FromImage(display.Image);
                Pen pen = new Pen(pencolor, 2);
                Brush brush = new SolidBrush(brushcolor);

                try
                {
                    if (jump != 0)
                    {
                        if (jump == counter)
                        {
                            counter++;
                            jump = 0;
                        }
                    }

                    elements = (String[])Currentline[counter];


                    switch (elements[0].ToLower())
                    {
                        
                        case "circle":

                            int radius;
                            if (!int.TryParse(elements[1], out radius))
                            {

                                radius = varCall((string)elements[1]);
                                new drawCircle(x, y, radius).Draw(g, pen, brush);
                            }
                            else if (int.TryParse(elements[1], out radius))
                            {
                                int.TryParse(elements[1], out radius);
                                new drawCircle(x, y, radius).Draw(g, pen, brush);
                            }
                            else
                            {
                                MessageBox.Show("enter a radius or use a variable", "error");
                            }
                            break;
                        case "rect":

                            int width;

                            int height;
                            if (!int.TryParse(elements[1], out width) || !int.TryParse(elements[2], out height))
                            {
                                width = varCall(elements[1]);
                                height = varCall(elements[2]);
                                new drawRectangle(x, y, width, height).Draw(g, pen, brush);

                            }
                            else
                            {
                                int.TryParse(elements[1], out width);
                                int.TryParse(elements[2], out height);
                                new drawRectangle(x, y, width, height).Draw(g, pen, brush);
                            }
                            break;
                        case "square":
                            int side;
                            if (!int.TryParse(elements[1], out side))
                            {
                                side = varCall(elements[1]);
                                new drawSquare(x, y, side).Draw(g, pen, brush);
                            }
                            else
                            {
                                int.TryParse(elements[1], out side);
                                new drawSquare(x, y, side).Draw(g, pen, brush);
                            }

                            break;
                        case "drawto":
                            int point1, point2;
                            if (!int.TryParse(elements[1], out point1) || !int.TryParse(elements[2], out point2))
                            {
                                point1 = varCall(elements[1]);
                                point2 = varCall(elements[2]);
                                g.DrawLine(pen, x, y, point1, point1);

                            }
                            else
                            {
                                int.TryParse(elements[1], out point1);
                                int.TryParse(elements[2], out point2);
                                g.DrawLine(pen, x, y, point1, point2);

                            }
                            break;
                        case "pen":
                            try
                            {
                                if (elements[1] != "rand")
                                {
                                    pencolor = Color.FromName(elements[1]);
                                }
                                else
                                {
                                    pencolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));
                                }
                            }
                            catch
                            {
                                pencolor = Color.Black;
                            }
                            break;
                        case "brush":
                            try
                            {
                                if (elements[1] != "rand")
                                {
                                    brushcolor = Color.FromName(elements[1]);
                                }
                                else
                                {
                                    brushcolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));

                                }

                            }
                            catch
                            {
                                brushcolor = Color.Black;
                            }
                            break;
                        case "triangle":
                            int p1, p2, p3;

                            if (!int.TryParse(elements[1], out p1) || !int.TryParse(elements[2], out p2) || !int.TryParse(elements[3], out p3))
                            {
                                p1 = varCall(elements[1]);
                                p2 = varCall(elements[2]);
                                p3 = varCall(elements[3]);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new drawTriangle(pnt1).Draw(g, pen, brush);
                            }
                            else
                            {
                                int.TryParse(elements[1], out p1);
                                int.TryParse(elements[2], out p2);
                                int.TryParse(elements[3], out p3);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new drawTriangle(pnt1).Draw(g, pen, brush);
                            }
                            break;
                        case "clear":
                            g.Clear(Color.Transparent);
                            g.Dispose();
                            break;

                        case "moveto":

                            if (int.TryParse(elements[1], out x) && int.TryParse(elements[2], out y))
                            {
                                int.TryParse(elements[1], out x);
                                int.TryParse(elements[2], out y);
                            }
                            else
                            {
                                x = varCall(elements[1]);
                                y = varCall(elements[2]);
                            }

                            break;

                        case "var":
                            VarCheck(elements[1], elements[2]);
                            break;

                        case "loop":
                            loopflag = true;
                            lmax = 0;
                            lcount = 0;
                            lstart = counter;

                            if (int.TryParse(elements[1], out lmax))
                            {
                                int.TryParse(elements[1], out lmax);
                            }
                            else
                            {
                                lmax = varCall(elements[1]);
                            }

                            if (lines[counter] == "end" && lcount != lmax)
                            {
                                counter = lend;
                                loopflag = false;
                                break;
                            }
                            else if (lines[counter] == "end" && lcount != lmax)
                            {
                                lcount++;
                                lend = counter++;
                                counter = lstart;
                                counter++;
                                break;

                            }
                            else
                            {
                                lcount++;
                                break;
                            }
                        case "end":
                            if (lcount == lmax || lcount > lmax)
                            {

                            }
                            else
                            {
                                counter = lstart;
                            }


                            break;
                        case "num":

                            x = rndm.Next(display.Width);
                            y = rndm.Next(display.Height);


                            brushcolor = Color.FromArgb(rndm.Next(256), rndm.Next(256), rndm.Next(256));
                            pencolor = Color.Black;

                            shape1 = factory.getShape(elements[1]);
                            if (elements[1].ToLower().Trim() == "circle")
                            {
                                radius = rndm.Next(Size.Width / 4);
                                shape1.set(x, y, radius);
                            }
                            else if (elements[1].ToLower().Trim() == "rectangle")
                            {
                                width = rndm.Next(display.Width);
                                height = rndm.Next(display.Height);
                                shape1.set(x, y, width, height);
                            }
                            else if (elements[1].ToLower().Trim() == "triangle")
                            {
                                p1 = rndm.Next(display.Width);
                                p2 = rndm.Next(display.Width);
                                p3 = rndm.Next(display.Width);
                                System.Drawing.Point pointa = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc = new System.Drawing.Point(p3, p1);
                                System.Drawing.Point[] pnt = { pointa, pointb, pointc };
                                shape1.setTriangle(x, y, pnt);
                            }
                            shape1.Draw(g, pen, brush);
                            display.Refresh();
                            break;
                        case "if":
                            int left;
                            int right;
                            string condition;
                            if (elements.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(elements[1], out left))
                                {
                                    left = varCall(elements[1]);
                                }
                                else
                                {
                                    int.TryParse(elements[1], out left);
                                }

                                if (!int.TryParse(elements[3], out right))
                                {
                                    right = varCall(elements[3]);
                                }
                                else
                                {
                                    int.TryParse(elements[3], out right);
                                }
                                condition = elements[2];
                                ifcheck(left, condition, right);
                                if (ifResult == true)
                                {

                                    jump = counter;
                                    jump++;
                                    jump++;



                                    break;
                                }
                                else
                                {

                                    counter++;

                                }




                            }

                            break;
                        case "endif":
                            jump = 0;
                            iffaslse = false;
                            break;

                        
                        case "drawcustomshape":
                            int circleSize, rectangleWidth, rectangleHeight, triangleSize;

                            if (elements.Length == 5 &&
                                int.TryParse(elements[1], out circleSize) &&
                                int.TryParse(elements[2], out rectangleWidth) &&
                                int.TryParse(elements[3], out rectangleHeight) &&
                                int.TryParse(elements[4], out triangleSize))
                            {
                                DrawComplexShape(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
                            }
                            else
                            {
                                MessageBox.Show("Invalid parameters for drawCustomShape command.", "Error");
                            }
                            break;


                        default:
                            if (elements[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (commands[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (commands[i] == elements[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(elements[1], out cParams[i]))
                                            {
                                                MessageBox.Show(elements[0] + "is all ready set to " + elements[1], "info");
                                            }
                                            else
                                            {
                                                int.TryParse(elements[1], out cParams[i]);
                                                MessageBox.Show(elements[0] + " variable is set to " + elements[1], "info");
                                            }
                                            i = 50;
                                        }
                                        else if (i != commands.Length)
                                        {
                                            i++;
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show(elements[0] + " not a Command", "Messgae");
                                }
                            }
                            break;


                    }
                    if (loopflag == true)
                    {
                        lcount++;
                    }
                    display.Refresh();

                }
                catch
                {
                }
                pen.Dispose();
                brush.Dispose();


                counter++;
            }

            display.Refresh();


        }

        

        private bool ifcheck(int left, string condition, int right) // used to check if sattment 
        {
            switch (condition)
            {

                case "=":
                    if (left == right)
                    {
                        ifResult = true;
                    }
                    else
                    {
                        ifResult = false;
                    }
                    break;
                case ">":
                    if (left > right)
                    {
                        ifResult = true;
                    }
                    else
                    {
                        ifResult = false;
                    }

                    break;
                case "<":
                    if (left < right)
                    {
                        ifResult = true;
                    }
                    else
                    {
                        ifResult = false;
                    }

                    break;
                case "!":
                    if (left != right)
                    {
                        ifResult = true;
                    }
                    else
                    {
                        ifResult = false;
                    }

                    break;

                default:
                    MessageBox.Show("condition is not correct please check", "error");

                    break;

            }

            return ifResult;
        }


        private void VarCheck(string element1, string element2)
        {
            try
            {
                int i = 0;

                if (commands[0] == null && cParams[0] == 0)
                {
                    // Set values for the first element
                    commands[0] = element1;
                    int.TryParse(element2, out cParams[0]);
                }
                else
                {
                    while (i <= 49)
                    {
                        if (commands[i] != null && commands[i].Equals(element1))
                        {
                            if (cParams[i].Equals(element2))
                            {
                                MessageBox.Show("Variable already declared", "Error");
                                return; // Exit the method if variable already declared
                            }
                        }

                        if (i == 49 || commands[i] == null)
                        {
                            // Reached the end of the array or found an empty slot
                            commands[i] = element1;
                            int.TryParse(element2, out cParams[i]);
                            return;
                        }

                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if needed
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }


         
        private int varCall(string variable)
        {
            int i = 0;
            int number = -1;
            while (49 >= i)
            {
                if (commands[i] == variable)
                {

                    number = cParams[i];
                    i = 50;
                }
                else
                {
                    i++;
                }

            }
            if (number == 0)
            {
                MessageBox.Show("not a variable", "error");
            }
            return number;

        }





        private void Commandline_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String txtdata = commandline.Text;
                if (txtdata.Trim() == "")
                {
                    MessageBox.Show("Kindly enter any command first", "ERROR");
                }
                else
                {
                    String[] line;
                    String[] lines;
                    ArrayList Currentline = new ArrayList();
                    int i = 0;

                    if (txtdata.ToLower().Trim() == "run")
                    {
                        lines = ControlePanel.Lines.ToArray();
                        while (lines.Length != i)
                        {
                            line = lines[i].Split(' ');
                            Currentline.Add(line);
                            i++;
                        }
                    }
                    else if (txtdata.ToLower().Trim() == "drawcomplexshape")
                    {
                        // Example command: drawcomplexshape 50 60 30 40
                        lines = txtdata.Split(' ');
                        if (lines.Length == 5 && lines[0].ToLower() == "drawcomplexshape")
                        {
                            int circleSize, rectangleWidth, rectangleHeight, triangleSize;
                            if (int.TryParse(lines[1], out circleSize) &&
                                int.TryParse(lines[2], out rectangleWidth) &&
                                int.TryParse(lines[3], out rectangleHeight) &&
                                int.TryParse(lines[4], out triangleSize))
                            {
                                Graphics g = Graphics.FromImage(display.Image);
                                Pen pen = new Pen(Color.Black, 2);
                                Brush brush = new SolidBrush(Color.Cyan);

                                DrawComplexShape(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);

                                // Don't forget to refresh the display after drawing
                                display.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Invalid parameters for drawcomplexshape command", "ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid command syntax", "ERROR");
                        }
                    }
                    else
                    {
                        lines = commandline.Lines.ToArray();
                        line = commandline.Text.Split(' ');
                        Currentline.Add(line);
                    }

                    int length = lines.Length;
                    // Syntax check
                    CheckSyntax(lines);

                    Check(Currentline, lines, length);
                    int L = 0;
                    Array.Clear(commands, 0, commands.Length);//used to cleare the vars array befreo exicution
                    Array.Clear(cParams, 0, cParams.Length);
                    string errors = string.Join(", ", cError.Where(x => x != 0));

                    if (check == false)
                    {
                        MessageBox.Show("Errors on lines: " + errors + ".", "error");
                    }
                    else
                    {
                        excecuteCommand(Currentline, lines, length);
                    }
                }
            }
        }


        public void Check(ArrayList currentline, string[] lines, int length)// checks the syntax of the user input
        {
            int count = 0;
            int errors = 0;
            errorno = 0;
            check = true;
            int k = 0;
            int linenumber = 0;


            while (lines.Length >= count)
            {

                errors = errorno;
                try
                {
                    elements = (String[])currentline[count];


                    switch (elements[0].ToLower())
                    {
                        case "circle":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }

                            break;

                        case "rect":
                            if (elements.Length != 3)
                            {
                                errorno++;
                            }

                            break;

                        case "square":
                            if (elements.Length != 3)
                            {
                                errorno++;
                            }
                            break;

                        case "drawto":
                            if (elements.Length != 3)
                            {
                                errorno++;
                            }

                            break;
                        case "pen":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "brushcolor":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "triangle":
                            if (elements.Length != 4)
                            {
                                errorno++;
                            }

                            break;
                        case "clear":


                            break;
                        case "movex":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "movey":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "moveto":
                            if (elements.Length != 3)
                            {
                                errorno++;
                            }


                            break;

                        case "var":

                            if (elements.Length != 3)
                            {
                                errorno++;
                            }
                            else
                            {
                                VarCheck(elements[1], elements[2]);
                            }

                            break;

                        case "loop":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }
                            break;
                        case "end":
                            if (elements.Length != 1)
                            {
                                errorno++;
                            }
                            break;
                        case "factory":
                            if (elements.Length != 2)
                            {
                                errorno++;
                            }

                            break;
                        case "if":
                            if (elements.Length != 4)
                            {
                                errorno++;
                            }

                            break;
                        case "endif":
                            if (elements.Length != 1)
                            {
                                errorno++;
                            }
                            break;
                        default:
                            if (elements[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (commands[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (commands[i] == elements[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(elements[1], out cParams[i]))
                                            {
                                                MessageBox.Show(elements[0] + "is all ready set to " + elements[1], "whoop");
                                            }
                                            else
                                            {
                                                int.TryParse(elements[1], out cParams[i]);
                                                MessageBox.Show(elements[0] + " variable is set to " + elements[1], "whoop");
                                            }
                                            i = 50;
                                        }
                                        else if (i != commands.Length)
                                        {
                                            i++;
                                        }

                                    }
                                }
                                else
                                {
                                    errorno++;
                                }
                            }
                            break;


                    }
                    if (errors != errorno)
                    {
                        linenumber = count;
                        linenumber++;
                        cError[k] = linenumber;
                        k++;
                        errors++;


                    }
                }
                catch
                {

                }
                count++;
                if (errorno != 0)
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }

        }

        private void CheckSyntax(string[] lines)
        {
            int count = 0;
            int errors = 0;
            errorno = 0;
            check = true;
            int k = 0;
            int linenumber = 0;

            while (lines.Length > count)
            {
                errors = errorno;
                try
                {
                    string[] elements = lines[count].Split(' ');

                    if (elements.Length > 0)
                    {
                        switch (elements[0].ToLower())
                        {
                            // ... (cases for various commands)

                            default:
                                if (!string.IsNullOrWhiteSpace(elements[0]))
                                {
                                    int i = 0;
                                    if (commands[0] != null)
                                    {
                                        while (i <= 49)
                                        {
                                            if (commands[i] == elements[0])
                                            {
                                                // Handle recognized command
                                                i = 50;
                                            }
                                            else if (i != commands.Length)
                                            {
                                                i++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // Handle unrecognized command
                                        errorno++;
                                        ReportSyntaxError($"Unrecognized command '{elements[0]}' at line {count + 1}.");
                                    }
                                }
                                break;
                        }
                    }
                }
                catch
                {
                    // Handle exceptions if needed
                    ReportSyntaxError($"Error parsing line {count + 1}.");
                }
                count++;
                if (errors != errorno)
                {
                    linenumber = count;
                    linenumber++;
                    cError[k] = linenumber;
                    k++;
                    errors++;
                }
            }
        }

        private void ReportSyntaxError(string errorMessage)
        {
            // You can customize this method based on how you want to handle syntax errors
            MessageBox.Show(errorMessage, "Syntax Error");
        }





        private void button2_Click(object sender, EventArgs e) //save what is in the richtextbox
        {
            MemoryStream userInput = new MemoryStream(Encoding.UTF8.GetBytes(ControlePanel.Text));

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = save.ShowDialog();
            Stream fileStream;

            if (result == DialogResult.OK)
            {

                fileStream = save.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                userInput.Close();

            }
            save.Dispose();
        }



        private void DrawComplexShape(Graphics g, Pen pen, Brush brush, int circleSize, int rectangleWidth, int rectangleHeight, int triangleSize)
        {
            // Get the center of the display
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Draw a circle
            drawCircle circle = new drawCircle(centerX, centerY, circleSize);
            circle.Draw(g, pen, brush);

            // Draw a rectangle
            drawRectangle rectangle = new drawRectangle(centerX + 40, centerY, rectangleWidth, rectangleHeight);
            rectangle.Draw(g, pen, brush);

            // Draw a triangle
            System.Drawing.Point[] trianglePoints = { new Point(centerX + 100, centerY), new Point(centerX + 150, centerY + triangleSize), new Point(centerX + 200, centerY) };
            drawTriangle triangle = new drawTriangle();
            triangle.setTriangle(centerX, centerY, trianglePoints);
            triangle.Draw(g, pen, brush);
        }


        private void DrawHouse(Graphics g, Pen pen, Brush brush, int circleSize, int rectangleWidth, int rectangleHeight, int triangleSize)
        {
            // Get the center of the display
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Draw the base of the house (rectangle)
            drawRectangle baseRectangle = new drawRectangle(centerX - rectangleWidth / 2, centerY, rectangleWidth, rectangleHeight);
            baseRectangle.Draw(g, pen, brush);

            // Draw the roof of the house (triangle)
            System.Drawing.Point[] roofPoints =
            {
        new Point(centerX - rectangleWidth / 2, centerY),
        new Point(centerX + rectangleWidth / 2, centerY),
        new Point(centerX, centerY - triangleSize)
    };
            drawTriangle roofTriangle = new drawTriangle();
            roofTriangle.setTriangle(centerX, centerY, roofPoints);
            roofTriangle.Draw(g, pen, brush);

            // Draw the door (rectangle)
            int doorWidth = rectangleWidth / 3;
            int doorHeight = rectangleHeight / 2;
            drawRectangle doorRectangle = new drawRectangle(centerX - doorWidth / 2, centerY + rectangleHeight / 2, doorWidth, doorHeight);
            doorRectangle.Draw(g, pen, brush);
        }

        private void DrawKite(Graphics g, Pen pen, Brush brush, int width, int height, int tailLength)
        {
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Points for the kite shape
            Point topPoint = new Point(centerX, centerY - height / 2);
            Point bottomPoint = new Point(centerX, centerY + height / 2);
            Point leftPoint = new Point(centerX - width / 2, centerY);
            Point rightPoint = new Point(centerX + width / 2, centerY);
            Point tailEndPoint = new Point(centerX, centerY + height / 2 + tailLength);

            // Array of points for the kite shape
            Point[] kitePoints = { topPoint, leftPoint, bottomPoint, rightPoint };

            // Draw the kite shape
            g.DrawPolygon(pen, kitePoints);
            g.FillPolygon(brush, kitePoints);

            // Draw the tail
            g.DrawLine(pen, bottomPoint, tailEndPoint);
        }


        private void DrawCar(Graphics g, Pen pen, Brush brush, int carWidth, int carHeight)
        {
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Body of the car
            Rectangle carBody = new Rectangle(centerX - carWidth / 2, centerY - carHeight / 2, carWidth, carHeight);

            // Roof of the car
            Point roofTopLeft = new Point(centerX - carWidth / 4, centerY - carHeight / 2);
            Point roofTopRight = new Point(centerX + carWidth / 4, centerY - carHeight / 2);
            Point roofBottomLeft = new Point(centerX - carWidth / 2, centerY - carHeight / 4);

            // Wheels of the car
            Rectangle wheel1 = new Rectangle(centerX - carWidth / 4 - carWidth / 10, centerY + carHeight / 4, carWidth / 5, carHeight / 5);
            Rectangle wheel2 = new Rectangle(centerX + carWidth / 4, centerY + carHeight / 4, carWidth / 5, carHeight / 5);

            // Draw the car
            g.FillRectangle(brush, carBody);
            g.DrawRectangle(pen, carBody);
            g.FillPolygon(brush, new Point[] { roofTopLeft, roofTopRight, roofBottomLeft });
            g.DrawLine(pen, roofTopLeft, roofTopRight);
            g.DrawLine(pen, roofTopLeft, roofBottomLeft);
            g.DrawLine(pen, roofTopRight, roofBottomLeft);
            g.FillEllipse(brush, wheel1);
            g.DrawEllipse(pen, wheel1);
            g.FillEllipse(brush, wheel2);
            g.DrawEllipse(pen, wheel2);
        }



        private void ExampleTask1()
        {
            // Use the existing Graphics object from the display
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Cyan);

            // Specify the sizes
            int circleSize = 50;
            int rectangleWidth = 60;
            int rectangleHeight = 30;
            int triangleSize = 40;

            // Call the DrawCustomShape method
            DrawComplexShape(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
            MessageBox.Show("Drawing completed!");


            display.Refresh();
        }

        private void ExampleTask2()
        {
            // Use the existing Graphics object from the display
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Cyan);

            // Specify the sizes
            int circleSize = 40;
            int rectangleWidth = 50;
            int rectangleHeight = 30;
            int triangleSize = 20;

            // Call the DrawCustomShape method
            DrawHouse(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
            MessageBox.Show("Drawing completed!");


            display.Refresh();
        }


        private void ExampleTask3()
        {
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Red);

            // Specify the sizes
            int kiteWidth = 60;
            int kiteHeight = 80;
            int tailLength = 20;

            // Call the DrawKite method
            DrawKite(g, pen, brush, kiteWidth, kiteHeight, tailLength);
            MessageBox.Show("Drawing completed!");


            // Refresh the display after drawing
            display.Refresh();

        }


        private void ExampleTask4() 
        {
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Blue);

            // Specify the sizes
            int carWidth = 100;
            int carHeight = 40;

            // Call the DrawCar method
            DrawCar(g, pen, brush, carWidth, carHeight);
            MessageBox.Show("Drawing completed!");

            // Refresh the display after drawing
            display.Refresh();

        }

        private void button1_Click(object sender, EventArgs e) //load file to richtextbox
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "TXT Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                ControlePanel.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
            openFile1.Dispose();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            String input = ControlePanel.Text;
            if (input.Trim() == "")
            {
                MessageBox.Show("Enter a command", "ERROR");

            }
            else
            {
                String[] line;
                String[] lines;
                ArrayList Currentline = new ArrayList();
                int i = 0;
                lines = ControlePanel.Lines.ToArray();
                while (lines.Length != i)
                {

                    line = lines[i].Split(' ');
                    Currentline.Add(line);
                    i++;
                }
                int length = lines.Length;

                Check(Currentline, lines, length);
                int L = 0;
                Array.Clear(commands, 0, commands.Length);//used to cleare the vars array befreo exicution
                Array.Clear(cParams, 0, cParams.Length);
                string errors = string.Join(", ", cError.Where(x => x != 0));


                if (check == false)
                {

                    MessageBox.Show("Error Occur in Line no. :" + errors + ".", "error");
                }
                else
                {

                    excecuteCommand(Currentline, lines, length);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void commandline_TextChanged(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ControlePanel.Text = "";
            commandline.Text = "";
        }


        // For method1Button click event
        private void method1_Click(object sender, EventArgs e)
        {
            ExampleTask1();

        }

        private void method3_Click(object sender, EventArgs e)
        {
            ExampleTask3();
        }

        private void method4_Click(object sender, EventArgs e)
        {
            ExampleTask4();
        }

        // For method2Button click event
        private void method2_Click(object sender, EventArgs e)
        {
            ExampleTask2();

        }


    }
}
