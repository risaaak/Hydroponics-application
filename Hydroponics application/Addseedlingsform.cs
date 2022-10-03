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
    public partial class Add_Seedlings : Form
    {
        public Add_Seedlings()
        {
            InitializeComponent();
        }

        public string connectionstring = "Data Source=ISAAK-DESKTOP\\SQLEXPRESS;Initial Catalog=HYDROPONICSAPP;Integrated Security=True";
        private void addseedbtn_Click(object sender, EventArgs e)
        {
            string seedname = seednametxtbox.Text.ToUpper();

            SqlConnection con = new SqlConnection(connectionstring);
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                /*
                SqlCommand command = new SqlCommand("INSERT INTO SEEDLINGS VALUES('" + seedname + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("successfull");
                */
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT SEEDLINGS (seedlingname,timesplanted,timessprouted,germinationrate) VALUES ( @seedname, null, null,null)";
                cmd.Parameters.AddWithValue("@seedname",seedname);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Add_Seedlings_Load(object sender, EventArgs e)
        {

        }
    }
}
