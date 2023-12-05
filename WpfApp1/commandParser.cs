using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1
{
    public class commandParser
    {
        string Command = "";
        int penLocationX = 0;
        int penLocationY = 0;
        Color penColor = Colors.Black;
        bool fill = false;
        String invalidCommand = "This is invalid Command";
        String invalidArgu = "This Command has invalid Parameters";



        public void setCommandParser(string command)
        {
            if (CheckCommand(command) == true)
            {
                this.Command = command;
            }
            else
            {
                this.Command = "";
            }
        }


        public bool CheckCommand(String command)
        {
            if(commandIsValid(command) == true && commandHasValidArgs(command == true)
            {
                return true;
            }
            else if (commandIsValid(command) == true && commandHasValidArgs(command) == false)
            {
                invalidCommand(invalidArgu, 10.00, 30.00);
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool commandIsValid(String command)
        {
            if (command.StartsWith("moveto") ||
                command.StartsWith("drawto") ||
                command.StartsWith("clear") ||
                command.StartsWith("reset") ||
                command.StartsWith("rectangle") ||
                command.StartsWith("circle") ||
                command.StartsWith("triangle") ||
                command.StartsWith("pen") ||
                command.StartsWith("fill"))
            {
                return true;
            }
            else
            {
                inValidCommand(invalidcommand, 10.00, 10.00);
                return false;
            }
        }


        public bool commandHasValidArgs(String command)
        {
            if (command.StartsWith("moveto"))
            {
                return checkmoveto(command);
            }
            else if (command.StartsWith("drawto"))
            {
                return checkdrawto(command);
            }
            else if (command.StartsWith("clear"))
            {
                return checkclear(command);
            }
            else if (command.StartsWith("reset"))
            {
                return checkreset(command);
            }
            else if (command.StartsWith("rectangle"))
            {
                return checkrectangle(command);
            }
            else if (command.StartsWith("circle"))
            {
                return checkcircle(command);
            }
            else if (command.StartsWith("triangle"))
            {
                return checktriangle(command);
            }
            else if (command.StartsWith("pen"))
            {
                return checkpen(command);
            }
            else if (command.StartsWith("fill"))
            {
                return checkfill(command);
            }
            else
            {
                inValidCommand(invalArg, 10.00, 30.00);
                return false;
            }

        }

        public void executeCommand()
        {
            if(this.Command != "")
            {
                string[] commands = this.Command.Split(' ');
                switch (commands[0])
                {
                    case("moveto");
                        drawMoveto(commands);
                        break;
                    case("drawto");
                        drawDrawto(commands); break;
                    case ("clear");
                        drawClear();
                        break;
                    case("reset");
                        drawReset();
                        break;
                    case ("rectangle");
                        drawRectangle(commands); break;
                    case ("circle");
                        drawCircle(commands); break;
                    case ("triangle");
                        drawTriangle(commands); break;
                    case ("pen");
                        drawPen(commands); break;
                    case ("fill");
                        drawFill(commands); break;
                }

            }
        }

    }
}
