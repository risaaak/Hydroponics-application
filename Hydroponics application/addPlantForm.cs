using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydroponics_application
{
    public partial class addPlantForm : Form
    {
        public addPlantForm()
        {
            InitializeComponent();
        }
        DateTime sowDate, noSolutionDate, halfStrengthSolutionDate, fullStrengthSolutionDate, transferDate, harvestDate, nextPlantDate;
        MainForm mainForm = new MainForm();
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void transferDateButton_Click(object sender, EventArgs e)
        {
            sowDateLbl.Text = "";
            waterWithNoSolutionLbl.Text = "";
            HalfStrengthLbl.Text = "";
            FullStrengthLbl.Text = "";
            transferDate = dateTimePicker.Value;
            harvestDate = mainForm.getHarvestDate(transferDate);
            nextPlantDate = mainForm.getNextPlantDate(harvestDate);
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            sendDataToDatabase(1, sowDateLbl.Text, waterWithNoSolutionLbl.Text, HalfStrengthLbl.Text, FullStrengthLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text);
        }

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            sowDate = mainForm.getSowDate();
            noSolutionDate = mainForm.getNoSolutionDate(sowDate);
            halfStrengthSolutionDate = mainForm.getHalfStrengthSolutionDate(noSolutionDate);
            fullStrengthSolutionDate = mainForm.getFullStrengthSoltuionDate(halfStrengthSolutionDate);
            transferDate = mainForm.getTransferDate(fullStrengthSolutionDate);
            harvestDate = mainForm.getHarvestDate(transferDate);
            nextPlantDate = mainForm.getNextPlantDate(harvestDate);

            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            waterWithNoSolutionLbl.Text = sowDate.ToString("MM/dd/yyyy") + " - " + noSolutionDate.ToString("MM/dd/yyyy");
            HalfStrengthLbl.Text = noSolutionDate.AddDays(1).ToString("MM/dd/yyyy") + " - " + halfStrengthSolutionDate.ToString("MM/dd/yyyy");
            FullStrengthLbl.Text = halfStrengthSolutionDate.AddDays(1).ToString("MM/dd/yyyy") + " - " + fullStrengthSolutionDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            sendDataToDatabase(1, sowDateLbl.Text, waterWithNoSolutionLbl.Text, HalfStrengthLbl.Text, FullStrengthLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text);
        }

        private void sendDataToDatabase(int seed, string sowDate, string noSolutionDate, string halfStrengthDate, string fullStrengthDate, string transferDate, string harvestDate, string nextPlantDate)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO PLANT VALUES (@seed, @sowDate, @noSolutionDate, @halfStrengthDate, @fullStrengthDate, @transferDate, @harvestDate, @nextPlantDate)", conn);
                command.Parameters.Add(new SqlParameter("seed", seed));
                command.Parameters.Add(new SqlParameter("sowDate", sowDate));
                command.Parameters.Add(new SqlParameter("noSolutionDate", noSolutionDate));
                command.Parameters.Add(new SqlParameter("halfStrengthDate", halfStrengthDate));
                command.Parameters.Add(new SqlParameter("fullStrengthDate", fullStrengthDate));
                command.Parameters.Add(new SqlParameter("transferDate", transferDate));
                command.Parameters.Add(new SqlParameter("harvestDate", harvestDate));
                command.Parameters.Add(new SqlParameter("nextPlantDate", nextPlantDate));
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
    }
}
