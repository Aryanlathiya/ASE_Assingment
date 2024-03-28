using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reassessment_Part_2
{
    public class commandParser
    {
        String Command = "";
        int penLocationX = 0;
        int penLocationY = 0;
        Color penColor = Color.Black;
        bool fill = false;
        String invalidcommand = "This is invalid command";
        String invalArg = "This command has invalid parameters";
        /// <summary>
        /// This is command parser set method
        /// </summary>
        /// <param name="command"></param>
        public void setCommandParser(string command)
        {
            if (checkCommand(command) == true)
            {
                this.Command = command;
            }
            else
            {
                this.Command = "";
            }
        }


    }
}
