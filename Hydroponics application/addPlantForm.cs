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
        public Form RefToMainForm { get; set; }
        MainForm mainForm = new MainForm();
        public addPlantForm()
        {
            InitializeComponent();
        }
        DateTime sowDate, transferDate, harvestDate, nextPlantDate;
        string seedName;
        int timesPlanted, timesSprouted, seedId;
        float germinationRate;

        private void addPlantForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hYDROPONICS_TESTDataSet1.SEEDS' table. You can move, or remove it, as needed.
            this.sEEDSTableAdapter.Fill(this.hYDROPONICS_TESTDataSet1.SEEDS);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        updateSeeds updateSeeds = new updateSeeds();
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void transferDateButton_Click(object sender, EventArgs e)
        {
            
            seedName = comboBox1.Text;
            timesPlanted = Convert.ToInt32(textBox1.Text);
            sowDateLbl.Text = "";
            transferDate = dateTimePicker.Value;
            harvestDate = mainForm.getHarvestDate(transferDate);
            nextPlantDate = mainForm.getNextPlantDate(harvestDate);
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            sendDataToDatabase(seedName, sowDateLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text,timesPlanted);
            timesPlanted += updateSeeds.getTimesPlantedFromDatabase(seedName);
            updateSeeds.sendDataToDatabase(seedName, timesPlanted);
        }

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            
            seedName = comboBox1.Text;
            timesPlanted = Convert.ToInt32(textBox1.Text);
            sowDate = mainForm.getSowDate();
            transferDate = mainForm.getTransferDate(sowDate);
            harvestDate = mainForm.getHarvestDate(transferDate);
            nextPlantDate = mainForm.getNextPlantDate(harvestDate);
            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            sendDataToDatabase(seedName, sowDateLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text, timesPlanted);
            timesPlanted+=updateSeeds.getTimesPlantedFromDatabase(seedName);
            timesSprouted+= updateSeeds.getTimesSproutedFromDatabase(seedName);
            germinationRate += updateSeeds.getGerminationRate(timesPlanted, timesSprouted);

            updateSeeds.sendDataToDatabase(seedName, timesPlanted, timesSprouted, germinationRate);
         }

        private void sendDataToDatabase(string seed, string sowDate, string transferDate, string harvestDate, string nextPlantDate, int seedsPlanted)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            int seedID = getSeedId(seed);

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO PLANT VALUES (@seed_id, @sowDate, @transferDate, @harvestDate, @nextPlantDate, @seedsPlanted)", conn);
                command.Parameters.Add(new SqlParameter("seed_id", seedID));
                command.Parameters.Add(new SqlParameter("sowDate", sowDate));
                command.Parameters.Add(new SqlParameter("transferDate", transferDate));
                command.Parameters.Add(new SqlParameter("harvestDate", harvestDate));
                command.Parameters.Add(new SqlParameter("nextPlantDate", nextPlantDate));
                command.Parameters.Add(new SqlParameter("seedsPlanted", seedsPlanted));
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private int getSeedId(string seedName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand getSeedID = new SqlCommand("SELECT seed_id FROM SEEDS WHERE seed_name = @seedName", con);
            getSeedID.Parameters.Add(new SqlParameter("seedName", seedName));
            int seedId = (int)getSeedID.ExecuteScalar();
            con.Close();

            return seedId;
        }

        private void sendTimesPlantedToDatabase(int timesPlanted, int seedId)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE SEEDS SET seed_times_planted = @timesPlanted WHERE seed_id = @seedId",con);
            command.Parameters.Add(new SqlParameter("timesPlanted",timesPlanted));
            command.Parameters.Add(new SqlParameter("seedId", seedId));
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
