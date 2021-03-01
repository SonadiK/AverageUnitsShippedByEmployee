
namespace AverageUnitsShippedByEmployee
{
    partial class formAverageUnitsShippedByEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelUnitsPrompt = new System.Windows.Forms.Label();
            this.textBoxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelEmployee1Prompt = new System.Windows.Forms.Label();
            this.labelEmployee2Prompt = new System.Windows.Forms.Label();
            this.labelEmployee3Prompt = new System.Windows.Forms.Label();
            this.textBoxEntriesEmployee1 = new System.Windows.Forms.TextBox();
            this.textBoxEntriesEmployee2 = new System.Windows.Forms.TextBox();
            this.textBoxEntriesEmployee3 = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAverageEmployee1 = new System.Windows.Forms.Label();
            this.labelAverageEmployee2 = new System.Windows.Forms.Label();
            this.labelAverageEmployee3 = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.Location = new System.Drawing.Point(7, 23);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(47, 24);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "Day 1";
            // 
            // labelUnitsPrompt
            // 
            this.labelUnitsPrompt.Location = new System.Drawing.Point(7, 50);
            this.labelUnitsPrompt.Name = "labelUnitsPrompt";
            this.labelUnitsPrompt.Size = new System.Drawing.Size(47, 27);
            this.labelUnitsPrompt.TabIndex = 2;
            this.labelUnitsPrompt.Text = "&Units";
            // 
            // textBoxEntryNumber
            // 
            this.textBoxEntryNumber.Location = new System.Drawing.Point(60, 50);
            this.textBoxEntryNumber.Name = "textBoxEntryNumber";
            this.textBoxEntryNumber.Size = new System.Drawing.Size(79, 27);
            this.textBoxEntryNumber.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxEntryNumber, "Enter the units shipped");
            // 
            // labelEmployee1Prompt
            // 
            this.labelEmployee1Prompt.Location = new System.Drawing.Point(12, 89);
            this.labelEmployee1Prompt.Name = "labelEmployee1Prompt";
            this.labelEmployee1Prompt.Size = new System.Drawing.Size(133, 25);
            this.labelEmployee1Prompt.TabIndex = 4;
            this.labelEmployee1Prompt.Text = "Employee &1";
            this.labelEmployee1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee2Prompt
            // 
            this.labelEmployee2Prompt.Location = new System.Drawing.Point(161, 94);
            this.labelEmployee2Prompt.Name = "labelEmployee2Prompt";
            this.labelEmployee2Prompt.Size = new System.Drawing.Size(133, 20);
            this.labelEmployee2Prompt.TabIndex = 7;
            this.labelEmployee2Prompt.Text = "Employee &2";
            this.labelEmployee2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmployee3Prompt
            // 
            this.labelEmployee3Prompt.Location = new System.Drawing.Point(310, 94);
            this.labelEmployee3Prompt.Name = "labelEmployee3Prompt";
            this.labelEmployee3Prompt.Size = new System.Drawing.Size(133, 20);
            this.labelEmployee3Prompt.TabIndex = 10;
            this.labelEmployee3Prompt.Text = "Employee &3";
            this.labelEmployee3Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEntriesEmployee1
            // 
            this.textBoxEntriesEmployee1.Location = new System.Drawing.Point(12, 117);
            this.textBoxEntriesEmployee1.Multiline = true;
            this.textBoxEntriesEmployee1.Name = "textBoxEntriesEmployee1";
            this.textBoxEntriesEmployee1.ReadOnly = true;
            this.textBoxEntriesEmployee1.Size = new System.Drawing.Size(133, 143);
            this.textBoxEntriesEmployee1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxEntriesEmployee1, "Displays the units shipped for 7 days by Employee 1");
            // 
            // textBoxEntriesEmployee2
            // 
            this.textBoxEntriesEmployee2.Location = new System.Drawing.Point(161, 117);
            this.textBoxEntriesEmployee2.Multiline = true;
            this.textBoxEntriesEmployee2.Name = "textBoxEntriesEmployee2";
            this.textBoxEntriesEmployee2.ReadOnly = true;
            this.textBoxEntriesEmployee2.Size = new System.Drawing.Size(133, 143);
            this.textBoxEntriesEmployee2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxEntriesEmployee2, "Displays the units shipped for 7 days by Employee 2");
            // 
            // textBoxEntriesEmployee3
            // 
            this.textBoxEntriesEmployee3.Location = new System.Drawing.Point(310, 117);
            this.textBoxEntriesEmployee3.Multiline = true;
            this.textBoxEntriesEmployee3.Name = "textBoxEntriesEmployee3";
            this.textBoxEntriesEmployee3.ReadOnly = true;
            this.textBoxEntriesEmployee3.Size = new System.Drawing.Size(133, 143);
            this.textBoxEntriesEmployee3.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxEntriesEmployee3, "Displays the units shipped for 7 days by Employee 3");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(12, 344);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(86, 35);
            this.buttonEnter.TabIndex = 14;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to calculate the current units shipped");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(184, 344);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(86, 35);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to reset this form to enter new entries");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(356, 344);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(86, 35);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "Click to end the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // labelAverageEmployee1
            // 
            this.labelAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee1.Location = new System.Drawing.Point(12, 263);
            this.labelAverageEmployee1.Name = "labelAverageEmployee1";
            this.labelAverageEmployee1.Size = new System.Drawing.Size(133, 27);
            this.labelAverageEmployee1.TabIndex = 6;
            this.labelAverageEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageEmployee1, "Average Output of Employee 1");
            // 
            // labelAverageEmployee2
            // 
            this.labelAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee2.Location = new System.Drawing.Point(161, 263);
            this.labelAverageEmployee2.Name = "labelAverageEmployee2";
            this.labelAverageEmployee2.Size = new System.Drawing.Size(133, 27);
            this.labelAverageEmployee2.TabIndex = 9;
            this.labelAverageEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageEmployee2, "Average Output of Employee 2");
            // 
            // labelAverageEmployee3
            // 
            this.labelAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee3.Location = new System.Drawing.Point(310, 263);
            this.labelAverageEmployee3.Name = "labelAverageEmployee3";
            this.labelAverageEmployee3.Size = new System.Drawing.Size(133, 27);
            this.labelAverageEmployee3.TabIndex = 12;
            this.labelAverageEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageEmployee3, "Average Output of Employee 3");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(12, 304);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(431, 27);
            this.labelAverageOutput.TabIndex = 13;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAverageOutput, "Displays the calculated average of units shipped by all 3 Employees");
            // 
            // formAverageUnitsShippedByEmployee
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelAverageEmployee3);
            this.Controls.Add(this.labelAverageEmployee2);
            this.Controls.Add(this.labelAverageEmployee1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEntriesEmployee3);
            this.Controls.Add(this.textBoxEntriesEmployee2);
            this.Controls.Add(this.textBoxEntriesEmployee1);
            this.Controls.Add(this.labelEmployee3Prompt);
            this.Controls.Add(this.labelEmployee2Prompt);
            this.Controls.Add(this.labelEmployee1Prompt);
            this.Controls.Add(this.textBoxEntryNumber);
            this.Controls.Add(this.labelUnitsPrompt);
            this.Controls.Add(this.labelDay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageUnitsShippedByEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelUnitsPrompt;
        private System.Windows.Forms.TextBox textBoxEntryNumber;
        private System.Windows.Forms.Label labelEmployee1Prompt;
        private System.Windows.Forms.Label labelEmployee2Prompt;
        private System.Windows.Forms.Label labelEmployee3Prompt;
        private System.Windows.Forms.TextBox textBoxEntriesEmployee1;
        private System.Windows.Forms.TextBox textBoxEntriesEmployee2;
        private System.Windows.Forms.TextBox textBoxEntriesEmployee3;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAverageEmployee1;
        private System.Windows.Forms.Label labelAverageEmployee2;
        private System.Windows.Forms.Label labelAverageEmployee3;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

