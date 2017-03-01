/*Issac Wilcher
 * 000421058
 * Feb. 19, 2013
 * Feb. 19, 2013
 * This program will calculate the generated revenue from
    selling stadium tickets.
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _333_WilcherI_Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            //Constant variables for ticket prices
            const decimal CLASS_A_PRICE = 15m;
            const decimal CLASS_B_PRICE = 12m;
            const decimal CLASS_C_PRICE = 9m;

            //Variables for sales
            decimal classASales = 0.0m;
            decimal classBSales = 0.0m;
            decimal classCSales = 0.0m;

            //Variables for revenue
            decimal classARevenue = 0.0m;
            decimal classBRevenue = 0.0m;
            decimal classCRevenue = 0.0m;

            decimal totalRevenue = 0.0m;

            try
            {
                //get inputs
                classASales = decimal.Parse(classATextBox.Text);
                classBSales = decimal.Parse(classBTextBox.Text);
                classCSales = decimal.Parse(classCTextBox.Text);

                //Calculations
                classARevenue = classASales * CLASS_A_PRICE;
                classBRevenue = classBSales * CLASS_B_PRICE;
                classCRevenue = classCSales * CLASS_C_PRICE;

                totalRevenue = classARevenue + classBRevenue + classCRevenue;

                //Outputs
                classAOutput.Text = classARevenue.ToString("c");
                classBOutput.Text = classBRevenue.ToString("c");
                classCOutput.Text = classCRevenue.ToString("c");

                totalOutput.Text = totalRevenue.ToString("c");
            }

            catch
            {
                MessageBox.Show("Please ensure all fields are filled with numeric digits.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear info in 'tickets sold' group
            classATextBox.ResetText();
            classBTextBox.ResetText();
            classCTextBox.ResetText();

            //Clear info in 'revenue generated' group
            classAOutput.ResetText();
            classBOutput.ResetText();
            classCOutput.ResetText();
            totalOutput.ResetText();

            //Reset focus to textbox class A
            classATextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Form
            this.Close();
        }

    }
}
