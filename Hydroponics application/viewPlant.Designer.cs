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
            this.plantidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sowdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextplantdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedsplantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hYDROPONICS_TESTDataSet2 = new Hydroponics_application.HYDROPONICS_TESTDataSet2();
            this.backButton = new System.Windows.Forms.Button();
            this.hYDROPONICSAPPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANTTableAdapter = new Hydroponics_application.HYDROPONICS_TESTDataSet2TableAdapters.PLANTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICSAPPDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plantidDataGridViewTextBoxColumn,
            this.seedidDataGridViewTextBoxColumn,
            this.sowdateDataGridViewTextBoxColumn,
            this.transferdateDataGridViewTextBoxColumn,
            this.harvestdateDataGridViewTextBoxColumn,
            this.nextplantdateDataGridViewTextBoxColumn,
            this.seedsplantedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pLANTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(985, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // plantidDataGridViewTextBoxColumn
            // 
            this.plantidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plantidDataGridViewTextBoxColumn.DataPropertyName = "plant_id";
            this.plantidDataGridViewTextBoxColumn.HeaderText = "plant_id";
            this.plantidDataGridViewTextBoxColumn.Name = "plantidDataGridViewTextBoxColumn";
            this.plantidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seedidDataGridViewTextBoxColumn
            // 
            this.seedidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedidDataGridViewTextBoxColumn.DataPropertyName = "seed_id";
            this.seedidDataGridViewTextBoxColumn.HeaderText = "seed_id";
            this.seedidDataGridViewTextBoxColumn.Name = "seedidDataGridViewTextBoxColumn";
            // 
            // sowdateDataGridViewTextBoxColumn
            // 
            this.sowdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sowdateDataGridViewTextBoxColumn.DataPropertyName = "sow_date";
            this.sowdateDataGridViewTextBoxColumn.HeaderText = "sow_date";
            this.sowdateDataGridViewTextBoxColumn.Name = "sowdateDataGridViewTextBoxColumn";
            // 
            // transferdateDataGridViewTextBoxColumn
            // 
            this.transferdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transferdateDataGridViewTextBoxColumn.DataPropertyName = "transfer_date";
            this.transferdateDataGridViewTextBoxColumn.HeaderText = "transfer_date";
            this.transferdateDataGridViewTextBoxColumn.Name = "transferdateDataGridViewTextBoxColumn";
            // 
            // harvestdateDataGridViewTextBoxColumn
            // 
            this.harvestdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harvestdateDataGridViewTextBoxColumn.DataPropertyName = "harvest_date";
            this.harvestdateDataGridViewTextBoxColumn.HeaderText = "harvest_date";
            this.harvestdateDataGridViewTextBoxColumn.Name = "harvestdateDataGridViewTextBoxColumn";
            // 
            // nextplantdateDataGridViewTextBoxColumn
            // 
            this.nextplantdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nextplantdateDataGridViewTextBoxColumn.DataPropertyName = "next_plant_date";
            this.nextplantdateDataGridViewTextBoxColumn.HeaderText = "next_plant_date";
            this.nextplantdateDataGridViewTextBoxColumn.Name = "nextplantdateDataGridViewTextBoxColumn";
            // 
            // seedsplantedDataGridViewTextBoxColumn
            // 
            this.seedsplantedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedsplantedDataGridViewTextBoxColumn.DataPropertyName = "seeds_planted";
            this.seedsplantedDataGridViewTextBoxColumn.HeaderText = "seeds_planted";
            this.seedsplantedDataGridViewTextBoxColumn.Name = "seedsplantedDataGridViewTextBoxColumn";
            // 
            // pLANTBindingSource
            // 
            this.pLANTBindingSource.DataMember = "PLANT";
            this.pLANTBindingSource.DataSource = this.hYDROPONICS_TESTDataSet2;
            // 
            // hYDROPONICS_TESTDataSet2
            // 
            this.hYDROPONICS_TESTDataSet2.DataSetName = "HYDROPONICS_TESTDataSet2";
            this.hYDROPONICS_TESTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pLANTTableAdapter
            // 
            this.pLANTTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICSAPPDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource hYDROPONICSAPPDataSetBindingSource;
        private HYDROPONICS_TESTDataSet2 hYDROPONICS_TESTDataSet2;
        private System.Windows.Forms.BindingSource pLANTBindingSource;
        private HYDROPONICS_TESTDataSet2TableAdapters.PLANTTableAdapter pLANTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sowdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextplantdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedsplantedDataGridViewTextBoxColumn;
    }
}