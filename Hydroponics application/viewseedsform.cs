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
    public partial class viewseedsform : Form
    {
        public viewseedsform()
        {
            InitializeComponent();
        }
        public string connectionstring = "Data Source=ISAAK-DESKTOP\\SQLEXPRESS;Initial Catalog = HYDROPONICSAPP; Integrated Security = True";
        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            int id;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["seedlingid"].Value.ToString());
            SqlCommand delete = new SqlCommand("DELETE FROM SEEDLINGS WHERE seedlingid = " + id, con);
            delete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SEEDLINGS", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void viewseedsform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SEEDLINGS", con);
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
