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
    class Student
    {
        public int studentID;
        public string firstName;
        public string lastName;
        public int seatNumber;
        public int classID;

        public Student(int studentID, string firstName, string lastName, int seatNumber, int classID)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.seatNumber = seatNumber;
            this.classID = classID;
        }


        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }

        
    }
}
