// 
// Author: Sonadi Kannangara 
// Date: 28 February, 2021
// Type: Lab 3
// Description: 
// This program allows the user to enter the units shipped for seven days of 3 employees and calculates the average of each employee and the
// average of units shipped per week. If the user wants to calculate the average of another set of units 
//shipped of 3 employees, user can reset the program and enter the values again. 
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShippedByEmployee
{
    public partial class formAverageUnitsShippedByEmployee : Form
    {
        // Decalre constants. 
        const int NumberOfEmployees = 3;
        const int NumberOfDays = 7;


        //Class-level variable declarations.
        int currentDay = 1;
        int currentEmployee = 1;
        //int endTotal = 0;

        // Declare the 2D array.
        int[,] entryArray = new int[NumberOfEmployees, NumberOfDays];
        
        //Make arrays for output controls.
        TextBox[] employeeTextBoxes;
        Label[] employeeAverages;

        public formAverageUnitsShippedByEmployee()
        {
            InitializeComponent();

            // Populate the arrays of control.
            employeeTextBoxes = new TextBox[] { textBoxEntriesEmployee1, textBoxEntriesEmployee2, textBoxEntriesEmployee3 };
            employeeAverages = new Label[] { labelAverageEmployee1, labelAverageEmployee2, labelAverageEmployee3 };
            
            // Highlight the labelEmployee1Prompt label.
            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Validate the user inputs, calculate and display the average for each employee and overall average of all 3 employees from validated inputs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare constants and variables.
            const int MinimumUnits = 0;
            const int MaximumUnits = 5000;
            int endTotal = 0;

            // Validate  the entered number is a whole number.
            if (int.TryParse(textBoxEntryNumber.Text, out entryArray[currentEmployee -1, currentDay -1]))
            {
                // Validate the entered number is between 0 and 5000.
                if(entryArray[currentEmployee -1, currentDay -1] >= MinimumUnits && entryArray[currentEmployee -1, currentDay -1] <= MaximumUnits)
                {
                    employeeTextBoxes[currentEmployee - 1].Text += entryArray[currentEmployee - 1, currentDay - 1] + "\r\n";
                    textBoxEntryNumber.Clear();

                    // Check if we have entered day 7.
                    if (currentDay++ >= NumberOfDays)
                    {
                        int employeeTotal = 0;                       

                        // Calculate and display employee 1's average.
                        for (int day = 0; day < NumberOfDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee - 1, day];
                        }

                        // Display the calculated average for each employee (Round up tp 2 decimal places).
                        employeeAverages[currentEmployee - 1].Text = "Average: " + Math.Round((double)employeeTotal / NumberOfDays, 2).ToString("#,0.00");
                        
                        // Highligh the labelEmployee2.Prompt when currentEmployee is 2.
                        if (currentEmployee == 1)
                        {
                            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Regular);
                            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Bold);
                        }
                        else
                        {
                            // Highligh the labelEmployee3.Prompt when currentEmployee is 3.
                            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Regular);
                            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);
                            labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Bold);
                        }

                        // Entered upto day 7. Reset the day and go to the next employee.
                        currentDay = 1;
                        currentEmployee++;
                    }

                    // Check that user have entered all employees.
                    if(currentEmployee > NumberOfEmployees)
                    {
                        // Calculate and display the overall average.
                        for (int i = 0; i < NumberOfEmployees; i++)
                        {
                            for(int j = 0; j < NumberOfDays; j++)
                            {
                                // Add the values in the array to endTotal variable.
                                endTotal += entryArray[i, j];
                                // Display the calculated overall average of all 3 employees (round upto 2 decimal places).
                                labelAverageOutput.Text = "Average Per Day: " + Math.Round((double)endTotal / entryArray.Length ,2).ToString("#,0.00");
                            }
                        }

                        // Set currentDay =1 and currentEmployee = 1.
                        currentDay = 1;
                        currentEmployee = 1;

                        // ENtered all workers. Disable the input controls and set focus appropriately.
                        textBoxEntryNumber.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    }

                    // Set the day counter.
                    labelDay.Text = "Day " + currentDay;
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinimumUnits + " and " + MaximumUnits + "." + " Invalid Entry!");
                    textBoxEntryNumber.SelectAll();
                    textBoxEntryNumber.Focus();
                }
            }
            else
            {
                // The value entered is not an integer.
                MessageBox.Show("Entry must be a numeric value." + " Invalid Entry!");
                textBoxEntryNumber.SelectAll();
                textBoxEntryNumber.Focus();
            }          
        }

        /// <summary>
        /// Reset the form for new data entry, including resetting class variables and re-enabling controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Reset the form for new data entry, including resetting class variables and re-enabling controls.
        /// </summary>
        private void ResetForm()
        {
            // Clear the input and output fields.
            textBoxEntryNumber.Clear();
            textBoxEntriesEmployee1.Clear();
            textBoxEntriesEmployee2.Clear();
            textBoxEntriesEmployee3.Clear();
            labelAverageEmployee1.Text = String.Empty;
            labelAverageEmployee2.Text = String.Empty;
            labelAverageEmployee3.Text = String.Empty;
            labelAverageOutput.Text = String.Empty;

            // Reset the global bariables.
            currentDay = 1;
            currentEmployee = 1;
            labelDay.Text = "Day " + currentDay;

            // Reset the fomts to their default states.
            labelEmployee1Prompt.Font = new Font(this.Font, FontStyle.Bold);
            labelEmployee2Prompt.Font = new Font(this.Font, FontStyle.Regular);
            labelEmployee3Prompt.Font = new Font(this.Font, FontStyle.Regular);

            // Re-enable any controls that may be disabled.
            textBoxEntryNumber.Enabled = true;
            buttonEnter.Enabled = true;

            // Set focus for easy data entry.
            textBoxEntryNumber.Focus();
        }
    }
}
