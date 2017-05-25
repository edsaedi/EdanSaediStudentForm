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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            ClassroomCreator form = new ClassroomCreator();
            form.ShowDialog();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
