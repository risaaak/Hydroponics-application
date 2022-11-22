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

namespace Hydroponics_application
{
    public partial class updateSeeds : Form
    {
        public updateSeeds()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO SEEDS VALUES(@seedName, @timesPlanted, @timesSprouted)",con);
            command.Parameters.Add(new SqlParameter("seedName", textBox1.Text));
            command.Parameters.Add(new SqlParameter("timesPlanted", textBox2.Text));
            command.Parameters.Add(new SqlParameter("timesSprouted", textBox3.Text));
            //command.ExecuteNonQuery();
        }

        private int getTimesPlantedFromDatabase()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            int timesPlanted = 0;
            SqlCommand getTimePlanted = new SqlCommand("SELECT seed_times_planted FROM SEEDS WHERE seed_name=@seedName", con);
            getTimePlanted.Parameters.Add(new SqlParameter("seedName", textBox1.Text));
            timesPlanted = Convert.ToInt32(getTimePlanted.ExecuteScalar());
            return timesPlanted;
        }
    }
}
