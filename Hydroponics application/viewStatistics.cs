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

            label1.Text = getTotalExpenditure(expenditureTable).ToString();
            label2.Text = getTotalIncome(incomeTable).ToString();
        }

        
        public void addDataToFinanceTable(double income = 0, double expense = 0, double earnings = 0, double date = 1/11/2023)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("INSERT INTO FINANCE VALUES(@income, @expense, @earnings, @date)", con);
            command.Parameters.AddWithValue("income", income);
            command.Parameters.AddWithValue("expense", expense);
            command.Parameters.AddWithValue("earnings", earnings);
            command.Parameters.AddWithValue("date", date);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public double getTotalExpenditure(DataTable a)
        {
            double total = 0;
            //string[] array = new string[a.Rows.Count];
            for (int i = 0; i < a.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView3.Rows[i].Cells[5].Value);
            }
            return total;
        }

        public double getTotalIncome(DataTable a)
        {
            double total = 0;
            //string[] array = new string[a.Rows.Count];
            for (int i = 0; i < a.Rows.Count; i++)
            {
                total += Convert.ToDouble(dataGridView4.Rows[i].Cells[5].Value);
            }
            return total;
        }
    }
}
