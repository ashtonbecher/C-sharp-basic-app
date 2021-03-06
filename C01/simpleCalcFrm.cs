﻿using System;
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

    public partial class SimpleCalcFrm : Form
    {
        // Global variable declaration to reduce repetition in code
        int counterFunc = 0;
        int counterOp = 0;
        decimal op1 = 0;
        decimal op2 = 0;
        decimal result = 0;
        decimal roundedResult = 0;

        public SimpleCalcFrm()
        {
            InitializeComponent();
        }     

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            String text = "Total number of Operations:\t" + counterOp.ToString() + "\n" + 
                "Total number of Functions:\t\t" + counterFunc.ToString() + "\n" +
                "Total Number of Calculations: \t" + (counterFunc + counterOp).ToString();
            String title = "Summary for Ashton Becher's Calculator";
            MessageBox.Show(text, title);
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 + op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }
        
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            op1TxtBox.ResetText();
            op2TxtBox.ResetText();
            resultTxtBox.Clear();
            op1TxtBox.Focus();
            // Not sure if this button should reset the counter or not...
            // counterFunc = 0;
            // counterOp = 0;
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 - op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = op1 * op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }

        public void DivideBtn_Click(object sender, EventArgs e)
        {
            // ool divByZeroStatus = false;
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            if (op2 == 0)
            {
                bool divByZeroStatus = false;
                while (divByZeroStatus == false)
                {
                    ErrorBox error = new ErrorBox();
                    error.ShowDialog();
                    op2TxtBox.Value = 1;
                    op2 = op2TxtBox.Value;
                    divByZeroStatus = true;
                }
            }
            result = op1 / op2;
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterOp += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = Math.Min(op1, op2);
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterFunc += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToDecimal(op1TxtBox.Text);
            op2 = Convert.ToDecimal(op2TxtBox.Text);
            result = Math.Max(op1, op2);
            roundedResult = Math.Round(result, 3);
            resultTxtBox.Text = roundedResult.ToString();

            counterFunc += 1;
            op1TxtBox.Focus();
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
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
            op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op2TxtBox.Select(0, op1TxtBox.Text.Length);
        }

        private void SimpleCalcFrm_Load(object sender, EventArgs e)
        {
            // op1TxtBox.Select(0, op1TxtBox.Text.Length);
            op1TxtBox.Focus();
        }
    }
}
