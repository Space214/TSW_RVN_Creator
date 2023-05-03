using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TSW3_RVN_Creator
{
    public partial class Form1 : Form
    {
        private string[] linesInput; // The array for the entered numbers

        private string unrealEngineString; // The variable that holds the created text for UE4

        List<int> unitNumbers = new List<int>(); // Creates a list for the unit numbers

        string allowedChars = @"^[0-9\-\,]+$"; // Allows only certain characters to be used in the numbers

        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Resets most the vars
            linesInput = new string[0];
            unitNumbers = new List<int>();

            linesInput = NumberEnter_TB.Text.Split('\n'); // Splits up the lines based on the line breaks

            // Trims off some annoying chars >:(
            for (int x = 0; x < linesInput.Length; x++)
            {
                linesInput[x] = linesInput[x].Trim('\r');
                linesInput[x] = linesInput[x].Replace(" ", "");
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
                            // makes an array to split between the ranges before counting between them, also triming out ,
                            string[] range = line.Replace(',', '\0').Split('-'); 
                            int start = int.Parse(range[0]);
                            int end = int.Parse(range[1]);
                            for (int i = start; i <= end; i++)
                            {
                                unitNumbers.Add(i);
                            }
                        }
                        else if (line.Contains(","))
                        {
                            // makes an array to split between the , before adding between them, also triming out -
                            string[] numbers = line.Replace('-', '\0').Split(',');

                            for (int i = 0; i < numbers.Length; i++)
                            {
                                unitNumbers.Add(int.Parse(numbers[i]));
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

        // Things past here I don't know how to remove
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberEnter_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Generated_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
