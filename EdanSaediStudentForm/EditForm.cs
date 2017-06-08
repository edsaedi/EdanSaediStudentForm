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
        Button newStudent;
        bool addEditMode = false;
        bool moveMode = false;
        Point mouse = new Point(0, 0);
        Dictionary<Button, bool> buttonPressed = new Dictionary<Button, bool>();
        List<Button> buttons = new List<Button>();
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
            if (addEditMode)
            {
                counter++;
                newStudent = new Button();
                newStudent.Name = $"desk{counter}";
                newStudent.Text = "Empty";
                newStudent.Location = new Point(mouse.X, mouse.Y);
                newStudent.Image = Properties.Resources.desk;
                newStudent.Click += new System.EventHandler(this.button_Click);
                newStudent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
                newStudent.MouseMove += new MouseEventHandler(this.newStudent_MouseMove);
                buttons.Add(newStudent);
                buttonPressed.Add(newStudent, false);
                Controls.Add(newStudent);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (!buttonPressed[clickedButton])
            {
                buttonPressed[clickedButton] = true;
            }
        }



        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveMode)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouse = e.Location;
                }
            }

            //check if movement mode has been selected
            //while it is down, have it track the mouse
            //stop moving on mouse up
        }


        private void EditForm_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = new Point(e.X, e.Y);

        }

        private void newStudent_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = new Point(e.X, e.Y);
            mouse.X += ((Button)sender).Location.X;
            mouse.Y += ((Button)sender).Location.Y;
            Text = $"X: {mouse.X}, Y: {mouse.Y}";

            Button movingButton = (Button)sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                movingButton.Left = e.X + movingButton.Left - mouse.X;
                movingButton.Top = e.Y + movingButton.Top - mouse.Y;
            }

        }

        private void newStudent_MouseUp(object sender, MouseEventArgs e)
        {
            Button movedButton = (Button)sender;
            buttonPressed.Add(newStudent, false);
            buttons.Add(newStudent);

            Controls.Add(newStudent);
        }


        private void MoveButton_Click(object sender, EventArgs e)
        {
            addEditMode = false;
            moveMode = true;
        }
    }
}
