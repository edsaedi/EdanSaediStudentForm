namespace EdanSaediStudentForm
{
    partial class AddForm
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
            this.ClassName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(18, 24);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(146, 20);
            this.ClassName.TabIndex = 0;
            this.ClassName.Text = "Enter the class name here";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.White;
            this.Submit.Font = new System.Drawing.Font("Segoe Keycaps", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(18, 59);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(146, 26);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 100);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "Add Form";
            this.Load += new System.EventHandler(this.Add_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button Submit;
    }
}