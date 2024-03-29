﻿using System;
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
            loadSeedsTable();
            loadPlantTable();
            loadLettuceSalesTable();
            loadExpenditureTable();
            loadIncomeTable();
            loadWeeklyFinanceTable();
            loadMonthlyFinanceTable();
            loadYearlyFinanceTable();
        }
        public void loadSeedsTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadSeedTable = new SqlCommand("SELECT * FROM SEEDS", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadSeedTable;
            DataTable seeddt = new DataTable();
            seeddt.Clear();
            dataAdapter.Fill(seeddt);
            dataGridView1.DataSource = seeddt;
        }
        public void loadPlantTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadPlantTable = new SqlCommand("SELECT * FROM PLANT", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadPlantTable;
            DataTable plantdt = new DataTable();
            plantdt.Clear();
            dataAdapter.Fill(plantdt);
            dataGridView2.DataSource = plantdt;
        }
        public void loadLettuceSalesTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadLettuceSalesTable = new SqlCommand("SELECT * FROM LETTUCESALES", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand= loadLettuceSalesTable;
            DataTable lettuceSalesTable = new DataTable();
            lettuceSalesTable.Clear();
            dataAdapter.Fill(lettuceSalesTable);
            dataGridView8.DataSource = lettuceSalesTable;
        }
        public void loadExpenditureTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadExpenditureTable = new SqlCommand("SELECT * FROM EXPENDITURES", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadExpenditureTable;
            DataTable expenditureTable = new DataTable();
            expenditureTable.Clear();
            dataAdapter.Fill(expenditureTable);
            dataGridView3.DataSource = expenditureTable;
        }
        public void loadIncomeTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadIncomeTable = new SqlCommand("SELECT * FROM INCOME", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadIncomeTable;
            DataTable incomeTable = new DataTable();
            incomeTable.Clear();
            dataAdapter.Fill(incomeTable);
            dataGridView4.DataSource = incomeTable;
        }
        public void loadWeeklyFinanceTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadWeeklyFinanceTable = new SqlCommand("EXEC INSERTINTOWEEKLYFINANCE", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadWeeklyFinanceTable;
            DataTable WeeklyfinanceTable = new DataTable();
            WeeklyfinanceTable.Clear();
            dataAdapter.Fill(WeeklyfinanceTable);
            dataGridView5.DataSource = WeeklyfinanceTable;
        }

        public void loadMonthlyFinanceTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadMonthlyFinanceTable = new SqlCommand("EXEC MONTHLYFINANCEPROCEDURE", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadMonthlyFinanceTable;
            DataTable MonthlyfinanceTable = new DataTable();
            MonthlyfinanceTable.Clear();
            dataAdapter.Fill(MonthlyfinanceTable);
            dataGridView6.DataSource = MonthlyfinanceTable;
        }

        public void loadYearlyFinanceTable() 
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadYearlyFinanceTable = new SqlCommand("EXEC YEARLYFINANCEPROCEDURE", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadYearlyFinanceTable;
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
