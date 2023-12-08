using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_2
{
    public partial class Form1 : Form
    {

        private int x = 0;
        private int y = 0;

        // for looping 
        private int loopmax;
        private int loopstart;
        private int loopfinish;
        private int loopcount;
        private int errorno = 0;

        // for partition
        private string[] splitw;
        private string[] parm = new string[50];
        private int[] strSplit = new int[50];
        private int[] strError = new int[50];

        // universal color
        private Color pencolor = Color.Black;
        private Color brushcolor = Color.Cyan;
        private Random rndm = new Random();


        // flag bits
        private bool lbit = false;
        private bool ifrslt = false;
        private bool strif = false;
        private bool condn = false;

        // Shape Factory
        private Shape shape1;
        private shapeFactory factory = new shapeFactory();




        public Form1()
        {
            InitializeComponent();
       
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void VarCheck(string element1, string  element2)
        {
            int i = 0;
            try
            {
                if (parm[0] == null && strSplit[0] == 0)
                {
                    parm[0] = element1;
                    int.TryParse(element2, out strSplit[0]);
                }
                else
                {
                    while(49 >= 1)
                    {
                        if (parm[i].Equals(element1))
                        {
                            if (strSplit[i].Equals(element2))
                            {
                                MessageBox.Show("Variable already declared", "Error");

                                i = parm.Length;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else if (i >= parm.Length)
                        {
                            i++;
                        }
                        else
                        {
                            parm[i++] = element1;
                            int.TryParse(element2, out strSplit[i]);
                        }
                        
                    }
                }
            }
            catch { }
        }

        private int varCall (string variable)
        {
            int i = 0;
            int number = -1;
            while (49 >= 1)
            {
                if (parm[i] == variable)
                {
                    number = strSplit[i];
                    i = 50;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
