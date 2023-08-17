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
    public partial class viewPlant : Form
    {
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public viewPlant()
        {
            InitializeComponent();
        }
        public Form RefToMainForm { get; set; }
        private void viewPlant_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editButton.Visible = false;

            deleteButton.Visible = true;
            cancelButton.Visible = true;
            dataGridView1.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("delete from plant where plant_id = @plantID", con);
            cmd.Parameters.AddWithValue("plantID", dataGridView1.CurrentRow.Cells[0].Value);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            editButton.Visible = true;
            deleteButton.Visible = false;
            cancelButton.Visible = false;
            dataGridView1.Enabled = false;
            loadTable();
        }

        private void loadTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadTable = new SqlCommand("select * from plant",con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = loadTable;
            DataTable dt = new DataTable();
            dt.Clear();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            editButton.Visible = true;
            cancelButton.Visible = false;
            deleteButton.Visible = false;
        }
    }
}
