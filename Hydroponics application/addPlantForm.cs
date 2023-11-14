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
using Npgsql;

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
        int timesPlanted, timesSprouted;
        float germinationRate;

        private void addPlantForm_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'hYDROPONICS_TESTDataSet1.SEEDS' table. You can move, or remove it, as needed.
            this.sEEDSTableAdapter.Fill(this.hYDROPONICS_TESTDataSet1.SEEDS);
            */
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand loadCombobox = new NpgsqlCommand("SELECT seed_name FROM SEEDS", conn);
                NpgsqlDataReader sqlDataReader = loadCombobox.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    comboBox1.Items.Add(sqlDataReader[0]);
                }
            }

        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        updateSeed updateSeed = new updateSeed();
        /*
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        */
        public string connectionString = ConnectionString.connectionString();
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
            sendDataToDatabase(seedName, sowDateLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text,timesPlanted, 0);
            timesPlanted += updateSeed.getTimesPlantedFromDatabase(seedName);
            timesSprouted += updateSeed.getTimesSproutedFromDatabase(seedName);
            germinationRate += updateSeed.getGerminationRate(timesPlanted, timesSprouted);
            updateSeed.sendDataToDatabase(seedName, timesPlanted, timesSprouted, germinationRate);
        }

        private void sowDateButton_Click(object sender, EventArgs e)
        {
            seedName = comboBox1.Text;
            timesPlanted = Convert.ToInt32(textBox1.Text);
            sowDate = dateTimePicker.Value;
            transferDate = mainForm.getTransferDate(sowDate);
            harvestDate = mainForm.getHarvestDate(transferDate);
            nextPlantDate = mainForm.getNextPlantDate(harvestDate);
            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            transferDateLbl.Text = transferDate.ToString("MM/dd/yyyy");
            harvestDateLbl.Text = harvestDate.ToString("MM/dd/yyyy");
            NextPlantDateLbl.Text = nextPlantDate.ToString("MM/dd/yyyy");
            sendDataToDatabase(seedName, sowDateLbl.Text, transferDateLbl.Text, harvestDateLbl.Text, NextPlantDateLbl.Text, timesPlanted, 0);
            timesPlanted+= updateSeed.getTimesPlantedFromDatabase(seedName);
            timesSprouted+= updateSeed.getTimesSproutedFromDatabase(seedName);
            germinationRate += updateSeed.getGerminationRate(timesPlanted, timesSprouted);

            updateSeed.sendDataToDatabase(seedName, timesPlanted, timesSprouted, germinationRate);
         }

        private void sendDataToDatabase(string seed, string sowDate, string transferDate, string harvestDate, string nextPlantDate, int seedsPlanted, double germinationRate = 0)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            /*
            int seedID = updateSeed.getSeedId(seed);
            */
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO PLANT(seed_name, sow_date, transfer_date, harvest_date, next_plant_date, seeds_planted, seeds_sprouted, germination_rate) VALUES (@seed_id, @sowDate, @transferDate, @harvestDate, @nextPlantDate, @seedsPlanted, @timesSprouted, @germinationRate)", conn);
                command.Parameters.AddWithValue("@seed_id", seed);
                command.Parameters.AddWithValue("@sowDate", sowDate);
                command.Parameters.AddWithValue("@transferDate", transferDate);
                command.Parameters.AddWithValue("@harvestDate", harvestDate);
                command.Parameters.AddWithValue("@nextPlantDate", nextPlantDate);
                command.Parameters.AddWithValue("@seedsPlanted", seedsPlanted);
                command.Parameters.AddWithValue("@timesSprouted", DBNull.Value);
                command.Parameters.AddWithValue("@germinationRate", DBNull.Value);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            conn.Close();
        }
    }
}
