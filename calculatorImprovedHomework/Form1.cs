using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorImprovedHomework
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayBox.Text = "0";
        }

        private void UpdateDisplay(string value)
        {
            if (displayBox.Text == "0")
            {
                displayBox.Text = value;
            }
            else
            {
                displayBox.Text += value;
            }

            // Move caret to the end and scroll to it
            displayBox.SelectionStart = displayBox.Text.Length;
            displayBox.ScrollToCaret();
        }

        private void one_Click(object sender, EventArgs e)
        {
            UpdateDisplay("1");
        }

        private void two_Click(object sender, EventArgs e)
        {
            UpdateDisplay("2");
        }

        private void three_Click(object sender, EventArgs e)
        {
            UpdateDisplay("3");
        }

        private void four_Click(object sender, EventArgs e)
        {
            UpdateDisplay("4");
        }

        private void five_Click(object sender, EventArgs e)
        {
            UpdateDisplay("5");
        }

        private void six_Click(object sender, EventArgs e)
        {
            UpdateDisplay("6");
        }

        private void seven_Click(object sender, EventArgs e)
        {
            UpdateDisplay("7");
        }

        private void eight_Click(object sender, EventArgs e)
        {
            UpdateDisplay("8");
        }

        private void nine_Click(object sender, EventArgs e)
        {
            UpdateDisplay("9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (displayBox.Text != "0")
            {
                UpdateDisplay("0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayBox.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            UpdateDisplay(".");
        }

        private void leftArr_Click(object sender, EventArgs e)
        {
            if (displayBox.Text != "0")
            {
                displayBox.Text = displayBox.Text.Substring(0, displayBox.Text.Length - 1);
            }

            if (displayBox.Text == "")
            {
                displayBox.Text = "0";
            }

            // Move caret to the end and scroll to it
            displayBox.SelectionStart = displayBox.Text.Length;
            displayBox.ScrollToCaret();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            UpdateDisplay("+");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            UpdateDisplay("-");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            UpdateDisplay("*");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            UpdateDisplay("/");
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                displayBox.Text = (table.Compute(displayBox.Text, null)).ToString();

                if (displayBox.Text == "∞")
                {
                    displayBox.Text = "0";
                    MessageBox.Show("Division by zero is not allowed");
                }
            }
            catch (SyntaxErrorException)
            {
                displayBox.Text = "0";
                MessageBox.Show("There is a syntax error in the expression.");
            }
            catch (EvaluateException)
            {
                displayBox.Text = "0";
                MessageBox.Show("There was an error in evaluating the expression.");
            }
            catch (Exception ex)
            {
                displayBox.Text = "0";
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }

            // Move caret to the end and scroll to it after evaluation
            displayBox.SelectionStart = displayBox.Text.Length;
            displayBox.ScrollToCaret();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
