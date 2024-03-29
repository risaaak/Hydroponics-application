﻿using System;
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
    public partial class AddIncomeForm : Form
    {
        public Form RefToMainForm { get; set; }
        public AddIncomeForm()
        {
            InitializeComponent();
        }

        int quantity;
        double price, totalAmount, totalWeight, averageWeight;
        string name, description;
        DateTime date;
        public string connectionString = "Data Source=MY-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICS_TEST;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public void loadTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand loadTable = new SqlCommand("SELECT * FROM INCOME", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = loadTable;
            DataTable dt = new DataTable();
            dt.Clear();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            name = productNameTextBox.Text;
            description = productDescriptionBox.Text;
            quantity = Convert.ToInt32(quantityTextbox.Text);
            price = Convert.ToDouble(pricePerPieceTextbox.Text);
            date = dateTimePicker1.Value;
            totalAmount = getTotalAmount(quantity,price);
            if (typeComboBox.Text == "Others")
            {
                totalWeight = 0;
            }
            else
                //TODO: Fix error
                name = "Lettuce";
                totalWeight = Convert.ToDouble(weightTextbox.Text);
            averageWeight = totalWeight / quantity;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand sendDataToDatabase = new SqlCommand("INSERT INTO INCOME VALUES(@incomeDescription, @name, @quantity, @pricePerPiece," +
                " @totalAmount, @incomeDate)",con);
            sendDataToDatabase.Parameters.AddWithValue("name", name);
            sendDataToDatabase.Parameters.AddWithValue ("incomeDescription", description);
            sendDataToDatabase.Parameters.AddWithValue("quantity", quantity);
            sendDataToDatabase.Parameters.AddWithValue("pricePerPiece", price);
            sendDataToDatabase.Parameters.AddWithValue("totalAmount", totalAmount);
            sendDataToDatabase.Parameters.AddWithValue("incomeDate", date);

            con.Open();
            sendDataToDatabase.ExecuteNonQuery();
            con.Close();
            if(typeComboBox.Text == "Lettuce")
            {
                SqlCommand sendToLettuceSalesTable = new SqlCommand("INSERT INTO LETTUCESALES VALUES(@DATE, @COUNT, @TOTAL_WEIGHT,@AVERAGE_WEIGHT)", con);
                sendToLettuceSalesTable.Parameters.AddWithValue("DATE", date);
                sendToLettuceSalesTable.Parameters.AddWithValue("COUNT", quantity);
                sendToLettuceSalesTable.Parameters.AddWithValue("TOTAL_WEIGHT", totalWeight);
                sendToLettuceSalesTable.Parameters.AddWithValue("AVERAGE_WEIGHT", averageWeight);
                using(con)
                {
                    con.Open();
                    sendToLettuceSalesTable.ExecuteNonQuery();
                }

            }
            loadTable();
        }
        public double getTotalAmount(int quantity, double totalAmount)
        {
            totalAmount = quantity * totalAmount;
            return totalAmount;
        }
        private void AddIncomeForm_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.Close();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeComboBox.Text == "Lettuce")
            {
                productNameLabel.Visible = false;
                productNameTextBox.Visible = false;
                weightLabel.Visible = true;
                weightTextbox.Visible = true;
            }
            else
            {
                productNameLabel.Visible = true;
                productNameTextBox.Visible = true;
                weightLabel.Visible = false;
                weightTextbox.Visible = false;
            }
        }

        private void quantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' )
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

        private void pricePerPiece_Keypress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }
    }
}

