namespace EdanSaediStudentForm
{
    partial class ClassroomCreator
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
            this.classroomsListBox = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classroomsListBox
            // 
            this.classroomsListBox.FormattingEnabled = true;
            this.classroomsListBox.Location = new System.Drawing.Point(37, 24);
            this.classroomsListBox.Name = "classroomsListBox";
            this.classroomsListBox.Size = new System.Drawing.Size(158, 485);
            this.classroomsListBox.TabIndex = 15;
            this.classroomsListBox.SelectedIndexChanged += new System.EventHandler(this.classroomsListBox_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Segoe Keycaps", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(270, 57);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(326, 94);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Segoe Keycaps", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(270, 210);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(326, 94);
            this.Edit.TabIndex = 17;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Segoe Keycaps", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(270, 369);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(326, 94);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ClassroomCreator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 544);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.classroomsListBox);
            this.Name = "ClassroomCreator";
            this.Text = "ClassroomCreator";
            this.Load += new System.EventHandler(this.ClassroomCreator_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox classroomsListBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
    }
}