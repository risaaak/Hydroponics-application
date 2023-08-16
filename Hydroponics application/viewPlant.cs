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
    public partial class viewPlant : Form
    {
        public viewPlant()
        {
            InitializeComponent();
        }
        public Form RefToMainForm { get; set; }
        private void viewPlant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hYDROPONICS_TESTDataSet2.PLANT' table. You can move, or remove it, as needed.
            this.pLANTTableAdapter.Fill(this.hYDROPONICS_TESTDataSet2.PLANT);
            // TODO: This line of code loads data into the 'hYDROPONICS_TESTDataSet.PLANT' table. You can move, or remove it, as needed.


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }
    }
}
