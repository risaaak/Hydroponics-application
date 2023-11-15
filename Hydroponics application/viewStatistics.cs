using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Hydroponics_application
{
    public partial class viewStatistics : Form
    {
        public Form RefToMainForm { get; set; }
        MainForm mainForm = new MainForm();
        public string connectionString = ConnectionString.connectionString();

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
            loadSeedsTable();
            loadPlantTable();
            loadLettuceSalesTable();
            loadExpenditureTable();
            loadIncomeTable();
            loadWeeklyFinanceTable();
            //loadMonthlyFinanceTable();
            //loadYearlyFinanceTable();
        }
        public void loadSeedsTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadSeedTable = new NpgsqlCommand("SELECT * FROM SEEDS ORDER BY seed_id", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadSeedTable);
            DataTable seeddt = new DataTable();
            seeddt.Clear();
            dataAdapter.Fill(seeddt);
            dataGridView1.DataSource = seeddt;
        }
        public void loadPlantTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadPlantTable = new NpgsqlCommand("SELECT * FROM PLANT", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadPlantTable);
            DataTable plantdt = new DataTable();
            plantdt.Clear();
            dataAdapter.Fill(plantdt);
            dataGridView2.DataSource = plantdt;
        }
        public void loadLettuceSalesTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadLettuceSalesTable = new NpgsqlCommand("SELECT * FROM LETTUCESALES", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadLettuceSalesTable);
            DataTable lettuceSalesTable = new DataTable();
            lettuceSalesTable.Clear();
            dataAdapter.Fill(lettuceSalesTable);
            dataGridView8.DataSource = lettuceSalesTable;
        }
        public void loadExpenditureTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadExpenditureTable = new NpgsqlCommand("SELECT * FROM EXPENDITURES", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadExpenditureTable);
            DataTable expenditureTable = new DataTable();
            expenditureTable.Clear();
            dataAdapter.Fill(expenditureTable);
            dataGridView3.DataSource = expenditureTable;
        }
        public void loadIncomeTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadIncomeTable = new NpgsqlCommand("SELECT * FROM INCOME", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadIncomeTable);
            DataTable incomeTable = new DataTable();
            incomeTable.Clear();
            dataAdapter.Fill(incomeTable);
            dataGridView4.DataSource = incomeTable;
        }
        public void loadWeeklyFinanceTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadWeeklyFinanceTable = new NpgsqlCommand("SELECT * FROM INSERTINTOWEEKLYFINANCE()", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadWeeklyFinanceTable);
            DataTable WeeklyfinanceTable = new DataTable();
            WeeklyfinanceTable.Clear();
            dataAdapter.Fill(WeeklyfinanceTable);
            dataGridView5.DataSource = WeeklyfinanceTable;
        }

        public void loadMonthlyFinanceTable()
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadMonthlyFinanceTable = new NpgsqlCommand("EXEC MONTHLYFINANCEPROCEDURE", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadMonthlyFinanceTable);
            DataTable MonthlyfinanceTable = new DataTable();
            MonthlyfinanceTable.Clear();
            dataAdapter.Fill(MonthlyfinanceTable);
            dataGridView6.DataSource = MonthlyfinanceTable;
        }

        public void loadYearlyFinanceTable() 
        {
            NpgsqlConnection con = new NpgsqlConnection(connectionString);
            NpgsqlCommand loadYearlyFinanceTable = new NpgsqlCommand("EXEC YEARLYFINANCEPROCEDURE", con);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(loadYearlyFinanceTable);
            DataTable YearlyfinanceTable = new DataTable();
            YearlyfinanceTable.Clear();
            dataAdapter.Fill(YearlyfinanceTable);
            dataGridView7.DataSource = YearlyfinanceTable;
        }
        /*
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

        public double getTotalExpensePerMonth(int date)
        {
            double total = 0;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("select item_total_amount from EXPENDITURES where MONTH(item_date) = @month", con);
            con.Open();

            command.Parameters.AddWithValue("month", date);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                total += read.GetDouble(0);
            }
            con.Close();
            return total;
        }
        */
    }
}
