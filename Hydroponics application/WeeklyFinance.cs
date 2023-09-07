using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydroponics_application
{
    public class WeeklyFinance
    {
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void updateWeeklyFinance(DateTime week, DateTime month, DateTime year, double cash_outflow, double cash_inflow, double earnings)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand updateWeeklyFinance = new SqlCommand("INSERT INTO WEEKLYFINANCE VALUES(@week, @year, @cash_outflow, @cash_inflow, @earnings)", con);
            updateWeeklyFinance.Parameters.AddWithValue("week", week);
            updateWeeklyFinance.Parameters.AddWithValue("year", year);
            updateWeeklyFinance.Parameters.AddWithValue("cash_outflow", cash_outflow);
            updateWeeklyFinance.Parameters.AddWithValue("cash_inflow", cash_inflow);
            updateWeeklyFinance.Parameters.AddWithValue("earnings", earnings);
            con.Open();
            updateWeeklyFinance.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
        }

        public double getExpenseFromExpenseTable(int week)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand getWeekFromExpenseTable = new SqlCommand("SELECT SUM(item_total_amount) FROM EXPENDITURES " +
                "where datepart(ISOWK,item_date) = @week", con);
            getWeekFromExpenseTable.Parameters.AddWithValue("week", week);
            con.Open();
            double sum = Convert.ToDouble(getWeekFromExpenseTable.ExecuteScalar());
            con.Close();

            return sum;
        }

        public double getIncomeFromIncomeTable(int week)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand getWeekFromIncomeTable = new SqlCommand("SELECT SUM(total_amount) FROM INCOME " +
                "where datepart(ISOWK,income_date) = @week", con);
            getWeekFromIncomeTable.Parameters.AddWithValue("week", week);
            con.Open();
            double sum = Convert.ToDouble(getWeekFromIncomeTable.ExecuteScalar());
            con.Close();

            return sum;
        }


    }
}
