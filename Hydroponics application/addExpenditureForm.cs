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
    public partial class addExpenditureForm : Form
    {
        public Form RefToMainForm { get; set; }

        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public addExpenditureForm()
        {
            InitializeComponent();
        }

        public void loadTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadTable = new SqlCommand("SELECT * FROM EXPENDITURES", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadTable;
            DataTable table = new DataTable();
            table.Clear();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void addExpenditureForm_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }
    }
}
