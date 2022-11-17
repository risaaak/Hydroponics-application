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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addSeedsButton_Click(object sender, EventArgs e)
        {

        }

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            DateTime sowDate, noSolutionDate, HalfStrengthSolutionDate, fullStrengthSolutionDate, transferDate, harvestDate, nextPlantDate;
            sowDate = getSowDate();
            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            waterWithNoSolutionLbl.Text = getNoSolutionDate(sowDate).ToString("MM/dd/yyyy");
        }

        private DateTime getSowDate()
        {
            DateTime sowDate = dateTimePicker.Value;
            return sowDate;
        }
        private DateTime getNoSolutionDate(DateTime sowDate)
        {
            return sowDate.AddDays(6);
        }
    }
}
