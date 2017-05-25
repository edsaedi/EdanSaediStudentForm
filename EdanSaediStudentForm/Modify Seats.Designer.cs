namespace EdanSaediStudentForm
{
    partial class Modify_Seats
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
            this.Exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.StudentID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.SeatNumber = new System.Windows.Forms.Label();
            this.ClassID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::EdanSaediStudentForm.Properties.Resources.arrows;
            this.Exit.Location = new System.Drawing.Point(46, 598);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(677, 38);
            this.Exit.TabIndex = 29;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(623, 381);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(43, 490);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(61, 13);
            this.StudentID.TabIndex = 31;
            this.StudentID.Text = "Student ID:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(173, 490);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 32;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(304, 490);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 33;
            this.LastName.Text = "Last Name:";
            // 
            // SeatNumber
            // 
            this.SeatNumber.AutoSize = true;
            this.SeatNumber.Location = new System.Drawing.Point(431, 490);
            this.SeatNumber.Name = "SeatNumber";
            this.SeatNumber.Size = new System.Drawing.Size(72, 13);
            this.SeatNumber.TabIndex = 34;
            this.SeatNumber.Text = "Seat Number:";
            // 
            // ClassID
            // 
            this.ClassID.AutoSize = true;
            this.ClassID.Location = new System.Drawing.Point(571, 490);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(49, 13);
            this.ClassID.TabIndex = 35;
            this.ClassID.Text = "Class ID:";
            // 
            // Modify_Seats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 648);
            this.Controls.Add(this.ClassID);
            this.Controls.Add(this.SeatNumber);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modify_Seats";
            this.Text = "Modify_Seats";
            this.Load += new System.EventHandler(this.Modify_Seats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label SeatNumber;
        private System.Windows.Forms.Label ClassID;
    }
}