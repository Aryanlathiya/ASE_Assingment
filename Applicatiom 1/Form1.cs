using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatiom_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        Shape_Control draw;

        public Form()
        {
            InitializeComponent();
            Shape_Values.x = Shape_Values.y = 0;
            draw = new Shape_Control();
            draw.


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMultiCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void picDrawer1_Paint(object sender, EventArgs e)
        {
            Graphics g = e.Graphics;
        }
    }
}
