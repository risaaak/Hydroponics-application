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
    public partial class viewseedlingtrayform : Form
    {
        public viewseedlingtrayform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        public string connectionstring = "Data Source=ISAAKLAPTOP\\SQLEXPRESS;Initial Catalog = HYDROPONICS; Integrated Security = True";

        private void button1_Click_1(object sender, EventArgs e)
        {


            DateTime nosolutiondate, halfstrengthdate, fullstrengthdate, harvestdate, nextplantdate, dateplanted;
            //SqlCommand getnosolutiondate = new SqlCommand("SELECT nosolutiondate FROM HYDROPONICS WHERE growboxid = '" + textBox1.Text + "'",con);

            //SqlCommand getplantdate = new SqlCommand("SELECT dateplanted FROM HYDROPONICS WHERE growboxid ='" + textBox1.Text + "'", con);
            //nosolutiondate = (DateTime)getnosolutiondate.ExecuteScalar();
            //label5.Text = nosolutiondate.ToString("MM/dd/yyyy");
            /*int id = Convert.ToInt32(textBox1.Text);
            dateplanted = getplantdate(id);
            nosolutiondate = getplantdate(id).AddDays(6);
            halfstrengthdate = nosolutiondate.AddDays(6);
            fullstrengthdate = halfstrengthdate.AddDays(2);
            harvestdate = fullstrengthdate.AddDays(25);
            nextplantdate = harvestdate.AddDays(-15);
            label5.Text = dateplanted.ToString("MM/dd/yyyy") + "   to   " + nosolutiondate.ToString("MM/dd/yyyy");
            label6.Text = nosolutiondate.AddDays(1).ToString("MM/dd/yyyy") + "    to    " + halfstrengthdate.ToString("MM/dd/yyyy");
            label7.Text = halfstrengthdate.AddDays(1).ToString("MM/dd/yyyy") + "    to   " + fullstrengthdate.ToString("MM/dd/yyyy");
            label9.Text = harvestdate.ToString("MM/dd/yyyy");
            label11.Text = nextplantdate.ToString("MM/dd/yyyy");*/
        }

        public DateTime getplantdate(int id)
        {
            bool flag = false;
            DateTime dateplanted = DateTime.Now;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand verifyExistence = new SqlCommand("SELECT seedlingtrayid from SEEDLINGTRAY WHERE seedlingtrayid ='" + id + "'",con);
            SqlDataReader read = verifyExistence.ExecuteReader();
            while(read.Read())
            {
                if (Convert.ToInt32(read[0]) == id);
                {
                    flag = true;
                    con.Close();
                    break;
                }
            }
            if (flag == true)
            {
                SqlCommand getplantdate = new SqlCommand("SELECT plantdate FROM SEEDLINGTRAY WHERE seedlingtrayid ='" + id + "'", con);
                con.Open();
                dateplanted = (DateTime)getplantdate.ExecuteScalar();
            }
            else
            {
                MessageBox.Show("does not exists");
            }
            return dateplanted;
        }
        public DateTime getnosolutiondate(int id)
        {
            DateTime nosolutiondate;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand getnosolutiondate = new SqlCommand("SELECT nosolutiondate FROM SEEDLINGTRAY WHERE seedlingtrayid = '" + id + "'", con);
            nosolutiondate = (DateTime)getnosolutiondate.ExecuteScalar();
            return nosolutiondate;
            con.Close ();
        }
        private void viewseedlingtrayform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SEEDLINGTRAY",con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection (connectionstring);
            con.Open();
            SqlCommand delete = new SqlCommand();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["seedlingtrayid"].Value.ToString());

            delete.CommandText = "DELETE FROM SEEDLINGTRAY WHERE seedlingtrayid = " + id;
            delete.Connection = con;
            delete.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM SEEDLINGTRAY", con);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close ();




            /*
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM SEEDLINGTRAY WHERE seedlingtrayid = " + textBox1.Text, con);
            delete.ExecuteNonQuery();
            con.Close();
            */
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
