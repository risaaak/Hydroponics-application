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
        string name, description;
        int quantity;
        double price, totalAmount;
        DateTime date;

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

        public double getTotalAmount(int quantity, double price)
        {  
            return price * quantity; 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            name = itemNameTextbox.Text;
            description = itemDescriptionTextbox.Text;
            price = Convert.ToDouble(itemPriceTextBox.Text);
            quantity = Convert.ToInt32(itemQuantityTextbox.Text);
            totalAmount = getTotalAmount(quantity, price *-1);
            date = DateTime.Now;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand sendDataToDatabase = new SqlCommand("INSERT INTO EXPENDITURES VALUES(@name, @description, @quantity, @price, " +
                "@totalAmount, @date)", con);
            sendDataToDatabase.Parameters.AddWithValue("name", name);
            sendDataToDatabase.Parameters.AddWithValue("description", description);
            sendDataToDatabase.Parameters.AddWithValue("quantity", quantity);
            sendDataToDatabase.Parameters.AddWithValue("price", price);
            sendDataToDatabase.Parameters.AddWithValue("totalAmount", totalAmount);
            sendDataToDatabase.Parameters.AddWithValue("date", date);

            con.Open();
            sendDataToDatabase.ExecuteNonQuery();
            con.Close();
            loadTable();

        }

        private void itemQuantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false; //Do not reject the input
            }
            else if (e.KeyChar == ((char)Keys.Back)) //backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void itemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
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
