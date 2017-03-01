/*Issac Wilcher
 * 000421058
 * Date Due
 * Date Submitted
 * Description
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _333_WilcherI_0401
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const double HIGH_SCORE = 95.0;
                const double MIDDLE_SCORE = 80.0;
                const double LOW_SCORE = 60.0;

                //declare variables
                double test1, test2, test3, average;

                //get text box values
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                //calculate
                average = (test1 + test2 + test3) / 3.0;

                //output
                averageLabel.Text = average.ToString("n1");


                if (average >= HIGH_SCORE)
                    MessageBox.Show("A");
                else if (average >= MIDDLE_SCORE)
                    MessageBox.Show("B");
                else if (average >= LOW_SCORE)
                    MessageBox.Show("C");
                else
                    MessageBox.Show("F");
            }

            catch (Exception ex)
            {

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            test1TextBox.ResetText();
            test2TextBox.ResetText();
            test3TextBox.ResetText();
            averageLabel.ResetText();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
