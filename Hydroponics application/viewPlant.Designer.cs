namespace Hydroponics_application
{
    partial class viewPlant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hYDROPONICS_TESTDataSet = new Hydroponics_application.HYDROPONICS_TESTDataSet();
            this.hYDROPONICSTESTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hYDROPONICS_TESTDataSet1 = new Hydroponics_application.HYDROPONICS_TESTDataSet1();
            this.pLANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANTTableAdapter = new Hydroponics_application.HYDROPONICS_TESTDataSet1TableAdapters.PLANTTableAdapter();
            this.hYDROPONICS_TESTDataSet2 = new Hydroponics_application.HYDROPONICS_TESTDataSet2();
            this.pLANTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pLANTTableAdapter1 = new Hydroponics_application.HYDROPONICS_TESTDataSet2TableAdapters.PLANTTableAdapter();
            this.plantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seednameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sowdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nosolutiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextplantdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICSTESTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantidDataGridViewTextBoxColumn,
            this.seednameDataGridViewTextBoxColumn,
            this.sowdateDataGridViewTextBoxColumn,
            this.nosolutiondateDataGridViewTextBoxColumn,
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn,
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn,
            this.transferdateDataGridViewTextBoxColumn,
            this.harvestdateDataGridViewTextBoxColumn,
            this.nextplantdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pLANTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // hYDROPONICS_TESTDataSet
            // 
            this.hYDROPONICS_TESTDataSet.DataSetName = "HYDROPONICS_TESTDataSet";
            this.hYDROPONICS_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hYDROPONICSTESTDataSetBindingSource
            // 
            this.hYDROPONICSTESTDataSetBindingSource.DataSource = this.hYDROPONICS_TESTDataSet;
            this.hYDROPONICSTESTDataSetBindingSource.Position = 0;
            // 
            // hYDROPONICS_TESTDataSet1
            // 
            this.hYDROPONICS_TESTDataSet1.DataSetName = "HYDROPONICS_TESTDataSet1";
            this.hYDROPONICS_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANTBindingSource
            // 
            this.pLANTBindingSource.DataMember = "PLANT";
            this.pLANTBindingSource.DataSource = this.hYDROPONICS_TESTDataSet1;
            // 
            // pLANTTableAdapter
            // 
            this.pLANTTableAdapter.ClearBeforeFill = true;
            // 
            // hYDROPONICS_TESTDataSet2
            // 
            this.hYDROPONICS_TESTDataSet2.DataSetName = "HYDROPONICS_TESTDataSet2";
            this.hYDROPONICS_TESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANTBindingSource1
            // 
            this.pLANTBindingSource1.DataMember = "PLANT";
            this.pLANTBindingSource1.DataSource = this.hYDROPONICS_TESTDataSet2;
            // 
            // pLANTTableAdapter1
            // 
            this.pLANTTableAdapter1.ClearBeforeFill = true;
            // 
            // plantidDataGridViewTextBoxColumn
            // 
            this.plantidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantidDataGridViewTextBoxColumn.DataPropertyName = "plant_id";
            this.plantidDataGridViewTextBoxColumn.HeaderText = "PLANT ID";
            this.plantidDataGridViewTextBoxColumn.Name = "plantidDataGridViewTextBoxColumn";
            this.plantidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seednameDataGridViewTextBoxColumn
            // 
            this.seednameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seednameDataGridViewTextBoxColumn.DataPropertyName = "seed_name";
            this.seednameDataGridViewTextBoxColumn.HeaderText = "SEED NAME";
            this.seednameDataGridViewTextBoxColumn.Name = "seednameDataGridViewTextBoxColumn";
            // 
            // sowdateDataGridViewTextBoxColumn
            // 
            this.sowdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sowdateDataGridViewTextBoxColumn.DataPropertyName = "sow_date";
            this.sowdateDataGridViewTextBoxColumn.HeaderText = "SOW DATE";
            this.sowdateDataGridViewTextBoxColumn.Name = "sowdateDataGridViewTextBoxColumn";
            // 
            // nosolutiondateDataGridViewTextBoxColumn
            // 
            this.nosolutiondateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nosolutiondateDataGridViewTextBoxColumn.DataPropertyName = "no_solution_date";
            this.nosolutiondateDataGridViewTextBoxColumn.HeaderText = "NO SOLUTION DATE";
            this.nosolutiondateDataGridViewTextBoxColumn.Name = "nosolutiondateDataGridViewTextBoxColumn";
            // 
            // halfstrengthsolutiondateDataGridViewTextBoxColumn
            // 
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn.DataPropertyName = "half_strength_solution_date";
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn.HeaderText = "HALF STRENGHT SOLUTION DATE";
            this.halfstrengthsolutiondateDataGridViewTextBoxColumn.Name = "halfstrengthsolutiondateDataGridViewTextBoxColumn";
            // 
            // fullstrengthsolutiondateDataGridViewTextBoxColumn
            // 
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn.DataPropertyName = "full_strength_solution_date";
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn.HeaderText = "FULL STRENGTH SOLUTION DATE";
            this.fullstrengthsolutiondateDataGridViewTextBoxColumn.Name = "fullstrengthsolutiondateDataGridViewTextBoxColumn";
            // 
            // transferdateDataGridViewTextBoxColumn
            // 
            this.transferdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transferdateDataGridViewTextBoxColumn.DataPropertyName = "transfer_date";
            this.transferdateDataGridViewTextBoxColumn.HeaderText = "TRANSFER DATE";
            this.transferdateDataGridViewTextBoxColumn.Name = "transferdateDataGridViewTextBoxColumn";
            // 
            // harvestdateDataGridViewTextBoxColumn
            // 
            this.harvestdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harvestdateDataGridViewTextBoxColumn.DataPropertyName = "harvest_date";
            this.harvestdateDataGridViewTextBoxColumn.HeaderText = "HARVEST DATE";
            this.harvestdateDataGridViewTextBoxColumn.Name = "harvestdateDataGridViewTextBoxColumn";
            // 
            // nextplantdateDataGridViewTextBoxColumn
            // 
            this.nextplantdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nextplantdateDataGridViewTextBoxColumn.DataPropertyName = "next_plant_date";
            this.nextplantdateDataGridViewTextBoxColumn.HeaderText = "NEXT PLANT DATE";
            this.nextplantdateDataGridViewTextBoxColumn.Name = "nextplantdateDataGridViewTextBoxColumn";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // viewPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewPlant";
            this.Text = "viewPlant";
            this.Load += new System.EventHandler(this.viewPlant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICSTESTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hYDROPONICSTESTDataSetBindingSource;
        private HYDROPONICS_TESTDataSet hYDROPONICS_TESTDataSet;
        private HYDROPONICS_TESTDataSet1 hYDROPONICS_TESTDataSet1;
        private System.Windows.Forms.BindingSource pLANTBindingSource;
        private HYDROPONICS_TESTDataSet1TableAdapters.PLANTTableAdapter pLANTTableAdapter;
        private HYDROPONICS_TESTDataSet2 hYDROPONICS_TESTDataSet2;
        private System.Windows.Forms.BindingSource pLANTBindingSource1;
        private HYDROPONICS_TESTDataSet2TableAdapters.PLANTTableAdapter pLANTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seednameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sowdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nosolutiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn halfstrengthsolutiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullstrengthsolutiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextplantdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backButton;
    }
}