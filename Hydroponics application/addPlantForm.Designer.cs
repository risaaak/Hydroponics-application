namespace Hydroponics_application
{
    partial class addPlantForm
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
            this.NextPlantDateLbl = new System.Windows.Forms.Label();
            this.nextPlantDateLabel = new System.Windows.Forms.Label();
            this.harvestDateLbl = new System.Windows.Forms.Label();
            this.transferDateLbl = new System.Windows.Forms.Label();
            this.harvestDateLabel = new System.Windows.Forms.Label();
            this.transferDateLabel = new System.Windows.Forms.Label();
            this.sowDateLbl = new System.Windows.Forms.Label();
            this.sowDateLabel = new System.Windows.Forms.Label();
            this.transferDateButton = new System.Windows.Forms.Button();
            this.sowDateButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sEEDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hYDROPONICS_TESTDataSet1 = new Hydroponics_application.HYDROPONICS_TESTDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.sEEDSTableAdapter = new Hydroponics_application.HYDROPONICS_TESTDataSet1TableAdapters.SEEDSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sEEDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // NextPlantDateLbl
            // 
            this.NextPlantDateLbl.AutoSize = true;
            this.NextPlantDateLbl.Location = new System.Drawing.Point(162, 279);
            this.NextPlantDateLbl.Name = "NextPlantDateLbl";
            this.NextPlantDateLbl.Size = new System.Drawing.Size(0, 13);
            this.NextPlantDateLbl.TabIndex = 41;
            // 
            // nextPlantDateLabel
            // 
            this.nextPlantDateLabel.AutoSize = true;
            this.nextPlantDateLabel.Location = new System.Drawing.Point(84, 279);
            this.nextPlantDateLabel.Name = "nextPlantDateLabel";
            this.nextPlantDateLabel.Size = new System.Drawing.Size(59, 13);
            this.nextPlantDateLabel.TabIndex = 40;
            this.nextPlantDateLabel.Text = "Next Plant:";
            // 
            // harvestDateLbl
            // 
            this.harvestDateLbl.AutoSize = true;
            this.harvestDateLbl.Location = new System.Drawing.Point(165, 253);
            this.harvestDateLbl.Name = "harvestDateLbl";
            this.harvestDateLbl.Size = new System.Drawing.Size(0, 13);
            this.harvestDateLbl.TabIndex = 39;
            // 
            // transferDateLbl
            // 
            this.transferDateLbl.AutoSize = true;
            this.transferDateLbl.Location = new System.Drawing.Point(165, 224);
            this.transferDateLbl.Name = "transferDateLbl";
            this.transferDateLbl.Size = new System.Drawing.Size(0, 13);
            this.transferDateLbl.TabIndex = 38;
            // 
            // harvestDateLabel
            // 
            this.harvestDateLabel.AutoSize = true;
            this.harvestDateLabel.Location = new System.Drawing.Point(70, 253);
            this.harvestDateLabel.Name = "harvestDateLabel";
            this.harvestDateLabel.Size = new System.Drawing.Size(73, 13);
            this.harvestDateLabel.TabIndex = 37;
            this.harvestDateLabel.Text = "Harvest Date:";
            // 
            // transferDateLabel
            // 
            this.transferDateLabel.AutoSize = true;
            this.transferDateLabel.Location = new System.Drawing.Point(68, 224);
            this.transferDateLabel.Name = "transferDateLabel";
            this.transferDateLabel.Size = new System.Drawing.Size(75, 13);
            this.transferDateLabel.TabIndex = 36;
            this.transferDateLabel.Text = "Transfer Date:";
            // 
            // sowDateLbl
            // 
            this.sowDateLbl.AutoSize = true;
            this.sowDateLbl.Location = new System.Drawing.Point(160, 196);
            this.sowDateLbl.Name = "sowDateLbl";
            this.sowDateLbl.Size = new System.Drawing.Size(0, 13);
            this.sowDateLbl.TabIndex = 29;
            // 
            // sowDateLabel
            // 
            this.sowDateLabel.AutoSize = true;
            this.sowDateLabel.Location = new System.Drawing.Point(84, 196);
            this.sowDateLabel.Name = "sowDateLabel";
            this.sowDateLabel.Size = new System.Drawing.Size(57, 13);
            this.sowDateLabel.TabIndex = 28;
            this.sowDateLabel.Text = "Sow Date:";
            // 
            // transferDateButton
            // 
            this.transferDateButton.Location = new System.Drawing.Point(147, 96);
            this.transferDateButton.Name = "transferDateButton";
            this.transferDateButton.Size = new System.Drawing.Size(108, 23);
            this.transferDateButton.TabIndex = 27;
            this.transferDateButton.Text = "Transfer Date";
            this.transferDateButton.UseVisualStyleBackColor = true;
            this.transferDateButton.Click += new System.EventHandler(this.transferDateButton_Click);
            // 
            // sowDateButton
            // 
            this.sowDateButton.Location = new System.Drawing.Point(33, 96);
            this.sowDateButton.Name = "sowDateButton";
            this.sowDateButton.Size = new System.Drawing.Size(108, 23);
            this.sowDateButton.TabIndex = 26;
            this.sowDateButton.Text = "Sow Date";
            this.sowDateButton.UseVisualStyleBackColor = true;
            this.sowDateButton.Click += new System.EventHandler(this.sowDateButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(68, 62);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "Date: ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(119, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // sEEDSBindingSource
            // 
            this.sEEDSBindingSource.DataMember = "SEEDS";
            this.sEEDSBindingSource.DataSource = this.hYDROPONICS_TESTDataSet1;
            // 
            // hYDROPONICS_TESTDataSet1
            // 
            this.hYDROPONICS_TESTDataSet1.DataSetName = "HYDROPONICS_TESTDataSet1";
            this.hYDROPONICS_TESTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Seed:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Number of seeds planted:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // sEEDSTableAdapter
            // 
            this.sEEDSTableAdapter.ClearBeforeFill = true;
            // 
            // addPlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 330);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NextPlantDateLbl);
            this.Controls.Add(this.nextPlantDateLabel);
            this.Controls.Add(this.harvestDateLbl);
            this.Controls.Add(this.transferDateLbl);
            this.Controls.Add(this.harvestDateLabel);
            this.Controls.Add(this.transferDateLabel);
            this.Controls.Add(this.sowDateLbl);
            this.Controls.Add(this.sowDateLabel);
            this.Controls.Add(this.transferDateButton);
            this.Controls.Add(this.sowDateButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "addPlantForm";
            this.Load += new System.EventHandler(this.addPlantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sEEDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYDROPONICS_TESTDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NextPlantDateLbl;
        private System.Windows.Forms.Label nextPlantDateLabel;
        private System.Windows.Forms.Label harvestDateLbl;
        private System.Windows.Forms.Label transferDateLbl;
        private System.Windows.Forms.Label harvestDateLabel;
        private System.Windows.Forms.Label transferDateLabel;
        private System.Windows.Forms.Label sowDateLbl;
        private System.Windows.Forms.Label sowDateLabel;
        private System.Windows.Forms.Button transferDateButton;
        private System.Windows.Forms.Button sowDateButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private HYDROPONICS_TESTDataSet1 hYDROPONICS_TESTDataSet1;
        private System.Windows.Forms.BindingSource sEEDSBindingSource;
        private HYDROPONICS_TESTDataSet1TableAdapters.SEEDSTableAdapter sEEDSTableAdapter;
    }
}