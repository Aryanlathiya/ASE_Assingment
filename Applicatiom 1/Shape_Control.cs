using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatiom_1
{
    public class Shape_Control : Draw_Shapes
    {

        /// <summary>
        /// Checks if the input string is a valid number and attempts to parse it to an integer.
        /// </summary>
        /// <param name="no">The input string to check and parse.</param>
        /// <param name="val">Output parameter that contains the parsed integer if successful.</param>
        /// <returns>Boolean value indicating if the input is a valid number.</returns>
        private Boolean checkNumber(string no, ref int val)
        {
            Boolean isNumber = false;
            if (int.TryParse(no.Trim(), out val))

                isNumber = true;
            return isNumber;

        }
        public void runCommands (string strText)
        {
            string errorMsg = string.Empty;
            string strCmd = string.Empty;
            Boolean runFlg = true;
            int commandX = 0, commandY = 0, commandZ = 0;
            string[] arrCmd = strText.ToLower().Split (new string[] {";"}, StringSplitOptions.None);
            string[] oneCmd;

            for (int i = 0; i < arrCmd.Count(); i++) 
            {
                if (arrCmd[i].Trim().ToString() != string.Empty)
                {
                    oneCmd = arrCmd[i].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < oneCmd.Count(); j++)
                    {
                        if (oneCmd[j].ToString().Trim().Equals("moveto"))
                        {
                            if (oneCmd.Count() != 3)
                            {
                                errorMsg = errorMsg + "Command " + (i + 1).ToString() + "is invalid\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j+1].Trim(), ref commandX))
                                {
                                    if (checkNumber(oneCmd[j + 2].Trim(), ref commandY))
                                    {
                                        if (runFlg)
                                        {
                                            MovePointer(commandX, commandY);
                                        }
                                    }
                                    else
                                    {
                                        errorMsg = errorMsg + "Invalid Command " + (i + 1).ToString() + "!!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + "Invalid Command " + (i + 1).ToString() + "!!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }
                        else if (oneCmd[j].ToString().Trim().Equals("drawline"))
                        {
                            if (oneCmd.Count() != 3) 
                            {
                                errorMsg = errorMsg + "Command no. " + i.ToString() + "is invalid\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j+1].Trim(), ref commandX))
                                {
                                    if (checkNumber(oneCmd[j + 2].Trim(), ref commandY))
                                    {
                                        if(runFlg)
                                        {
                                            DrawLine(commandX, commandY);
                                        }
                                    }
                                    else
                                    {
                                        errorMsg = errorMsg + "Invalid Command" + i.ToString() + "!!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + "Invalid Command" + i.ToString() + "!!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }

                        else if (oneCmd[j].ToString().Trim().Equals("pen"))
                        {
                            if (oneCmd.Count() != 2)
                            {
                                errorMsg = errorMsg + "invalid number of parameters for circle " + (i + 1).ToString() + "\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                string val = oneCmd[j + 1].Trim();
                                if (val.Equals("red"))
                                {
                                    Shape_Values.fillColor = new SolidBrush(Color.Red);
                                    Shape_Values.penColor = Color.Red;
                                }
                                else if (val.Equals("green"))
                                {
                                    Shape_Values.fillColor = new SolidBrush(Color.Green);
                                    Shape_Values.penColor = Color.Green;
                                }
                                else if (val.Equals("blue"))
                                {
                                    Shape_Values.fillColor = new SolidBrush(Color.Blue);
                                    Shape_Values.penColor = Color.Blue;
                                }
                                j = j + 1;
                            }
                        }
                        else if (oneCmd[j].ToString().Trim().Equals("drawcircle"))
                        {
                            if (oneCmd.Count() != 2 ) 
                            {
                                errorMsg = errorMsg + "Command no" + (i + 1).ToString() + "is invalid!! \n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j+1].Trim(), ref commandX))
                                {
                                    if (runFlg)
                                    {
                                        DrawCircle(commandX);
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + "Invalid Command " + (i + 1).ToString() + "!!\n";
                                    runFlg = false;
                                }
                                j = j + 1;
                            }
                        }
                        
                        else if (oneCmd[j].ToString().Trim().Equals("drawsquare"))
                        {
                            if (oneCmd.Count() != 2 )
                            {
                                errorMsg = errorMsg + "Command no" + (i + 1).ToString() + "is invalid!! \n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j + 1].Trim(), ref commandX))
                                {
                                    if (runFlg)
                                    {
                                        DrawSquare(commandX);
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + "Invalid Command " + (i + 1).ToString() + "!!\n";
                                    runFlg = false;
                                }
                                j = j + 1;
                            }
                        }
                        else if (oneCmd[j].ToString().Trim().Equals("drawrectangle"))
                        {
                            if (oneCmd.Count() != 3)
                            {
                                errorMsg = errorMsg + "Invalid argument at command " + (i + 1).ToString() + "!!! \n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j +1].Trim(), ref commandX))
                                {
                                    if (checkNumber(oneCmd[j + 2].Trim(), ref commandY))
                                    {
                                        if (runFlg)
                                        {
                                            DrawRectangle(commandX, commandY);
                                        }
                                    }
                                    else
                                    {
                                        errorMsg = errorMsg + " Invalid command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + " Invalid command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 2;
                            }
                        }
                        else if (oneCmd[j].ToString().Trim().Equals("drawtriangle"))
                        {
                            if (oneCmd.Count() != 4)
                            {
                                errorMsg = errorMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                                runFlg = false;
                                break;
                            }
                            else
                            {
                                if (checkNumber(oneCmd[j+1].Trim(), ref commandX))
                                {
                                    if (checkNumber(oneCmd[j + 2].Trim(), ref commandY))
                                    {
                                        if (checkNumber(oneCmd[j + 3].Trim(), ref commandZ))
                                        {
                                            if (runFlg)
                                            {
                                                DrawTriangle(commandX, commandY, commandZ);
                                            }
                                        }
                                        else
                                        {
                                            errorMsg = errorMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                            runFlg = false;
                                        }
                                    }
                                    else
                                    {
                                        errorMsg = errorMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                        runFlg = false;
                                    }
                                }
                                else
                                {
                                    errorMsg = errorMsg + " Invalid number at command no " + (i + 1).ToString() + "!\n";
                                    runFlg = false;
                                }
                                j = j + 3;
                            }
                        }
                        else
                        {
                            errorMsg = errorMsg + "Command no " + (i + 1).ToString() + " is invalid!\n";
                            runFlg = false;
                            break;
                        }
                    }
                }
            }
            if (errorMsg.Trim() != string.Empty)
            {
                PrintMessage(errorMsg);
            }
            if (Shape_Values.isFill)
            {
                CurrPoint(true);
            }
        }

       
    }
}
