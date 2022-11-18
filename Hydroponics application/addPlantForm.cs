using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydroponics_application
{
    public partial class addPlantForm : Form
    {
        public addPlantForm()
        {
            InitializeComponent();
        }
        DateTime sowDate, noSolutionDate, halfStrengthSolutionDate, fullStrengthSolutionDate, transferDate, harvestDate, nextPlantDate;

        private void addPlantForm_Load(object sender, EventArgs e)
        {
            
        }
        MainForm mainForm = new MainForm();
        private void sowDateButton_Click(object sender, EventArgs e)
        {
            sowDate = dateTimePicker.Value;
            noSolutionDate = mainForm.getNoSolutionDate(sowDate);

            sowDateLbl.Text = sowDate.ToString("MM/dd/yyyy");
            waterWithNoSolutionLbl.Text = noSolutionDate.ToString("MM/dd/yyyy");
        }
    }
}
