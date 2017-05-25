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
    public partial class Modify_Seats : Form
    {

        List<Student> students;
        SqlConnection connection = new SqlConnection("server=GMRMLTV;database=EdanStudenDB;user=sa;password=GreatMinds110");
        public Modify_Seats()
        {
            InitializeComponent();

            students = new List<Student>();

            SqlCommand TakeEverything = new SqlCommand();
            connection.Open();
            TakeEverything.Connection = connection;
            TakeEverything.CommandType = CommandType.StoredProcedure;
            TakeEverything.CommandText = "dbo.usp_TakeEverything";
            //command should be 
            DataTable classTable = new DataTable();
            SqlDataAdapter ClassAdapter = new SqlDataAdapter(TakeEverything);
            ClassAdapter.Fill(classTable);

            //TODO 4/21/17: fix problem. add selecting weebly thing

            for (int i = 0; i < classTable.Rows.Count; i++)
            {
                object seatRow = classTable.Rows[i]["SeatNumber"];
                int seatNumber = 0;
                if (seatRow is int)
                {
                    seatNumber = (int)seatRow;
                }
                object ClassRow = classTable.Rows[i]["ClassID"];
                int ClassID = 0;
                if (ClassRow is int)
                {
                    ClassID = (int)ClassRow;
                }

                students.Add(new Student((int)classTable.Rows[i]["StudentID"], (string)classTable.Rows[i]["FirstName"], (string)classTable.Rows[i]["LastName"], seatNumber, ClassID));// (int)classTable.Rows[i]["ClassID"]));
            }

            listBox1.Items.AddRange(students.ToArray());

            //create student class (override ToString)
            //get table of: Select * FROM Students
            //populate a list of students from the SELECT table that sql returns


            //listBox1.Items.Add(new Derp($"name{i}"));


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student stud = (Student)listBox1.SelectedItem;
            StudentID.Text = $"Student ID: {stud.studentID}";
            FirstName.Text = $"First Name: {stud.firstName}";
            LastName.Text = $"Last Name: {stud.lastName}";
            SeatNumber.Text = $"Student ID: {stud.seatNumber}";
            ClassID.Text = $"Class ID: {stud.classID}";
            if(stud.classID == 0)
            {
                ClassID.Text = "Class ID: No class :)";
            }
            //listBox1.SelectedIndex;
        }

        private void Modify_Seats_Load(object sender, EventArgs e)
        {

        }
    }
}
