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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Npgsql;


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
        public string connectionString = "Server=kiouni.db.elephantsql.com;Port=5432;User Id = ttzzdghro; Password=2QmlTkgNPJaenYWrozh36JUR8S8lqEos;Database=tzzdghro;Trust Server Certificate=true;SSL Mode=Require;";
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string seedName = textBox1.Text;
            sendDataToDatabase(seedName);
        }
        private async void sendDataToDatabase(string seedname, int timesPlanted=0, int timesSprouted=0, float germinationRate=0)
        {
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "kiouni.db.elephantsql.com";
            builder.Port = 5432;
            builder.Database = "tzzdghro";
            builder.Username = "tzzdghro";
            builder.Password = "2QmlTkgNPJaenYWrozh36JUR8S8lqEos";
            builder.TrustServerCertificate = true;
            builder.SslMode = SslMode.Require;

            await using (var conn = new NpgsqlConnection(builder.ConnectionString))
            {
                conn.Open();
                using var cmd = new NpgsqlCommand("INSERT INTO SEEDS (seed_name, seed_times_planted, seed_times_sprouted, seed_germination_rate) VALUES(@seedname, @timesPlanted, @timesSprouted, @germinationRate)", conn);
                cmd.Parameters.AddWithValue("@seedname", seedname);
                cmd.Parameters.AddWithValue("@timesPlanted", timesPlanted);
                cmd.Parameters.AddWithValue("@timesSprouted", timesSprouted);
                cmd.Parameters.AddWithValue("@germinationRate", germinationRate);
                try
                {
                    int a = cmd.ExecuteNonQuery();
                    if (a >= 1)
                    {
                        MessageBox.Show("Succesfully added");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textBox1.Text = "";
            /*
            var connectionString = "Server=kiouni.db.elephantsql.com;Port=5432;User Id = ttzzdghro; Password=2QmlTkgNPJaenYWrozh36JUR8S8lqEos;Database=tzzdghro;Trust Server Certificate=true;SSL Mode=Require;";
            await using var dataSource = NpgsqlDataSource.Create(connectionString);
            await using var connection = await dataSource.OpenConnectionAsync();
            using var command = new NpgsqlCommand("select * from seeds", connection);
            await using var reader = await command.ExecuteReaderAsync();
            Console.WriteLine(reader.ToString);
            */
            //var dataSource = NpgsqlDataSource.Create(connectionString);
            //var conn = new NpgsqlConnection(connectionString);
            //conn.Open();
            /*using var command = new NpgsqlCommand("INSERT INTO SEEDS VALUES ($1), ($2), ($3), ($4)", )
            {
                Parameters =
                {
                    new() {Value = seedname},
                    new() {Value = timesPlanted},
                    new() {Value = timesSprouted},
                    new() {Value = germinationRate}
                }
            };
            await command.ExecuteNonQueryAsync();
            conn.Close();
            */
            //var command = dataSource.CreateCommand("INSERT INTO SEEDS VALUES ($1), ($2), ($3), ($4)");

            /*
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
            */
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }
    }
}
