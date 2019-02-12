/*
 * Created by: Logan Cantin
 * Created on: February 11th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - ChangingAreaPerim
 * This program calculates the area of a rectangle whose dimensions are entered by the user. 
 * I have also included error catching to prevent the user from entering non-number characters
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAreaPerimLoganC
{
    public partial class ChangingAreaPerimForm : Form
    {
        public ChangingAreaPerimForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double length, width;
                length = Convert.ToDouble(tbxLength.Text);
                width = Convert.ToDouble(tbxWidth.Text);

                lblAnswer.Text = "The area of this rectangle is " + Convert.ToString(length * width) + "cm².";
            }
            catch (FormatException ex)
            {
                lblAnswer.Text = "You entered something other than a number. Try again!";
            }
        }
    }
}
