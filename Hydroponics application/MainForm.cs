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

        private void addSeedsButton_Click(object sender, EventArgs e)
        {

        }

        DateTime sowDate, noSolutionDate, halfStrengthSolutionDate, fullStrengthSolutionDate, transferDate, harvestDate, nextPlantDate;

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            sowDate = getSowDate();
            noSolutionDate = getNoSolutionDate(sowDate);
            halfStrengthSolutionDate = getHalfStrengthSolutionDate(noSolutionDate);
            fullStrengthSolutionDate = getFullStrengthSoltuionDate(halfStrengthSolutionDate);
            transferDate = getTransferDate(fullStrengthSolutionDate);
            harvestDate = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            waterWithNoSolutionLbl.Text = sowDate.ToString("MM/dd/yyyy") + " - " + noSolutionDate.ToString("MM/dd/yyyy");
            HalfStrengthLbl.Text = noSolutionDate.AddDays(1).ToString("MM/dd/yyyy") +  " - " + halfStrengthSolutionDate.ToString("MM/dd/yyyy");
            FullStrengthLbl.Text = halfStrengthSolutionDate.AddDays(1).ToString("MM/dd/yyyy") + " - " + fullStrengthSolutionDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
        }

        public DateTime getSowDate()
        {
            DateTime sowDate = dateTimePicker.Value;
            return sowDate;
        }
        public DateTime getNoSolutionDate(DateTime sowDate)
        {
            return sowDate.AddDays(6);
        }

        public DateTime getHalfStrengthSolutionDate(DateTime noSolutionDate)
        {
            return noSolutionDate.AddDays(6);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {

        }

        public DateTime getFullStrengthSoltuionDate(DateTime halfStrengthSolutionDate)
        {
            return halfStrengthSolutionDate.AddDays(2);
        }

        public DateTime getTransferDate(DateTime fullStrengthSolutionDate)
        {
            return fullStrengthSolutionDate.AddDays(1);
        }

        public DateTime getHarvestDate(DateTime transferDate)
        {
            return transferDate.AddDays(30);
        }
        public DateTime getNextPlantDate(DateTime harvestDate)
        {
            return harvestDate.AddDays(-17);
        }

        private void transferDateButton_Click(object sender, EventArgs e)
        {
            sowDateLbl.Text = "";
            waterWithNoSolutionLbl.Text = "";
            HalfStrengthLbl.Text = "";
            FullStrengthLbl.Text = "";
            transferDate = dateTimePicker.Value;
            harvestDate = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            addPlantForm addPlantForm = new addPlantForm();
            addPlantForm.Show();
            this.Hide();
        }
    }
}
