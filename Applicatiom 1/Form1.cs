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
                
            }
            cmbFill.SelectedIndex = 0;
            txtOneCommand.Focus();

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
                if(cmbFill.SelectedItem.ToString() != "None")
                {
                    Shape_Values.isFill = true;
                    foreach (KnownColor kColor in Enum.GetValues(typeof(KnownColor)))
                    {
                        Color knownColor = Color.FromKnownColor(kColor);
                        if (cmbFill.SelectedItem.ToString().Trim() == knownColor.Name.Trim())
                        {
                            Shape_Values.fillColor = new SolidBrush(knownColor);
                            Shape_Values.penColor = knownColor;
                            break;
                        }
                    }
                }
                if(txtOneCommand.Text.Trim() != string.Empty) 
                    draw.runCommands(txtOneCommand.Text.Trim());
                else
                    draw.PrintMessage("Please give me a command !!");
                

                txtOneCommand.Text = string.Empty;
                Refresh(); 
                txtOneCommand.Focus();
                Shape_Values.isFill = false;

            }
        }

        public override void Refresh()
        {
            picDrawer1.Image = Shape_Values.newPicture;
        }

        private void btnExecute_Click (object sender, EventArgs e) 
        {
            if (cmbFill.SelectedItem.ToString() != "None") 
            {
                Shape_Values.isFill= true;
                foreach (KnownColor kColor in Enum.GetValues(typeof(KnownColor)))
                {
                    Color knownColor= Color.FromKnownColor(kColor);
                    if (cmbFill.SelectedItem.ToString().Trim() == knownColor.Name.Trim())
                    {
                        Shape_Values.fillColor = new SolidBrush(knownColor);
                        Shape_Values.penColor = knownColor;
                        break;
                    }
                }
            }
            Boolean flage = false;
            if(txtMultiCommand.Text.Trim() != string.Empty)
            {
                draw.runCommands(txtMultiCommand.Text.Trim());
                txtMultiCommand.Focus();
                txtMultiCommand.Text = string.Empty;
                flage = true;
            }
            if (txtOneCommand.Text.Trim() != string.Empty)
            {
                draw.runCommands(txtOneCommand.Text.Trim());
                txtOneCommand.Focus();
                txtOneCommand.Text = string.Empty;
                flage = true;
            }
            if (!flage)
            {
                draw.PrintMessage("Please give me any command !!");
                txtOneCommand.Focus();
            }
            Refresh();
            Shape_Values.isFill = false;
        }

        private void btnClear_Click(object sender, EventArgs e) 
        {
            Shape_Values.newPicture = new Bitmap(640, 480);
            draw = new Shape_Control();
            draw.CurrPoint(true);
            Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Shape_Values.newPicture = new Bitmap(640, 480);
            draw = new Shape_Control();
            draw.CurrPoint(false);
            Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG|*.jpeg";
            saveFileDialog.Title = "Assingment1";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "" && Shape_Values.newPicture != null)
            {
                Shape_Values.newPicture.Save(saveFileDialog.FileName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit =  new Bitmap (openFileDialog.FileName);
                picDrawer1.Image = bit;
                picDrawer1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

    }
}
