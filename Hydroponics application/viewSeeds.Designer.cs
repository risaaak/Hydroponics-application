namespace Hydroponics_application
{
    partial class viewSeeds
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
            this.seedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seednameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedtimesplantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedtimessproutedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seedgerminationrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.hYDROPONICS_TESTDataSet1 = new Hydroponics_application.HYDROPONICS_TESTDataSet1();
            this.sEEDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEEDSTableAdapter = new Hydroponics_application.HYDROPONICS_TESTDataSet1TableAdapters.SEEDSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEEDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seedidDataGridViewTextBoxColumn,
            this.seednameDataGridViewTextBoxColumn,
            this.seedtimesplantedDataGridViewTextBoxColumn,
            this.seedtimessproutedDataGridViewTextBoxColumn,
            this.seedgerminationrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sEEDSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 389);
            this.dataGridView1.TabIndex = 1;
            // 
            // seedidDataGridViewTextBoxColumn
            // 
            this.seedidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedidDataGridViewTextBoxColumn.DataPropertyName = "seed_id";
            this.seedidDataGridViewTextBoxColumn.HeaderText = "SEED ID";
            this.seedidDataGridViewTextBoxColumn.Name = "seedidDataGridViewTextBoxColumn";
            this.seedidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seednameDataGridViewTextBoxColumn
            // 
            this.seednameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seednameDataGridViewTextBoxColumn.DataPropertyName = "seed_name";
            this.seednameDataGridViewTextBoxColumn.HeaderText = "SEED NAME";
            this.seednameDataGridViewTextBoxColumn.Name = "seednameDataGridViewTextBoxColumn";
            // 
            // seedtimesplantedDataGridViewTextBoxColumn
            // 
            this.seedtimesplantedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedtimesplantedDataGridViewTextBoxColumn.DataPropertyName = "seed_times_planted";
            this.seedtimesplantedDataGridViewTextBoxColumn.HeaderText = "TIMES PLANTED";
            this.seedtimesplantedDataGridViewTextBoxColumn.Name = "seedtimesplantedDataGridViewTextBoxColumn";
            // 
            // seedtimessproutedDataGridViewTextBoxColumn
            // 
            this.seedtimessproutedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedtimessproutedDataGridViewTextBoxColumn.DataPropertyName = "seed_times_sprouted";
            this.seedtimessproutedDataGridViewTextBoxColumn.HeaderText = "TIMES SPROUTED";
            this.seedtimessproutedDataGridViewTextBoxColumn.Name = "seedtimessproutedDataGridViewTextBoxColumn";
            // 
            // seedgerminationrateDataGridViewTextBoxColumn
            // 
            this.seedgerminationrateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seedgerminationrateDataGridViewTextBoxColumn.DataPropertyName = "seed_germination_rate";
            this.seedgerminationrateDataGridViewTextBoxColumn.HeaderText = "GERMINATION RATE";
            this.seedgerminationrateDataGridViewTextBoxColumn.Name = "seedgerminationrateDataGridViewTextBoxColumn";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hYDROPONICS_TESTDataSet1
            // 
            this.hYDROPONICS_TESTDataSet1.DataSetName = "HYDROPONICS_TESTDataSet1";
            this.hYDROPONICS_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEEDSBindingSource
            // 
            this.sEEDSBindingSource.DataMember = "SEEDS";
            this.sEEDSBindingSource.DataSource = this.hYDROPONICS_TESTDataSet1;
            // 
            // sEEDSTableAdapter
            // 
            this.sEEDSTableAdapter.ClearBeforeFill = true;
            // 
            // viewSeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewSeeds";
            this.Text = "viewSeeds";
            this.Load += new System.EventHandler(this.viewSeeds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEEDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seednameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedtimesplantedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedtimessproutedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seedgerminationrateDataGridViewTextBoxColumn;
        private HYDROPONICS_TESTDataSet1 hYDROPONICS_TESTDataSet1;
        private System.Windows.Forms.BindingSource sEEDSBindingSource;
        private HYDROPONICS_TESTDataSet1TableAdapters.SEEDSTableAdapter sEEDSTableAdapter;
    }
}