namespace Hydroponics_application
{
    partial class MainForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.sowDateButton = new System.Windows.Forms.Button();
            this.transferDateButton = new System.Windows.Forms.Button();
            this.sowDateLabel = new System.Windows.Forms.Label();
            this.sowDateLbl = new System.Windows.Forms.Label();
            this.waterWithNoSolutionLabel = new System.Windows.Forms.Label();
            this.waterWithNoSolutionLbl = new System.Windows.Forms.Label();
            this.HalfStrengthLabel = new System.Windows.Forms.Label();
            this.HalfStrength = new System.Windows.Forms.Label();
            this.FullStrengthLabel = new System.Windows.Forms.Label();
            this.FullStrength = new System.Windows.Forms.Label();
            this.transferDateLabel = new System.Windows.Forms.Label();
            this.harvestDateLabel = new System.Windows.Forms.Label();
            this.transferDate = new System.Windows.Forms.Label();
            this.harvestDate = new System.Windows.Forms.Label();
            this.nextPlantDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPlantButton = new System.Windows.Forms.Button();
            this.viewPlantsButton = new System.Windows.Forms.Button();
            this.addSeedsButton = new System.Windows.Forms.Button();
            this.viewSeedsButton = new System.Windows.Forms.Button();
            this.addStatsButton = new System.Windows.Forms.Button();
            this.viewStatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(113, 42);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(62, 48);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date: ";
            // 
            // sowDateButton
            // 
            this.sowDateButton.Location = new System.Drawing.Point(27, 82);
            this.sowDateButton.Name = "sowDateButton";
            this.sowDateButton.Size = new System.Drawing.Size(108, 23);
            this.sowDateButton.TabIndex = 2;
            this.sowDateButton.Text = "Sow Date";
            this.sowDateButton.UseVisualStyleBackColor = true;
            this.sowDateButton.Click += new System.EventHandler(this.sowDateButton_Click);
            // 
            // transferDateButton
            // 
            this.transferDateButton.Location = new System.Drawing.Point(141, 82);
            this.transferDateButton.Name = "transferDateButton";
            this.transferDateButton.Size = new System.Drawing.Size(108, 23);
            this.transferDateButton.TabIndex = 3;
            this.transferDateButton.Text = "Transfer Date";
            this.transferDateButton.UseVisualStyleBackColor = true;
            // 
            // sowDateLabel
            // 
            this.sowDateLabel.AutoSize = true;
            this.sowDateLabel.Location = new System.Drawing.Point(78, 131);
            this.sowDateLabel.Name = "sowDateLabel";
            this.sowDateLabel.Size = new System.Drawing.Size(57, 13);
            this.sowDateLabel.TabIndex = 4;
            this.sowDateLabel.Text = "Sow Date:";
            // 
            // sowDateLbl
            // 
            this.sowDateLbl.AutoSize = true;
            this.sowDateLbl.Location = new System.Drawing.Point(154, 131);
            this.sowDateLbl.Name = "sowDateLbl";
            this.sowDateLbl.Size = new System.Drawing.Size(0, 13);
            this.sowDateLbl.TabIndex = 5;
            // 
            // waterWithNoSolutionLabel
            // 
            this.waterWithNoSolutionLabel.AutoSize = true;
            this.waterWithNoSolutionLabel.Location = new System.Drawing.Point(16, 158);
            this.waterWithNoSolutionLabel.Name = "waterWithNoSolutionLabel";
            this.waterWithNoSolutionLabel.Size = new System.Drawing.Size(119, 13);
            this.waterWithNoSolutionLabel.TabIndex = 6;
            this.waterWithNoSolutionLabel.Text = "Water with No Solution:";
            // 
            // waterWithNoSolutionLbl
            // 
            this.waterWithNoSolutionLbl.AutoSize = true;
            this.waterWithNoSolutionLbl.Location = new System.Drawing.Point(154, 158);
            this.waterWithNoSolutionLbl.Name = "waterWithNoSolutionLbl";
            this.waterWithNoSolutionLbl.Size = new System.Drawing.Size(0, 13);
            this.waterWithNoSolutionLbl.TabIndex = 7;
            // 
            // HalfStrengthLabel
            // 
            this.HalfStrengthLabel.AutoSize = true;
            this.HalfStrengthLabel.Location = new System.Drawing.Point(10, 182);
            this.HalfStrengthLabel.Name = "HalfStrengthLabel";
            this.HalfStrengthLabel.Size = new System.Drawing.Size(125, 13);
            this.HalfStrengthLabel.TabIndex = 8;
            this.HalfStrengthLabel.Text = "Water with 50% Solution:";
            // 
            // HalfStrength
            // 
            this.HalfStrength.AutoSize = true;
            this.HalfStrength.Location = new System.Drawing.Point(154, 182);
            this.HalfStrength.Name = "HalfStrength";
            this.HalfStrength.Size = new System.Drawing.Size(0, 13);
            this.HalfStrength.TabIndex = 9;
            // 
            // FullStrengthLabel
            // 
            this.FullStrengthLabel.AutoSize = true;
            this.FullStrengthLabel.Location = new System.Drawing.Point(4, 212);
            this.FullStrengthLabel.Name = "FullStrengthLabel";
            this.FullStrengthLabel.Size = new System.Drawing.Size(131, 13);
            this.FullStrengthLabel.TabIndex = 10;
            this.FullStrengthLabel.Text = "Water with 100% Solution:";
            // 
            // FullStrength
            // 
            this.FullStrength.AutoSize = true;
            this.FullStrength.Location = new System.Drawing.Point(154, 212);
            this.FullStrength.Name = "FullStrength";
            this.FullStrength.Size = new System.Drawing.Size(0, 13);
            this.FullStrength.TabIndex = 11;
            // 
            // transferDateLabel
            // 
            this.transferDateLabel.AutoSize = true;
            this.transferDateLabel.Location = new System.Drawing.Point(60, 239);
            this.transferDateLabel.Name = "transferDateLabel";
            this.transferDateLabel.Size = new System.Drawing.Size(75, 13);
            this.transferDateLabel.TabIndex = 12;
            this.transferDateLabel.Text = "Transfer Date:";
            // 
            // harvestDateLabel
            // 
            this.harvestDateLabel.AutoSize = true;
            this.harvestDateLabel.Location = new System.Drawing.Point(62, 268);
            this.harvestDateLabel.Name = "harvestDateLabel";
            this.harvestDateLabel.Size = new System.Drawing.Size(73, 13);
            this.harvestDateLabel.TabIndex = 13;
            this.harvestDateLabel.Text = "Harvest Date:";
            // 
            // transferDate
            // 
            this.transferDate.AutoSize = true;
            this.transferDate.Location = new System.Drawing.Point(157, 239);
            this.transferDate.Name = "transferDate";
            this.transferDate.Size = new System.Drawing.Size(0, 13);
            this.transferDate.TabIndex = 14;
            // 
            // harvestDate
            // 
            this.harvestDate.AutoSize = true;
            this.harvestDate.Location = new System.Drawing.Point(157, 268);
            this.harvestDate.Name = "harvestDate";
            this.harvestDate.Size = new System.Drawing.Size(0, 13);
            this.harvestDate.TabIndex = 15;
            // 
            // nextPlantDateLabel
            // 
            this.nextPlantDateLabel.AutoSize = true;
            this.nextPlantDateLabel.Location = new System.Drawing.Point(76, 294);
            this.nextPlantDateLabel.Name = "nextPlantDateLabel";
            this.nextPlantDateLabel.Size = new System.Drawing.Size(59, 13);
            this.nextPlantDateLabel.TabIndex = 16;
            this.nextPlantDateLabel.Text = "Next Plant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // addPlantButton
            // 
            this.addPlantButton.Location = new System.Drawing.Point(34, 323);
            this.addPlantButton.Name = "addPlantButton";
            this.addPlantButton.Size = new System.Drawing.Size(101, 23);
            this.addPlantButton.TabIndex = 18;
            this.addPlantButton.Text = "Add Plant";
            this.addPlantButton.UseVisualStyleBackColor = true;
            // 
            // viewPlantsButton
            // 
            this.viewPlantsButton.Location = new System.Drawing.Point(148, 323);
            this.viewPlantsButton.Name = "viewPlantsButton";
            this.viewPlantsButton.Size = new System.Drawing.Size(101, 23);
            this.viewPlantsButton.TabIndex = 19;
            this.viewPlantsButton.Text = "View Plants";
            this.viewPlantsButton.UseVisualStyleBackColor = true;
            // 
            // addSeedsButton
            // 
            this.addSeedsButton.Location = new System.Drawing.Point(34, 365);
            this.addSeedsButton.Name = "addSeedsButton";
            this.addSeedsButton.Size = new System.Drawing.Size(101, 23);
            this.addSeedsButton.TabIndex = 20;
            this.addSeedsButton.Text = "Add Seed";
            this.addSeedsButton.UseVisualStyleBackColor = true;
            this.addSeedsButton.Click += new System.EventHandler(this.addSeedsButton_Click);
            // 
            // viewSeedsButton
            // 
            this.viewSeedsButton.Location = new System.Drawing.Point(148, 365);
            this.viewSeedsButton.Name = "viewSeedsButton";
            this.viewSeedsButton.Size = new System.Drawing.Size(101, 23);
            this.viewSeedsButton.TabIndex = 21;
            this.viewSeedsButton.Text = "View Seeds";
            this.viewSeedsButton.UseVisualStyleBackColor = true;
            // 
            // addStatsButton
            // 
            this.addStatsButton.Location = new System.Drawing.Point(34, 405);
            this.addStatsButton.Name = "addStatsButton";
            this.addStatsButton.Size = new System.Drawing.Size(101, 23);
            this.addStatsButton.TabIndex = 22;
            this.addStatsButton.Text = "Add/Modify Stats";
            this.addStatsButton.UseVisualStyleBackColor = true;
            // 
            // viewStatsButton
            // 
            this.viewStatsButton.Location = new System.Drawing.Point(148, 405);
            this.viewStatsButton.Name = "viewStatsButton";
            this.viewStatsButton.Size = new System.Drawing.Size(101, 23);
            this.viewStatsButton.TabIndex = 23;
            this.viewStatsButton.Text = "View Stats";
            this.viewStatsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 450);
            this.Controls.Add(this.viewStatsButton);
            this.Controls.Add(this.addStatsButton);
            this.Controls.Add(this.viewSeedsButton);
            this.Controls.Add(this.addSeedsButton);
            this.Controls.Add(this.viewPlantsButton);
            this.Controls.Add(this.addPlantButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextPlantDateLabel);
            this.Controls.Add(this.harvestDate);
            this.Controls.Add(this.transferDate);
            this.Controls.Add(this.harvestDateLabel);
            this.Controls.Add(this.transferDateLabel);
            this.Controls.Add(this.FullStrength);
            this.Controls.Add(this.FullStrengthLabel);
            this.Controls.Add(this.HalfStrength);
            this.Controls.Add(this.HalfStrengthLabel);
            this.Controls.Add(this.waterWithNoSolutionLbl);
            this.Controls.Add(this.waterWithNoSolutionLabel);
            this.Controls.Add(this.sowDateLbl);
            this.Controls.Add(this.sowDateLabel);
            this.Controls.Add(this.transferDateButton);
            this.Controls.Add(this.sowDateButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "MainForm";
            this.Text = "Hydroponics Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button sowDateButton;
        private System.Windows.Forms.Button transferDateButton;
        private System.Windows.Forms.Label sowDateLabel;
        private System.Windows.Forms.Label sowDateLbl;
        private System.Windows.Forms.Label waterWithNoSolutionLabel;
        private System.Windows.Forms.Label waterWithNoSolutionLbl;
        private System.Windows.Forms.Label HalfStrengthLabel;
        private System.Windows.Forms.Label HalfStrength;
        private System.Windows.Forms.Label FullStrengthLabel;
        private System.Windows.Forms.Label FullStrength;
        private System.Windows.Forms.Label transferDateLabel;
        private System.Windows.Forms.Label harvestDateLabel;
        private System.Windows.Forms.Label transferDate;
        private System.Windows.Forms.Label harvestDate;
        private System.Windows.Forms.Label nextPlantDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPlantButton;
        private System.Windows.Forms.Button viewPlantsButton;
        private System.Windows.Forms.Button addSeedsButton;
        private System.Windows.Forms.Button viewSeedsButton;
        private System.Windows.Forms.Button addStatsButton;
        private System.Windows.Forms.Button viewStatsButton;
    }
}