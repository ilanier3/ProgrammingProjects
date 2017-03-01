/*Issac Wilcher
 * 000421058
 * Feb. 19, 2013
 * Feb. 19, 2013
 * Meal Calculator for users.
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _333_WilcherI_Ch03Ex01
{
    public partial class Form1 : Form
    {
        //declare field for accumulation
        private decimal runningTotal = 0.0m;

        //declare field for counter
        private int overallOrders = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            const decimal PERCENT_TIP = 0.15m;
            const decimal PERCENT_SALES_TAX = 0.07m;

            decimal foodCharge = 0.0m;

            decimal tax = 0.0m;
            decimal tip = 0.0m;

            decimal total = 0.0m;

            decimal average = 0.0m;

            try
            {
                //Convert values from textbox
                foodCharge = decimal.Parse(foodChargeTextBox.Text);

                //Calculations
                tax = foodCharge * PERCENT_SALES_TAX;
                tip = foodCharge * PERCENT_TIP;
                total = foodCharge + tax + tip;
                //runningTotal = runningTotal + total;
                runningTotal += total;

                //count total orders
                overallOrders++;

                //calculate average
                average = runningTotal / overallOrders;

                //Outputs
                salesTaxOutput.Text = tax.ToString("c");
                tipOutput.Text = tip.ToString("c");
                totalOutput.Text = total.ToString("c");
                overallTotalOutput.Text = runningTotal.ToString("c");
                overallOrdersOutput.Text = overallOrders.ToString();
                averageTotalOutput.Text = average.ToString("c");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n -Numbers only please.");

                foodChargeTextBox.SelectAll();
                foodChargeTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear data
            foodChargeTextBox.ResetText();
            salesTaxOutput.ResetText();
            tipOutput.ResetText();
            totalOutput.ResetText();

            /*Reset variables
            foodCharge = 0.0m;
            tip = 0.0m; 
            tax = 0.0m;*/

            //Reset focus
            foodChargeTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            //Clear ALL data
            foodChargeTextBox.ResetText();
            salesTaxOutput.ResetText();
            tipOutput.ResetText();
            totalOutput.ResetText();
            overallTotalOutput.ResetText();
            overallOrdersOutput.ResetText();
            averageTotalOutput.ResetText();

            /*Reset variables
            foodCharge = 0.0m;
            tip = 0.0m;
            tax = 0.0m;*/ 
            runningTotal = 0.0m;
            overallOrders = 0;

            //Reset focus
            foodChargeTextBox.Focus();
        }
    }
}
