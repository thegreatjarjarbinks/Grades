namespace Grades
{
    partial class frmGrades
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnGetPercentage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 13);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(150, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter your grade number here:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(13, 117);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(99, 13);
            this.lblPercentage.TabIndex = 1;
            this.lblPercentage.Text = "Your percentage is:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(16, 45);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // btnGetPercentage
            // 
            this.btnGetPercentage.Location = new System.Drawing.Point(16, 213);
            this.btnGetPercentage.Name = "btnGetPercentage";
            this.btnGetPercentage.Size = new System.Drawing.Size(96, 26);
            this.btnGetPercentage.TabIndex = 3;
            this.btnGetPercentage.Text = "Get Percentage";
            this.btnGetPercentage.UseVisualStyleBackColor = true;
            this.btnGetPercentage.Click += new System.EventHandler(this.btnGetPercentage_Click);
            // 
            // frmGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGetPercentage);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmGrades";
            this.Text = "Grade Percentages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnGetPercentage;
    }
}

