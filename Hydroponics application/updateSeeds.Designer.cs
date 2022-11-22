namespace Hydroponics_application
{
    partial class updateSeeds
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
            this.label1 = new System.Windows.Forms.Label();
            this.seedNameTextbox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timesPlantedTextbox = new System.Windows.Forms.TextBox();
            this.timesSproutedTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed Name:";
            // 
            // seedNameTextbox
            // 
            this.seedNameTextbox.Location = new System.Drawing.Point(158, 75);
            this.seedNameTextbox.Name = "seedNameTextbox";
            this.seedNameTextbox.Size = new System.Drawing.Size(153, 20);
            this.seedNameTextbox.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(158, 193);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Times Planted:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Times Sprouted:";
            // 
            // timesPlantedTextbox
            // 
            this.timesPlantedTextbox.Location = new System.Drawing.Point(158, 106);
            this.timesPlantedTextbox.Name = "timesPlantedTextbox";
            this.timesPlantedTextbox.Size = new System.Drawing.Size(153, 20);
            this.timesPlantedTextbox.TabIndex = 11;
            // 
            // timesSproutedTextbox
            // 
            this.timesSproutedTextbox.Location = new System.Drawing.Point(158, 136);
            this.timesSproutedTextbox.Name = "timesSproutedTextbox";
            this.timesSproutedTextbox.Size = new System.Drawing.Size(153, 20);
            this.timesSproutedTextbox.TabIndex = 12;
            // 
            // updateSeeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 259);
            this.Controls.Add(this.timesSproutedTextbox);
            this.Controls.Add(this.timesPlantedTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seedNameTextbox);
            this.Name = "updateSeeds";
            this.Text = "updateSeeds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seedNameTextbox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timesPlantedTextbox;
        private System.Windows.Forms.TextBox timesSproutedTextbox;
    }
}