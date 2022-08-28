using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

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
        //connection string
        public string connectionstring = "Data Source=ISAAKLAPTOP\\SQLEXPRESS;Initial Catalog = HYDROPONICS; Integrated Security = True";

        //function to set harvest date toast
        private void notificationHarvestDate()
        {
         //command to get the harvest date
         SqlConnection con = new SqlConnection(connectionstring);
        if (con.State == ConnectionState.Closed)
         {
            con.Open();
         }
         SqlCommand getHarvestDate = new SqlCommand("SELECT harvestdate FROM GROWBOX", con);
         DateTime harvestdate = (DateTime)getHarvestDate.ExecuteScalar();
         con.Close();
         new ToastContentBuilder()
            .AddText("Harvest Lettuce")
            .Schedule(harvestdate);
        }

        //fucntion to get the next plant date notification
        private void notificationNextPlantDate()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand getNextPlantDate = new SqlCommand("SELECT nextplant FROM GROWBOX", con);
            DateTime nextPlantDate = (DateTime)getNextPlantDate.ExecuteScalar();
            con.Close();
            new ToastContentBuilder()
                .AddText("Plant next seedling batch")
                .Schedule(nextPlantDate);
        }

        //function to get water solution notification
        private void notificationWaterNoSolution()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand getWaterNoSolution = new SqlCommand("SELECT nosolutiondate FROM SEEDLINGTRAY", con);
            DateTime noSolutionDate = (DateTime)getWaterNoSolution.ExecuteScalar();
            con.Close();
            new ToastContentBuilder()
                .AddText("Water seedling with no solution")
                .Schedule(noSolutionDate);
        }
        private void notificationHalfStrengthSolution()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand getWaterHalfStrength = new SqlCommand("SELECT halfstrengthsolutiondate FROM SEEDLINGTRAY", con);
            DateTime halfStrengthSolution = (DateTime)getWaterHalfStrength.ExecuteScalar();
            con.Close();
            new ToastContentBuilder()
                .AddText("Water seedling with half strength solution")
                .Schedule(halfStrengthSolution);
        }
        
        private void notificationFullStrengthSolution()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand getWaterFullStrength = new SqlCommand("SELECT fullstrengthsolutiondate FROM SEEDLINGTRAY", con);
            DateTime fullStrengthSolution = (DateTime)getWaterFullStrength.ExecuteScalar();
            con.Close();
            new ToastContentBuilder()
                .AddText("Water seedling with full strength solution")
                .Schedule(fullStrengthSolution);
        }

        private void notificationTransferSeedling()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand getTransferDate = new SqlCommand("SELECT plantdate FROM SEEDLINGTRAY", con);
            DateTime transferDate = (DateTime)getTransferDate.ExecuteScalar();
            con.Close();
            new ToastContentBuilder()
                .AddText("Transfer seedling to grow box")
                .Schedule(transferDate.AddDays(15));
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime datetrasfer = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime dateHarvest = datetrasfer.AddDays(25);
            label9.Text = dateHarvest.ToString("MM/dd/yyyy");
            DateTime nextplant = dateHarvest.AddDays(-15);
            label11.Text = nextplant.ToString("MM/dd/yyyy");
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addseedlingtrayform addseedling = new addseedlingtrayform();
            addseedling.Show();
            this.Hide();
        }

        private void addgrowboxbtn_Click(object sender, EventArgs e)
        {
            addgrowboxform addgrowbox = new addgrowboxform();
            addgrowbox.Show();
            this.Hide();
        }

        private void viewseedlingtraybtn_Click(object sender, EventArgs e)
        {
            viewseedlingtrayform viewseedlingtrayform = new viewseedlingtrayform();
            viewseedlingtrayform.Show();
            this.Hide();

        }

        private void viewgrowboxbtn_Click(object sender, EventArgs e)
        {
            viewgrowboxform viewgrowboxform = new viewgrowboxform();
            viewgrowboxform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notificationHarvestDate();
            notificationNextPlantDate();
            notificationFullStrengthSolution();
            notificationHalfStrengthSolution();
            notificationWaterNoSolution();
            notificationTransferSeedling();
        }
    }
}
