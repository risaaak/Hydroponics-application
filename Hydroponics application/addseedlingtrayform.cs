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
    public partial class addseedlingtrayform : Form
    {
        public addseedlingtrayform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        public string connectionstring = "Data Source=ISAAK-DESKTOP\\SQLEXPRESS;Initial Catalog = HYDROPONICSAPP; Integrated Security = True";
        private void button2_Click(object sender, EventArgs e)
        {
            int seedlingtrayid;
            DateTime nosolutiondate, halfstrengthdate, fullstrengthdate, harvestdate, nextplantdate, plantdate;
            plantdate = Convert.ToDateTime(dateTimePicker1.Value);
            nosolutiondate = plantdate.AddDays(6);
            halfstrengthdate = nosolutiondate.AddDays(6);
            fullstrengthdate = halfstrengthdate.AddDays(2);
            harvestdate = fullstrengthdate.AddDays(25);
            nextplantdate = harvestdate.AddDays(-15);
            seedlingtrayid = int.Parse(addgrowboxtextBox.Text);

            label5.Text = plantdate.ToString("MM/dd/yyyy") + " to " + nosolutiondate.ToString("MM/dd/yyyy");
            label6.Text = nosolutiondate.AddDays(1).ToString("MM/dd/yyyy") + " to " + halfstrengthdate.ToString("MM/dd/yyyy");
            label7.Text = halfstrengthdate.AddDays(1).ToString("MM/dd/yyyy") + " to " + fullstrengthdate.ToString("MM/dd/yyyy");
            label9.Text = harvestdate.ToString("MM/dd/yyyy");
            label11.Text = nextplantdate.ToString("MM/dd/yyyy");

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SEEDLINGTRAY VALUES ('" + seedlingtrayid + "', '" + plantdate + "','" + nosolutiondate + "','" + halfstrengthdate + "','" + fullstrengthdate + "', '" + harvestdate + "', '" + nextplantdate + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
