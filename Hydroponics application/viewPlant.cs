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
            confirmButton.Visible = true;
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
            confirmButton.Visible = false;
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
            for(int i = 0, n = dataGridView1.Rows.Count; i < n;i++)
            {
                if (dataGridView1.Rows[i].Cells[7].Value != null && dataGridView1.Rows[i].Cells[7].Value != DBNull.Value)
                {
                    dataGridView1.Rows[i].Cells[8].Value = Math.Round((Convert.ToDecimal(dataGridView1.Rows[i].Cells[7].Value) / Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value)) * 100,2);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            editButton.Visible = true;
            cancelButton.Visible = false;
            deleteButton.Visible = false;
            confirmButton.Visible = false;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirmButton.Visible = true;
            for(int i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updatePlantTable = new SqlCommand("UPDATE PLANT SET SEEDS_SPROUTED = @SEEDS_SPROUTED WHERE PLANT_ID = @PLANT_ID", connection);
                    SqlParameter parameter = updatePlantTable.Parameters.AddWithValue("@SEEDS_SPROUTED", dataGridView1.Rows[i].Cells[7].Value);
                    updatePlantTable.Parameters.AddWithValue("PLANT_ID", dataGridView1.Rows[i].Cells[0].Value);
                    if(dataGridView1.Rows[i].Cells[7].Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    connection.Open();
                    updatePlantTable.ExecuteNonQuery();
                }
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand updateSeedTable = new SqlCommand("UPDATE SEEDS SET seed_times_sprouted = seed_times_sprouted + @timesSprouted WHERE seed_name = @seedName", connection);
                if (dataGridView1.CurrentRow.Cells[7] == null)
                {
                    updateSeedTable.Parameters.AddWithValue("@timesSprouted", null);
                }
                else
                    updateSeedTable.Parameters.AddWithValue("@timesSprouted", dataGridView1.CurrentRow.Cells[7].Value);

                updateSeedTable.Parameters.AddWithValue("@seedName", dataGridView1.CurrentRow.Cells[1].Value);
                connection.Open();
                updateSeedTable.ExecuteNonQuery();
            }
            loadTable();
            editButton.Visible = true;
            confirmButton.Visible=false;
            deleteButton.Visible=false;
            cancelButton.Visible=false;
        }
    }
}
