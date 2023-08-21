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
    public partial class viewStatistics : Form
    {
        public Form RefToMainForm { get; set; }
        MainForm mainForm = new MainForm();
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public viewStatistics()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        private void viewStatistics_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadSeedTable = new SqlCommand("SELECT * FROM SEEDS", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadSeedTable;
            DataTable seeddt = new DataTable();
            seeddt.Clear();
            dataAdapter.Fill(seeddt);
            dataGridView1.DataSource = seeddt;

            SqlCommand loadPlantTable = new SqlCommand("SELECT * FROM PLANT", con);
            dataAdapter.SelectCommand = loadPlantTable;
            DataTable plantdt = new DataTable();
            plantdt.Clear();
            dataAdapter.Fill(plantdt);
            dataGridView2.DataSource = plantdt;

            SqlCommand loadExpenditureTable = new SqlCommand("SELECT * FROM EXPENDITURES", con);
            dataAdapter.SelectCommand = loadExpenditureTable;
            DataTable expenditureTable = new DataTable();
            expenditureTable.Clear();
            dataAdapter.Fill(expenditureTable);
            dataGridView3.DataSource = expenditureTable;

            SqlCommand loadIncomeTable = new SqlCommand("SELECT * FROM INCOME", con);
            dataAdapter.SelectCommand = loadIncomeTable;
            DataTable incomeTable = new DataTable();
            incomeTable.Clear();
            dataAdapter.Fill(incomeTable);
            dataGridView4.DataSource = incomeTable;

            SqlCommand loadFinanceTable = new SqlCommand("SELECT * FROM FINANCE", con);
            dataAdapter.SelectCommand = loadFinanceTable;
            DataTable financeTable = new DataTable();
            financeTable.Clear();
            dataAdapter.Fill(financeTable);
            dataGridView5.DataSource = financeTable;
        }
    }
}
