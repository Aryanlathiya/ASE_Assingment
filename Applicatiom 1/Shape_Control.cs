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
            Boolean isNum = false;
            if (int.TryParse(no.Trim(), out val))
            {
                isNum = true;
                return isNum;
            }
        }


        public void runCommands (string strText)
        {
            string errorMsg = string.Empty;
            string strCmd = string.Empty;
            Boolean runFlg = true;
            int commandX = 0, commandY = 0, commandZ = 0;
            string[] arrCmd = strText.ToLower().Split (new string[] {";"}, StringSplitOptions.None);
            string[] oneCmd;

            for (int i = 0; i < arrCmd.Length; i++) 
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
                            }
                        }
                    }
                }
            }
        }

       
    }
}
