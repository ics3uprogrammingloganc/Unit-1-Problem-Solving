/*
 * Created by: Logan Cantin
 * Created on: February 11th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program lets you change the image using a menu strip.
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

namespace MovingCatLoganC
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            pbxCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            pbxCat.Image = Properties.Resources.cat2;
        }
    }
}
