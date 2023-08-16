using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydroponics_application
{
    public partial class viewSeeds : Form
    {
        public Form RefToMainForm { get; set; }
        public viewSeeds()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewSeeds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hYDROPONICS_TESTDataSet.SEEDS' table. You can move, or remove it, as needed.
            this.sEEDSTableAdapter.Fill(this.hYDROPONICS_TESTDataSet.SEEDS);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }
    }
}
