using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicatiom_1
{
    internal class Shape_Control : Draw_Shapes
    {
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
