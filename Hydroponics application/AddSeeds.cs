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
    public partial class AddSeeds : Form
    {
        public Form RefToMainForm { get; set; }
        public AddSeeds()
        {
            InitializeComponent();
        }
        /*public string connectionString = "Server=kiouni.db.elephantsql.com,5432;Database=ttzzdghro;User Id=ttzzdghro;Password=2QmlTkgNPJaenYWrozh36JUR8S8lqEos; Trusted_Connection=True;";
         * */
        public string connectionString = "postgres://tzzdghro:2QmlTkgNPJaenYWrozh36JUR8S8lqEos@kiouni.db.elephantsql.com/tzzdghro";
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string seedName = textBox1.Text;
            sendDataToDatabase(seedName);
        }
        private void sendDataToDatabase(string seedname, int timesPlanted=0, int timesSprouted=0, float germinationRate=0)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO SEEDS VALUES(@seedName, @timesPlanted, @timesSprouted, @germinationRate)", con);
                command.Parameters.Add(new SqlParameter("seedName", seedname));
                command.Parameters.Add(new SqlParameter("timesPlanted", timesPlanted));
                command.Parameters.Add(new SqlParameter("timesSprouted", timesSprouted));
                command.Parameters.Add(new SqlParameter("germinationRate", germinationRate));
                command.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }
    }
}
