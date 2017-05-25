namespace EdanSaediStudentForm
{
    partial class Assigning_Seats_To_Students
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
            this.Class_Name = new System.Windows.Forms.TextBox();
            this.Next_ = new System.Windows.Forms.Button();
            this.submit_ = new System.Windows.Forms.Button();
            this.Last_NameTextBox = new System.Windows.Forms.TextBox();
            this.First_NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Class_Name
            // 
            this.Class_Name.Location = new System.Drawing.Point(52, 22);
            this.Class_Name.Name = "Class_Name";
            this.Class_Name.Size = new System.Drawing.Size(669, 20);
            this.Class_Name.TabIndex = 30;
            this.Class_Name.Text = "Class Name Goes Here";
            // 
            // Next_
            // 
            this.Next_.BackgroundImage = global::EdanSaediStudentForm.Properties.Resources.arrows;
            this.Next_.Location = new System.Drawing.Point(45, 598);
            this.Next_.Name = "Next_";
            this.Next_.Size = new System.Drawing.Size(677, 38);
            this.Next_.TabIndex = 34;
            this.Next_.Text = "Next";
            this.Next_.UseVisualStyleBackColor = true;
            this.Next_.Visible = false;
            this.Next_.Click += new System.EventHandler(this.Next__Click);
            // 
            // submit_
            // 
            this.submit_.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit_.Location = new System.Drawing.Point(45, 598);
            this.submit_.Name = "submit_";
            this.submit_.Size = new System.Drawing.Size(677, 38);
            this.submit_.TabIndex = 33;
            this.submit_.Text = "submit\r\n";
            this.submit_.UseVisualStyleBackColor = false;
            this.submit_.Visible = false;
            this.submit_.Click += new System.EventHandler(this.submit__Click);
            // 
            // Last_NameTextBox
            // 
            this.Last_NameTextBox.Location = new System.Drawing.Point(422, 563);
            this.Last_NameTextBox.Name = "Last_NameTextBox";
            this.Last_NameTextBox.Size = new System.Drawing.Size(300, 20);
            this.Last_NameTextBox.TabIndex = 32;
            this.Last_NameTextBox.Text = "LastName";
            this.Last_NameTextBox.Visible = false;
            // 
            // First_NameTextBox
            // 
            this.First_NameTextBox.Location = new System.Drawing.Point(49, 563);
            this.First_NameTextBox.Name = "First_NameTextBox";
            this.First_NameTextBox.Size = new System.Drawing.Size(346, 20);
            this.First_NameTextBox.TabIndex = 31;
            this.First_NameTextBox.Text = "FirstName";
            this.First_NameTextBox.Visible = false;
            // 
            // Assigning_Seats_To_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 648);
            this.Controls.Add(this.Next_);
            this.Controls.Add(this.submit_);
            this.Controls.Add(this.Last_NameTextBox);
            this.Controls.Add(this.First_NameTextBox);
            this.Controls.Add(this.Class_Name);
            this.MinimizeBox = false;
            this.Name = "Assigning_Seats_To_Students";
            this.Text = "Assigning_Seats_To_Students";
            this.Load += new System.EventHandler(this.Assigning_Seats_To_Students_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Class_Name;
        private System.Windows.Forms.Button Next_;
        private System.Windows.Forms.Button submit_;
        private System.Windows.Forms.TextBox Last_NameTextBox;
        private System.Windows.Forms.TextBox First_NameTextBox;
    }
}