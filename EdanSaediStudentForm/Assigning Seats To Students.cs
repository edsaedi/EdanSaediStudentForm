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
    public partial class Assigning_Seats_To_Students : Form
    {
        Dictionary<Button, bool> buttonPressed;
        List<Button> seats;
        Button clickedButton;
        int value = 0;

        public Assigning_Seats_To_Students(List<Button> seats)
        {
            InitializeComponent();
            this.seats = seats;
        }

        /// TODO: 5/3/17: Next time make labels pop up underneath the buttons. Make the login in SQL work.
        private void Assigning_Seats_To_Students_Load(object sender, EventArgs e)
        {
            buttonPressed = new Dictionary<Button, bool>();

            for(int i = 0; i < seats.Count; i++)
            {                
                Button newStudent = new Button();
                newStudent.Name = seats[i].Name;
                newStudent.Text = seats[i].Text;
                newStudent.Location = seats[i].Location;
                newStudent.ForeColor = Color.Purple;
                newStudent.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
                newStudent.Size = new Size(162, 83);
                newStudent.Image = Properties.Resources.desk;                
                if (i != 0)
                {
                    newStudent.Visible = false;
                }

                newStudent.Click += Seat_Click;

                buttonPressed.Add(newStudent, false);

                Controls.Add(newStudent);

                while(seats.Count - value > 0 )
                {
                    value++;
                }

            }
        }
        int counter = 0;
        
        private void Seat_Click(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;
            for (int i = 0; i < seats.Count; i++)
            {
                if (seats[i] != clickedButton)
                {
                    seats[i].Enabled = false;
                }
            }
            First_NameTextBox.Visible = true;
            Last_NameTextBox.Visible = true;
            submit_.Visible = true;
            //Next_.Visible = false;

            if (counter < buttonPressed.Count - 1 && !buttonPressed[clickedButton])
            {
                int buttonIndex = Controls.IndexOf(clickedButton);
                buttonPressed[clickedButton] = true;
                Controls[buttonIndex + 1].Visible = true;
                counter++;
            }
            else if (counter >= buttonPressed.Count)
            {
                Next_.Visible = true;
            }
        }

        private void submit__Click(object sender, EventArgs e)
        {
            First_NameTextBox.Visible = false;
            Last_NameTextBox.Visible = false;
            submit_.Visible = false;
            Next_.Visible = true;
            clickedButton.Enabled = false;
        }

        private void Next__Click(object sender, EventArgs e)
        {
            Modify_Seats form = new Modify_Seats();
            form.ShowDialog();
        }
    }
}
