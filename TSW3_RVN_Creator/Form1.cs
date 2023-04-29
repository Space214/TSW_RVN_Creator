using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TSW3_RVN_Creator
{
    public partial class Form1 : Form
    {
        private string stringInput;
        private string[] linesInput;

        private string unrealEngineString;

        List<int> unitNumbers = new List<int>();

        string allowedChars = @"^[0-9\-]+$";

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberEnter_TB_TextChanged(object sender, EventArgs e)
        {
            stringInput = NumberEnter_TB.Text;
        }

        private void Generated_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Resets most the vars
            linesInput = new string[0];
            unitNumbers = new List<int>();

            stringInput = NumberEnter_TB.Text; // Sets the stringInput

            linesInput = stringInput.Split('\n'); // Splits up the lines based on the line breaks

            // Trims off some annoying chars >:(
            for (int x = 0; x < linesInput.Length; x++)
            {
                linesInput[x] = linesInput[x].Trim('\r');
                linesInput[x] = linesInput[x].Trim(' ');
            }

            // Idiot proofing
            if (linesInput.Length != 0)
            {
                // Goes through each line
                foreach (string line in linesInput)
                {
                    // Idiot proofing 2
                    if (Regex.IsMatch(line, allowedChars))
                    {
                        // Checks if it's a number range or not
                        if (line.Contains("-"))
                        {
                            // makes an array to split between the ranges before counting between them
                            string[] range = line.Split('-'); 
                            int start = int.Parse(range[0]);
                            int end = int.Parse(range[1]);
                            for (int i = start; i <= end; i++)
                            {
                                unitNumbers.Add(i);
                            }
                        }
                        else
                        {
                            // Simply adds the number to the array
                            int num = int.Parse(line);
                            unitNumbers.Add(num);
                        }
                    }
                }

                int commaCount = 0; // makes a counter for the commas

                Generated_TB.Text = ""; // resets the Generated text box

                unrealEngineString = "("; // resets the string and adds the first char

                // Counts through and adds each unit number to the list
                foreach (int num in unitNumbers)
                {
                    unrealEngineString = unrealEngineString + '"' + num + '"';

                    // adds commas as needed
                    commaCount++;
                    if (commaCount < unitNumbers.Count)
                    {
                        unrealEngineString = unrealEngineString + ',';
                    }
                }

                unrealEngineString = unrealEngineString + ")"; // adds the final char

                Generated_TB.Text = unrealEngineString; // outputs the generated string
            }
        }
    }
}
