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

    public partial class ClassroomCreator : Form
    {

        public void AddtoClassroomListBox(SqlCommand sqlcommand, List<SQL_Class> classx, SqlConnection sqlconnection, ListBox lb, DataTable ct)
        {
            classx.Clear();
            lb.Items.Clear();
            ct.Clear();
            classx = new List<SQL_Class>();

            lb.Items.Clear();

            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlcommand.CommandText = "dbo.usp_ClassroomNames";
            sqlcommand.CommandType = CommandType.StoredProcedure;
            sqlcommand.Parameters.Clear();
            sqlconnection.Close();


            SqlDataAdapter ClassAdapter = new SqlDataAdapter(sqlcommand);
            ClassAdapter.Fill(ct);
            for (int i = 0; i < ct.Rows.Count; i++)
            {
                classx.Add(new SQL_Class((string)ct.Rows[i]["ClassName"]));
            }

            for (int i = 0; i < classx.Count; i++)
            {
                lb.Items.Add(classx[i].ClassName);
            }

        }
        #region 5/26/17 TODO:
        //Work on making the edit function in the form work. Make the button.
        #endregion
        #region 5/24/17 TODO:
        //Make the edit button work in the new form I created and (finish the edit function in sql) ()= uncertain if finished.
        #endregion
        #region  5/19/17 TODO:
        //Finish the ADD FUNCTION AND EDIT SQL
        #endregion
        #region  5/17/17 TODO:
        //Finish the ADD FUNCTION AND EDIT SQL
        #endregion
        #region 5/10//17 TOOO:
        //TODO: Apply the remove function that I created in sql. Make and use the edit and add function.
        #endregion
        bool deleteclicked = false;
        int ClassID = 0;
        SqlConnection connection = new SqlConnection("server=GMRMLTV;database=EdanStudenDB;user=sa;password=GreatMinds110");
        Point mouse = new Point(0, 0);
        Dictionary<Button, bool> buttonPressed = new Dictionary<Button, bool>();
        List<Button> buttons = new List<Button>();
        SqlCommand command = new SqlCommand();
        SqlCommand delete = new SqlCommand();
        SqlCommand deleteAllStudents = new SqlCommand();
        SqlCommand findClassID = new SqlCommand();
        List<SQL_Class> classes;
        DataTable classTable = new DataTable();

        public ClassroomCreator()
        {
            InitializeComponent();

            foreach (Component component in Controls)
            {
                Cursor cur = new Cursor(Properties.Resources.goldenKappa.Handle);
                Cursor = cur;
            }

            classes = new List<SQL_Class>();

            classroomsListBox.Items.Clear();

            command.Connection = connection;
            connection.Open();
            command.CommandText = "dbo.usp_ClassroomNames";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            connection.Close();


            SqlDataAdapter ClassAdapter = new SqlDataAdapter(command);
            ClassAdapter.Fill(classTable);
            for (int i = 0; i < classTable.Rows.Count; i++)
            {
                classes.Add(new SQL_Class((string)classTable.Rows[i]["ClassName"]));
            }

            for (int i = 0; i < classes.Count; i++)
            {
                classroomsListBox.Items.Add(classes[i].ClassName);
            }

        }
        private void ClassroomCreator_Load(object sender, EventArgs e)
        {
            //buttonPressed.Add(desk1, false);
            //buttons.Add(desk1);         
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string toDeleteName = classroomsListBox.GetItemText(classroomsListBox.SelectedItem);

            #region  5/12/17 TODO:
            //Finish the delete and finish reformating sql.
            #endregion

            findClassID.Connection = connection;
            connection.Open();
            findClassID.CommandText = "usp_FindClassID";
            findClassID.CommandType = CommandType.StoredProcedure;
            findClassID.Parameters.Clear();
            findClassID.Parameters.Add("@ClassName", SqlDbType.VarChar).Value = toDeleteName;
            ClassID = (int)findClassID.ExecuteScalar();
            connection.Close();

            deleteAllStudents.Connection = connection;
            connection.Open();
            deleteAllStudents.CommandText = "usp_DeleteAllStudents";
            deleteAllStudents.CommandType = CommandType.StoredProcedure;
            deleteAllStudents.Parameters.Clear();
            deleteAllStudents.Parameters.Add("@ClassID", SqlDbType.Int).Value = ClassID;
            deleteAllStudents.ExecuteScalar();
            connection.Close();

            delete.Connection = connection;
            connection.Open();
            delete.CommandText = "usp_RemoveClasss";
            delete.CommandType = CommandType.StoredProcedure;
            delete.Parameters.Clear();
            delete.Parameters.Add("@ClassName", SqlDbType.VarChar).Value = toDeleteName;
            delete.ExecuteScalar();
            connection.Close();


            for (int i = 0; i < classes.Count; i++)
            {
                if (classes[i].ClassName == toDeleteName)
                {
                    classroomsListBox.Items.RemoveAt(i);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.ShowDialog();

            AddtoClassroomListBox(command, classes, connection, classroomsListBox, classTable);
        }

        private void classroomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            Edit.Enabled = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            form.ShowDialog();
        }
    }
}


#region OldCode
//private void testseat_MouseDown(object sender, MouseEventArgs e)
//{
//    if (e.Button == MouseButtons.Left)
//    {
//        mouse = e.Location;
//    }
//}

//private void testseat_MouseMove(object sender, MouseEventArgs e)
//{
//    Button movingButton = (Button)sender;

//    if (e.Button == System.Windows.Forms.MouseButtons.Left)
//    {
//        movingButton.Left = e.X + movingButton.Left - mouse.X;
//        movingButton.Top = e.Y + movingButton.Top - mouse.Y;
//    }
//}

//private void ClassroomCreator_MouseMove(object sender, MouseEventArgs e)
//{
//    mouse = new Point(e.X, e.Y);
//    //Text = $"X: {mouse.X}, Y: {mouse.Y}";
//}

//bool canAddNewStudent = false;
//private void desk1_Click(object sender, EventArgs e)
//{
//    Button clickedButton = (Button)sender;

//    if (!buttonPressed[clickedButton])
//    {
//        canAddNewStudent = true;
//        buttonPressed[clickedButton] = true;    
//    }
//}

//int studentCounter = 1;
//private void desk1_MouseUp(object sender, MouseEventArgs e)
//{
//    Button movedButton = (Button)sender;

//    if (canAddNewStudent)
//    {
//        studentCounter++;

//        Button newStudent = new Button();
//        newStudent.Name = $"desk{studentCounter}";
//        newStudent.Text = $"Click Here To Add Student: Seat {studentCounter}";
//        newStudent.Location = new Point(12, 449);
//        newStudent.ForeColor = Color.Purple;
//        newStudent.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold);
//        newStudent.Size = new Size(162, 83);
//        newStudent.Image = Properties.Resources.desk;

//        newStudent.Click += desk1_Click;
//        newStudent.MouseDown += testseat_MouseDown;
//        newStudent.MouseMove += testseat_MouseMove;
//        newStudent.MouseUp += desk1_MouseUp;

//        buttonPressed.Add(newStudent, false);
//        buttons.Add(newStudent);
//        canAddNewStudent = false;

//        Controls.Add(newStudent);
//    }
//}

//private void MoveOnButton_Click(object sender, EventArgs e)
//{
//    Assigning_Seats_To_Students form = new Assigning_Seats_To_Students(buttons);
//    form.ShowDialog();
//}
#endregion