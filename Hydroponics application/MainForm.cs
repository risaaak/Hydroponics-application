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
            /*AddSeeds addSeeds = new AddSeeds();
            addSeeds.RefToMainForm = this;
            this.Visible = false;
            addSeeds.Show();*/
        }
        
        DateTime sowDate, transferDate, harvestDate, nextPlantDate;
        
        private void sowDateButton_Click(object sender, EventArgs e)
        {
            sowDate = getSowDate();
            transferDate = getTransferDate(sowDate);
            harvestDate = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            /*
            noSolutionDate = getNoSolutionDate(sowDate);
            halfStrengthSolutionDate = getHalfStrengthSolutionDate(noSolutionDate);
            fullStrengthSolutionDate = getFullStrengthSoltuionDate(halfStrengthSolutionDate);
            transferDate = getTransferDate(fullStrengthSolutionDate);
            harvestDate = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            waterWithNoSolutionLbl.Text = sowDate.ToString("MM/dd/yyyy") + " - " + noSolutionDate.ToString("MM/dd/yyyy");
            HalfStrengthLbl.Text = noSolutionDate.AddDays(1).ToString("MM/dd/yyyy") +  " - " + halfStrengthSolutionDate.ToString("MM/dd/yyyy");
            FullStrengthLbl.Text = halfStrengthSolutionDate.AddDays(1).ToString("MM/dd/yyyy") + " - " + fullStrengthSolutionDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            */

        }
        
        public DateTime getSowDate()
        {
            DateTime sowDate = dateTimePicker.Value;
            return sowDate;
        }

        public DateTime getTransferDate(DateTime sowDate)
        {
            return sowDate.AddDays(15);
        }

        public DateTime getHarvestDate(DateTime transferDate)
        {
            return transferDate.AddDays(30);
        }

        public DateTime getNextPlantDate(DateTime harvestDate)
        {
            return harvestDate.AddDays(-17);
        }
        /*
        public DateTime getNoSolutionDate(DateTime sowDate)
        {
            return sowDate.AddDays(6);
        }

        public DateTime getHalfStrengthSolutionDate(DateTime noSolutionDate)
        {

            return noSolutionDate.AddDays(6);
        }
        */
        public void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void viewSeedsButton_Click(object sender, EventArgs e)
        {
            /*
            viewSeeds viewSeeds = new viewSeeds();
            viewSeeds.RefToMainForm = this;
            this.Visible = false;
            viewSeeds.Show();
            */
        }

        private void viewPlantsButton_Click(object sender, EventArgs e)
        {
            viewPlant viewPlant = new viewPlant();
            viewPlant.RefToMainForm = this;
            this.Visible = false;
            viewPlant.Show();
        }
        /*
        public DateTime getFullStrengthSoltuionDate(DateTime halfStrengthSolutionDate)
        {
            return halfStrengthSolutionDate.AddDays(2);
        }
        */
        private void transferDateButton_Click(object sender, EventArgs e)
        {
            transferDate = dateTimePicker.Value;
            harvestDate  = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            sowDateLbl.Text = "";
            transferDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            /*
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
            */
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            /*
            addPlantForm addPlantForm = new addPlantForm();
            addPlantForm.RefToMainForm = this;
            this.Visible = false;
            addPlantForm.Show();
            */
        }
    }
}
