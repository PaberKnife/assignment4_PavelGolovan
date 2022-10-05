using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4_PavelGolovan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageBoxRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resultLabel2.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            sbyte n, count;
            long result;
            count = 1;
            result = count;

            if (sbyte.TryParse(numberTextBox.Text, out n))
            {
                if (n < 0)
                {
                    MessageBox.Show("Please enter a nonnegative integer value.");
                }
                else if (n == 0)
                {
                    if (labelRadioButton.Checked == true)
                    {
                        resultLabel2.Text = "1";
                    }
                    else
                    {
                        MessageBox.Show("The factorial of the number 0 is 1.");
                    }
                }
                else if (n > 20)
                {
                    MessageBox.Show("Sorry, the number is too large for program to handle. Try something smaller.");
                }
                else
                {
                    while (count <= n)
                    {
                        result *= count;
                        count++;
                    }
                if (labelRadioButton.Checked == true)
                    {
                        resultLabel2.Text = result.ToString();
                    }
                else
                    {
                        MessageBox.Show("The factorial of the number " + n.ToString() + " is " + result.ToString() + ".");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a nonnegative integer value.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
            resultLabel2.Text = "";
            numberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
