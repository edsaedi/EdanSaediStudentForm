namespace EdanSaediStudentForm
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addEditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEditButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(679, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addEditButton
            // 
            this.addEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addEditButton.Image = ((System.Drawing.Image)(resources.GetObject("addEditButton.Image")));
            this.addEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(23, 22);
            this.addEditButton.Text = "Add/Edit";
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 544);
            this.Controls.Add(this.toolStrip);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditFornm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditForm_MouseMove);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addEditButton;
    }
}