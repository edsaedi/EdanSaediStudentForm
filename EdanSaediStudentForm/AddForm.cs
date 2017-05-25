using EdanSaediStudentForm.Properties;
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
    public partial class AddForm : Form
    {
        string className;
        SqlCommand command = new SqlCommand();
        SqlConnection connection = new SqlConnection("server=GMRMLTV;database=EdanStudenDB;user=sa;password=GreatMinds110");
        public AddForm()
        {
            InitializeComponent();
        }

        private void Add_form_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            foreach (Component component in Controls)
            {
                Cursor cur = new Cursor(Properties.Resources.goldenKappa.Handle);
                Cursor = cur;
            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            className= ClassName.Text;
            command.Connection = connection;
            connection.Open();
            command.CommandText = "dbo.usp_CreateClasss";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Clear();
            command.Parameters.Add("@ClassName", SqlDbType.VarChar).Value = className;
            command.ExecuteScalar();
            connection.Close();
            Close();
        }
    }
}
