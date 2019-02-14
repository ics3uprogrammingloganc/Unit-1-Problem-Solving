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
    public partial class frmChangingAreaPerim : Form
    {
        public frmChangingAreaPerim()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Starting the try statement to catch incorrect inputs in the text boxes
            try
            {
                // Converting the length and width from the text boxes to doubles and setting them to their respective variables
                double length, width;
                length = Convert.ToDouble(tbxLength.Text);
                width = Convert.ToDouble(tbxWidth.Text);

                // Setting the labels with the area and perimeter
                lblArea.Text = "The area of this rectangle is " + Convert.ToString(length * width) + "cm².";
                lblPerimeter.Text = "The perimeter of this rectangle is " + Convert.ToString(2 * (length + width)) + " cm.";
            }
            // Runs if there was anything other than numbers in the text boxes
            catch (FormatException)
            {
                // Notifying the user that they entered illeagal input
                lblArea.Text = "You entered something other than a number. Try again!";
            }
        }
    }
}
