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
//using Microsoft.Toolkit.Uwp.Notifications;

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
        public string connectionstring = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICSAPP;Integrated Security=True";

        /*
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
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datePlanted = Convert.ToDateTime(dateTimePicker1.Value);

            label7.Text = datePlanted.ToString();
            DateTime waterWithnoSLN = getWaterWithNoSolutionDate(datePlanted);
            DateTime halfstrengthSLN = getHalfStrengthSolutionDate(waterWithnoSLN);
            DateTime fullStrength = getWaterWithFullStrengthDate(halfstrengthSLN);
            DateTime transferDate = getTransferDate(fullStrength);
            DateTime harvestDate = transferDate.AddDays(30);
            DateTime nextPlant = harvestDate.AddDays(-15);
            label5.Text = datePlanted.ToString("MM/dd/yyyy") + "  to " + waterWithnoSLN.ToString("MM/dd/yyyy");
            label6.Text = waterWithnoSLN.AddDays(1).ToString("MM/dd/yyyy")  + "  to " + halfstrengthSLN.ToString("MM/dd/yyyy");
            label7.Text = halfstrengthSLN.AddDays(1).ToString("MM/dd/yyyy") + "  to " + fullStrength.ToString("MM/dd/yyyy");
            label9.Text = harvestDate.ToString("MM/dd/yyyy");
            label11.Text = nextPlant.ToString("MM/dd/yyyy");
            label13.Text = transferDate.ToString("MM/dd/yyyy");
        }

        private DateTime getWaterWithNoSolutionDate(DateTime datePlanted)
        {
            DateTime waterWithNoSolutionDate = datePlanted.AddDays(6);
            return waterWithNoSolutionDate;
        }

        private DateTime getHalfStrengthSolutionDate(DateTime waterWithNoSolutionDate)
        {
            DateTime halfStrengthSolutionDate = waterWithNoSolutionDate.AddDays(6);
            return halfStrengthSolutionDate;
        }

        private DateTime getWaterWithFullStrengthDate(DateTime waterWithHalfStrengthDate)
        {
            DateTime fullStrengthSolutionDate = waterWithHalfStrengthDate.AddDays(2);
            return fullStrengthSolutionDate;
        }

        private DateTime getTransferDate(DateTime waterWithFullStrength)
        {
            DateTime transferDate = waterWithFullStrength.AddDays(1);
            return transferDate;
        }

        private DateTime getHarvestDate(DateTime transferDate)
        {
            DateTime harvestDate = transferDate.AddDays(30);
            return harvestDate;
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
            /*
            notificationHarvestDate();
            notificationNextPlantDate();
            notificationFullStrengthSolution();
            notificationHalfStrengthSolution();
            notificationWaterNoSolution();
            notificationTransferSeedling();
            */
        }

        private void addseedsbtn_Click(object sender, EventArgs e)
        {
            Add_Seedlings add_Seedlings = new Add_Seedlings();
            add_Seedlings.Show();
            this.Hide();
        }

        private void updatestatsbtn_Click(object sender, EventArgs e)
        {
            updatestatsform updatestatsform = new updatestatsform();
            updatestatsform.Show();
            this.Hide();
        }

        private void viewseedsbtn_Click(object sender, EventArgs e)
        {
            viewseedsform viewseedsform = new viewseedsform();
            viewseedsform.Show();
            this.Hide();
        }
    }
}
