using Npgsql;
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
    public partial class viewSeeds : Form
    {
        updateSeed updateSeed = new updateSeed();
        public string connectionString = ConnectionString.connectionString();
        public Form RefToMainForm { get; set; }
        public viewSeeds()
        {
            InitializeComponent();
        }
        /*
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        */

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewSeeds_Load(object sender, EventArgs e)
        {
            loadTable();
            Console.WriteLine(updateSeed.getLastGerminationRateUpdate());
        }

        public void loadTable()
        {
            /*
            NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
            builder.Host = "kiouni.db.elephantsql.com";
            builder.Port = 5432;
            builder.Database = "tzzdghro";
            builder.Username = "tzzdghro";
            builder.Password = "2QmlTkgNPJaenYWrozh36JUR8S8lqEos";
            builder.TrustServerCertificate = true;
            builder.SslMode = SslMode.Require;
            */
            using(var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM SEEDS ORDER BY seed_id", conn);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable dt = new DataTable();
                dt.Clear();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            /*
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadTable = new SqlCommand("SELECT * FROM SEEDS", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadTable;
            DataTable dt = new DataTable();
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            */
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            editButton.Visible = false;
            updateButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = true;
            cancelButton.Visible = false;
            updateButton.Visible = false;
            loadTable();
            /*
            NpgsqlConnection con = new NpgsqlConnection(connectionString());
            NpgsqlCommand loadTable = new NpgsqlCommand("SELECT * FROM SEEDS", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadTable);
            DataTable dt = new DataTable();
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            */
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView1.Rows.Count-1; i++)
            {
                try
                {
                    NpgsqlConnection con = new NpgsqlConnection(connectionString);
                    NpgsqlCommand updateTable = new NpgsqlCommand("UPDATE SEEDS SET seed_name = @seedName , " +
                        "seed_times_planted = @timesPlanted, " +
                        "seed_times_sprouted = @timesSprouted, " +
                        "seed_germination_rate = @seedGerminationRate " +
                        "WHERE seed_id = @seedID", con);
                    updateTable.Parameters.AddWithValue("seedName", dataGridView1.Rows[i].Cells[1].Value);
                    updateTable.Parameters.AddWithValue("timesPlanted", dataGridView1.Rows[i].Cells[2].Value);
                    updateTable.Parameters.AddWithValue("timesSprouted", dataGridView1.Rows[i].Cells[3].Value);
                    updateTable.Parameters.AddWithValue("seedGerminationRate", Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value) / Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) * 100);
                    updateTable.Parameters.AddWithValue("seedID", dataGridView1.Rows[i].Cells[0].Value);

                    con.Open();
                    updateTable.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                }
            }
            loadTable();
            updateButton.Visible = false;
            cancelButton.Visible = false;
            editButton.Visible = true;
        }
    }
}
