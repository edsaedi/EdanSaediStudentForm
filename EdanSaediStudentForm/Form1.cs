using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdanSaediStudentForm
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("server=GMRMLTV;database=EdanStudenDB;user=sa;password=GreatMinds110");
        SqlCommand command = new SqlCommand();
        object studentID;
        object classID;

        List<Button> seats;
        //Create a dictionary

        public Form1(List<Button> seats)
        {
            InitializeComponent();
            this.seats = seats;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < seats.Count; i++)
            {
                Button newStudent = new Button();
                newStudent.Name = seats[i].Name;
                newStudent.Text = seats[i].Text;
                newStudent.Location = seats[i].Location;
                newStudent.ForeColor = Color.Purple;
                newStudent.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
                newStudent.Size = new Size(162, 83);
                newStudent.Image = Properties.Resources.desk;
                Controls.Add(newStudent);
            }
        }
        //4/12/17
        //Todo:Apply Sql && NextButton

        public void Disable(Button notpressed)
        {
            seat1.Enabled = false;
            notpressed.Enabled = true;
            for (int i = 0; i < seats.Count; i++)
            {
                seats[i].Enabled = false;
            }

        }

        public void Reset()
        {
            seat1.Enabled = true;
            for(int i = 0; i < seats.Count; i++)
            {
                seats[i].Enabled = false;
            }
        }

        int lastPressed = 0;

        private void seat1_Click(object sender, EventArgs e)
        {
            Next.Visible = false;
            seat1.Enabled = false;
            FirstNameTextBox.Visible = true;
            LastNameTextBox.Visible = true;
            FirstNameTextBox.Text = "FirstName";
            LastNameTextBox.Text = "LastName";
            submit.Visible = true;
            lastPressed = 1;
            Disable(seat1);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.Open();
            command.CommandText = "dbo.usp_CreateStudent";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstNameTextBox.Text;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastNameTextBox.Text;
            command.Parameters.Add("@SeatNumber", SqlDbType.Int).Value = lastPressed;
            //studentID = command.ExecuteScalar();

            DataTable resultTable = new DataTable();
            SqlDataAdapter Studentadapter = new SqlDataAdapter(command);
            Studentadapter.Fill(resultTable);
            connection.Close();

            string className = ClassName.Text;
            ClassName.Enabled = false;
            SqlCommand createclass = new SqlCommand();
            connection.Open();
            createclass.Connection = connection;
            createclass.CommandType = CommandType.StoredProcedure;
            createclass.CommandText = "dbo.usp_CreateClasss";
            createclass.Parameters.Add("@ClassName", SqlDbType.VarChar).Value = className;

            DataTable classTable = new DataTable();
            SqlDataAdapter Classadapter = new SqlDataAdapter(createclass);
            Classadapter.Fill(classTable);
            classID = classTable.Rows[0]["CLassID"];

            //classID = (DataTable)createclass.ExecuteScalar();



            connection.Close();

            submit.Visible = false;
            FirstNameTextBox.Visible = false;
            LastNameTextBox.Visible = false;


            //if (lastPressed == 1)
            //{
            //    label1.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat1.Visible = false;
            //    Next.Visible = true;

            //}
            //else if (lastPressed == 2)
            //{
            //    label2.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat2.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 3)
            //{
            //    label3.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat3.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 4)
            //{
            //    label4.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat4.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 5)
            //{
            //    label5.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat5.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 6)
            //{
            //    label6.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat6.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 7)
            //{
            //    label7.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat7.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 8)
            //{
            //    label8.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat8.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 9)
            //{
            //    label9.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat9.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 10)
            //{
            //    label10.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat10.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 11)
            //{
            //    label11.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat11.Visible = false;
            //    Next.Visible = true;
            //}
            //else if (lastPressed == 12)
            //{
            //    label12.Text = $"{FirstNameTextBox.Text}\n{LastNameTextBox.Text}:{lastPressed}";
            //    seat12.Visible = false;
            //    Next.Visible = true;
            //}
            ///if (seat1.Visible == false && seat2.Visible == false && seat3.Visible == false && seat4.Visible == false && seat5.Visible == false && seat6.Visible == false && seat7.Visible == false && seat8.Visible == false && seat9.Visible == false && seat10.Visible == false && seat11.Visible == false && seat12.Visible == false)
            ///{
            ///    Next.Visible = true;
            ///}
            Reset();

            ///4/19/17
            ///TODO: Continue Modify Seats in SQl for stored proc and in the form. Even though I am writing this in the form, focus mainly on SQL 

        }

       

        private void Next_Click(object sender, EventArgs e)
        {
            Next.Enabled = false;
            Next.Visible = false;
            SqlCommand AssignStudentToClass = new SqlCommand();
            connection.Open();
            AssignStudentToClass.Connection = connection;
            AssignStudentToClass.CommandType = CommandType.StoredProcedure;
            AssignStudentToClass.CommandText = "dbo.usp_AssignStudnetToClass";
            AssignStudentToClass.Parameters.Add("@SeatNumber", SqlDbType.Int).Value = lastPressed;
            AssignStudentToClass.Parameters.Add("@ClassID", SqlDbType.Int).Value = classID;
            AssignStudentToClass.Parameters.Add("@StudentID", SqlDbType.Int).Value = studentID;
            //4/14/17 TODO: assign students to class


            Modify_Seats form = new Modify_Seats();
            this.Hide();
            form.ShowDialog();

            //re-show this form
            this.Show();
            //reset if needed



        }
    }
}
