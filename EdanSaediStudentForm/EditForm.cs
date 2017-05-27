using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdanSaediStudentForm
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        bool addEditMode = false;

        private void EditFornm_Load(object sender, EventArgs e)
        {

        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            addEditMode = true;
        }
        int counter = 0;
        private void EditForm_MouseClick(object sender, MouseEventArgs e)
        {
            if(addEditMode)
            {
                counter ++;
                Button newStudent = new Button();
                newStudent.Name = $"desk{counter}";
                newStudent.Text = "Empty";
                newStudent.Location = new Point(MousePosition.X, MousePosition.Y);
                newStudent.Image = Properties.Resources.desk;
            }
        }

        private void EditForm_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
