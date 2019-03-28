using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01
{
    // Name: Ashton Becher
    // Date: January 27, 2019
    // Project: C01 - Simple Calculator
    /* Decsription: Windows form that is a basic calculator. Functions such as basic math as well
     as minimum, maximum, and square root also provided */

    public partial class simpleCalcFrm : Form
    {
        // Global variable declaration to reduce repetition in code
        int counterFunc = 0;
        int counterOp = 0;
        decimal op1 = 0;
        decimal op2 = 0;
        decimal result = 0;
        decimal roundedResult = 0;

        public simpleCalcFrm()
        {
            InitializeComponent();
        }     

        private void exitBtn_Click(object sender, EventArgs e)
        {
            String text = "Total number of Operations:\t" + counterOp.ToString() + "\n" + 
                "Total number of Functions:\t\t" + counterFunc.ToString() + "\n" +
                "Total Number of Calculations: \t" + (counterFunc + counterOp).ToString();
            String title = "Summary for Ashton Becher's Calculator";
            MessageBox.Show(text, title);
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 + op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }
        
        private void clearBtn_Click(object sender, EventArgs e)
        {
            op1TxtBox.Clear();
            op2TxtBox.Clear();
            resultTxtBox.Clear();
            op1TxtBox.Focus();
            counterFunc = 0;
            counterOp = 0;
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 - op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 * op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 / op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = Math.Min(op1, op2);
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterFunc += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = Math.Max(op1, op2);
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterFunc += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            double doubleOp1 = Convert.ToDouble(op1TxtBox.Text);
            double tempResult = Math.Sqrt(doubleOp1);
            result = Convert.ToDecimal(tempResult);
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterFunc += 1;
            op1TxtBox.Focus();
            op1TxtBox.SelectAll();
            op2TxtBox.SelectAll();
        }
    }
}
