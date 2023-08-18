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
            AddSeeds addSeeds = new AddSeeds();
            addSeeds.RefToMainForm = this;
            this.Visible = false;
            addSeeds.Show();
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
        private void viewSeedsButton_Click(object sender, EventArgs e)
        {
            viewSeeds viewSeeds = new viewSeeds();
            viewSeeds.RefToMainForm = this;
            this.Visible = false;
            viewSeeds.Show();
        }
        private void addStatsButton_Click(object sender, EventArgs e)
        {
            viewStatistics viewStatistics = new viewStatistics();
            viewStatistics.RefToMainForm = this;
            this.Visible = false;
            viewStatistics.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm();
            addIncomeForm.RefToMainForm = this;
            this.Visible = false;
            addIncomeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addExpenditureForm addExpenditureForm = new addExpenditureForm();
            addExpenditureForm.RefToMainForm = this;
            this.Visible = false;
            addExpenditureForm.Show();
        }

        private void viewPlantsButton_Click(object sender, EventArgs e)
        {
            viewPlant viewPlant = new viewPlant();
            viewPlant.RefToMainForm = this;
            this.Visible = false;
            viewPlant.Show();
        }
        private void transferDateButton_Click(object sender, EventArgs e)
        {
            transferDate = dateTimePicker.Value;
            harvestDate  = getHarvestDate(transferDate);
            nextPlantDate = getNextPlantDate(harvestDate);
            sowDateLbl.Text = "";
            transferDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
        }
        private void addPlantButton_Click(object sender, EventArgs e)
        {
            addPlantForm addPlantForm = new addPlantForm();
            addPlantForm.RefToMainForm = this;
            this.Visible = false;
            addPlantForm.Show();
        }
    }
}
