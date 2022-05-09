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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datePlanted = Convert.ToDateTime(dateTimePicker1.Value);

            label7.Text = datePlanted.ToString();
            DateTime waterWithnoSLN = datePlanted.AddDays(6);
            DateTime halfstrengthSLN = waterWithnoSLN.AddDays(6);
            DateTime fullStrength = halfstrengthSLN.AddDays(2);
            DateTime harvestDate = fullStrength.AddDays(25);
            DateTime nextPlant = harvestDate.AddDays(-15);
            label5.Text = datePlanted.ToString("MM/dd/yyyy") + " to " + waterWithnoSLN.ToString("MM/dd/yyyy");
            label6.Text = waterWithnoSLN.AddDays(1).ToString("MM/dd/yyyy")  + " to " + halfstrengthSLN.ToString("MM/dd/yyyy");
            label7.Text = halfstrengthSLN.AddDays(1).ToString("MM/dd/yyyy") + " to " + fullStrength.ToString("MM/dd/yyyy");
            label9.Text = harvestDate.ToString("MM/dd/yyyy");
            label11.Text = nextPlant.ToString("MM/dd/yyyy");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
