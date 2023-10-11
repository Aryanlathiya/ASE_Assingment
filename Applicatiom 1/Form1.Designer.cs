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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picDrawer1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSingalCommand = new System.Windows.Forms.Label();
            this.lblMultiCommand = new System.Windows.Forms.Label();
            this.txtMultiCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOneCommand = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            resources.ApplyResources(this.btnExecute, "btnExecute");
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // picDrawer1
            // 
            this.picDrawer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picDrawer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picDrawer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picDrawer1, "picDrawer1");
            this.picDrawer1.Name = "picDrawer1";
            this.picDrawer1.TabStop = false;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblSingalCommand
            // 
            resources.ApplyResources(this.lblSingalCommand, "lblSingalCommand");
            this.lblSingalCommand.Name = "lblSingalCommand";
            // 
            // lblMultiCommand
            // 
            resources.ApplyResources(this.lblMultiCommand, "lblMultiCommand");
            this.lblMultiCommand.Name = "lblMultiCommand";
            // 
            // txtMultiCommand
            // 
            resources.ApplyResources(this.txtMultiCommand, "txtMultiCommand");
            this.txtMultiCommand.Name = "txtMultiCommand";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtOneCommand
            // 
            resources.ApplyResources(this.txtOneCommand, "txtOneCommand");
            this.txtOneCommand.Name = "txtOneCommand";
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtOneCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMultiCommand);
            this.Controls.Add(this.lblMultiCommand);
            this.Controls.Add(this.lblSingalCommand);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.picDrawer1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecute);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picDrawer1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSingalCommand;
        private System.Windows.Forms.Label lblMultiCommand;
        private System.Windows.Forms.TextBox txtMultiCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOneCommand;
    }
}

