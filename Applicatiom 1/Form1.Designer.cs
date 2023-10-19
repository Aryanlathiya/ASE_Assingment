using System;

namespace Applicatiom_1
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picDrawer1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtMultiCommand = new System.Windows.Forms.TextBox();
            this.txtOneCommand = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.cmbFill = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // picDrawer1
            // 
            this.picDrawer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.picDrawer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picDrawer1, "picDrawer1");
            this.picDrawer1.Name = "picDrawer1";
            this.picDrawer1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // txtMultiCommand
            // 
            this.txtMultiCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.txtMultiCommand, "txtMultiCommand");
            this.txtMultiCommand.Name = "txtMultiCommand";
            this.txtMultiCommand.TextChanged += new System.EventHandler(this.txtMultiCommand_TextChanged);
            // 
            // txtOneCommand
            // 
            resources.ApplyResources(this.txtOneCommand, "txtOneCommand");
            this.txtOneCommand.Name = "txtOneCommand";
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Name = "textBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMultiCommand);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picDrawer1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOneCommand);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExecute);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnReset);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cmbFill
            // 
            this.cmbFill.FormattingEnabled = true;
            resources.ApplyResources(this.cmbFill, "cmbFill");
            this.cmbFill.Name = "cmbFill";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbFill);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picDrawer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMultiCommand;
        private System.Windows.Forms.TextBox txtOneCommand;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbFill;

        public EventHandler picDrawer1_Click { get; private set; }
    }
}

