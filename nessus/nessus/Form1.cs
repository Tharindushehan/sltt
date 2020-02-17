using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nessus
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            var myForm = new Form1();
            myForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAssetName_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlAssetDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pnlVulnearabilityAssesment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnAssetDetails_Click(object sender, EventArgs e)
        {
            
            pnlAssetDetails.BringToFront();
        }

        private void btnSectionDetails_Click(object sender, EventArgs e)
        {
            pnlSectionDetails.BringToFront();
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            pnlVulnearabilityAssesment.BringToFront();
        }

        private void btnVAResults_Click(object sender, EventArgs e)
        {
            pnlVAResult.BringToFront();
        }
    }
}
