using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotLoganC
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "St Marks";
            lblMascot.Text = "Manta rays";
        }

        private void mniSacred_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Sacred Heart";
            lblMascot.Text = "Scorpions";
        }

        private void mniTeresa_Click(object sender, EventArgs e)
        {
            lblSchoolName.Text = "Mother Teresa";
            lblMascot.Text = "Pterodactyls";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
