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
            draw.CurrPoint(false);
            Refresh();
            cmbFill.Items.Add("None");
            foreach (KnownColor kColor in Enum.GetValues(typeof(KnownColor))) 
            {
                Color knownColor = Color.FromKnownColor(kColor);
                cmbFill.Items.Add(knownColor.Name);
                cmbFill.SelectedIndex = 0;
                txtOneCommand.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMultiCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void picDrawer1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(Shape_Values.newPicture, 0, 0);
        }

        private void txtOneCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if(cmbFill.SelectedIndex.ToString() != "None")
                {
                    Shape_Values.isFill = true;
                    foreach (KnownColor kColor in Enum.GetValues(typeof(KnownColor)))
                    {
                        Color knownColor = Color.FromKnownColor(kColor);
                        if (cmbFill.SelectedIndex.ToString().Trim() == knownColor.Name.Trim())
                        {
                            Shape_Values.fillColor = new SolidBrush(knownColor);
                            Shape_Values.penColor = knownColor;
                            break;
                        }
                    }
                }
                if(txtOneCommand.Text.Trim() != string.Empty) 
                {
                    // Will implement runCommands 
                    draw.runCommands(txtOneCommand.Text.Trim());

                }
                else
                {
                    draw.PrintMessage("Please give me a command !!");
                }

                txtOneCommand.Text = string.Empty;
                Refresh(); // Will implement Refresh
                txtOneCommand.Focus();
                Shape_Values.isFill = false;

            }
        }



    }
}
