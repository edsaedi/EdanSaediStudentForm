namespace EdanSaediStudentForm
{
    partial class LoginPage
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
            this.Title = new System.Windows.Forms.Label();
            this.UsernameL = new System.Windows.Forms.Label();
            this.PasswordL = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(128, 67);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(441, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "Login to access your students";
            // 
            // UsernameL
            // 
            this.UsernameL.AutoSize = true;
            this.UsernameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameL.Location = new System.Drawing.Point(280, 142);
            this.UsernameL.Name = "UsernameL";
            this.UsernameL.Size = new System.Drawing.Size(158, 33);
            this.UsernameL.TabIndex = 1;
            this.UsernameL.Text = "Username:";
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(287, 295);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(151, 33);
            this.PasswordL.TabIndex = 2;
            this.PasswordL.Text = "Password:";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.DarkRed;
            this.Login.Image = global::EdanSaediStudentForm.Properties.Resources.arrows;
            this.Login.Location = new System.Drawing.Point(135, 481);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(465, 40);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(170, 237);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(383, 20);
            this.Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(171, 390);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '☻';
            this.Password.Size = new System.Drawing.Size(383, 20);
            this.Password.TabIndex = 5;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 544);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordL);
            this.Controls.Add(this.UsernameL);
            this.Controls.Add(this.Title);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label UsernameL;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
    }
}