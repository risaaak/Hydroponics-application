namespace Hydroponics_application
{
    partial class Add_Seedlings
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
            this.backbtn = new System.Windows.Forms.Button();
            this.addseedbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seednametxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(13, 13);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(47, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addseedbtn
            // 
            this.addseedbtn.Location = new System.Drawing.Point(79, 92);
            this.addseedbtn.Name = "addseedbtn";
            this.addseedbtn.Size = new System.Drawing.Size(75, 23);
            this.addseedbtn.TabIndex = 1;
            this.addseedbtn.Text = "ADD";
            this.addseedbtn.UseVisualStyleBackColor = true;
            this.addseedbtn.Click += new System.EventHandler(this.addseedbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seed Name:";
            // 
            // seednametxtbox
            // 
            this.seednametxtbox.Location = new System.Drawing.Point(85, 55);
            this.seednametxtbox.Name = "seednametxtbox";
            this.seednametxtbox.Size = new System.Drawing.Size(135, 20);
            this.seednametxtbox.TabIndex = 3;
            // 
            // Add_Seedlings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 135);
            this.Controls.Add(this.seednametxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addseedbtn);
            this.Controls.Add(this.backbtn);
            this.Name = "Add_Seedlings";
            this.Text = "Add Seedlings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button addseedbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seednametxtbox;
    }
}