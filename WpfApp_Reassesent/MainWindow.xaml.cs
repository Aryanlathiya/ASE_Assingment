﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Reassesent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CommandParser cmdParser = new CommandParser();

        public MainWindow()
        {
            InitializeComponent();
            txtCommand.Focus();

        }


        /// <summary>
        /// This Button Execute the Single line command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            if (txtCommand.Text.Trim() == "run")
            {
                foreach (string command in txtProgram.Text.Split('\n'))
                {
                    cmdParser.setCommandParser(command.Trim());
                    cmdParser.executeCommand();
                    txtOutput.Text = txtOutput.Text + "\n" + command.Trim();
                }
                txtCommand.Text = "";
            }
            else
            {
                //now we execute the above command
                cmdParser.setCommandParser(txtCommand.Text);
                cmdParser.executeCommand();
                txtOutput.Text = txtOutput.Text + "\n" + txtCommand.Text;
                txtCommand.Text = "";
                e.Handled = true;
            }

        }

        /// <summary>
        /// This Button Save the Command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            String filepath = ".\\" + "MyProgram_" + DateTime.Now.Ticks.ToString() + ".txt";
            File.WriteAllText(filepath, txtProgram.Text);
        }
        /// <summary>
        /// This Button redirect to the saved commad file and select the pervious saved file and 
        /// load the previous command 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtProgram.Text = File.ReadAllText(openFileDialog.FileName);
        }
        /// <summary>
        /// This is single line command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCommand_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (txtCommand.Text.Trim() == "run")
                {
                    foreach (string command in txtProgram.Text.Split('\n'))
                    {
                        cmdParser.setCommandParser(command.Trim());
                        cmdParser.executeCommand();
                        txtOutput.Text = txtOutput.Text + "\n" + command.Trim();
                    }
                    txtCommand.Text = "";
                }
                else
                {
                    //now we execute the above command
                    cmdParser.setCommandParser(txtCommand.Text);
                    cmdParser.executeCommand();
                    txtOutput.Text = txtOutput.Text + "\n" + txtCommand.Text;
                    txtCommand.Text = "";
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// This button run the multiline commad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            foreach (string command in txtProgram.Text.Split('\n'))
            {
                cmdParser.setCommandParser(command.Trim());
                cmdParser.executeCommand();
                txtOutput.Text = txtOutput.Text + "\n" + command.Trim();
            }
        }
    }
}
