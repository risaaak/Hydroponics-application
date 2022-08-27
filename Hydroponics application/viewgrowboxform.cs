using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hydroponics_application
{
    public partial class viewgrowboxform : Form
    {
        public viewgrowboxform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public string connectionstring = "Data Source=ISAAK-DESKTOP\\SQLEXPRESS;Initial Catalog = HYDROPONICSAPP; Integrated Security = True";
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            int id = Convert.ToInt32(textBox1.Text);
            DateTime transferdate, harvestdate, nextplantdate;
            transferdate = gettransferdate(id);
            harvestdate = transferdate.AddDays(25);
            nextplantdate = harvestdate.AddDays(-15);
            label9.Text = harvestdate.ToString("MM/dd/yyyy");
            label11.Text = nextplantdate.ToString("MM/dd/yyyy");
            */
        }

        private DateTime gettransferdate(int id)
        {
            DateTime transferdate;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand gettransferdate = new SqlCommand("SELECT transferdate FROM GROWBOX WHERE growboxid = " + id, con);
            transferdate = (DateTime)gettransferdate.ExecuteScalar();
            return transferdate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            int id = Convert.ToInt32(textBox1.Text);

            SqlConnection con = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand();

            delete.CommandText = "DELETE FROM GROWBOX WHERE growboxid = " + id;
            delete.Connection = con;
            con.Open();
            delete.ExecuteNonQuery();
            */

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand delete = new SqlCommand();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["growboxid"].Value.ToString());

            delete.CommandText = "DELETE FROM GROWBOX WHERE growboxid = " + id;
            delete.Connection = con;
            delete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GROWBOX", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }

        private void viewgrowboxform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GROWBOX", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
    }
}
