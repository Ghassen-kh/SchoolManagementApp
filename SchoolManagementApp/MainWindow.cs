using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public user _user;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login, user user)
        {
            InitializeComponent();
            _login = login;

            _user = user;
            _roleName = _user.UserRoles.FirstOrDefault().Role.shortName;
        }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addStudent = new AddEditStudent();

            // ShowDialog should be before setting the mdiParent 
            addStudent.ShowDialog();
            addStudent.MdiParent = this;
        }

        private void إدارةالفصولالدراسيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(q => q.Name == "ManageLevelListing");

            if (!isOpen)
            {
                var levelListing = new ManageLevelListing();
                levelListing.MdiParent = this;
                levelListing.Show();

            }
        }

        private void عرضقائمةالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageStudents = new ManageStudents();
            manageStudents.MdiParent = this;
            manageStudents.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(q => q.Name == "ManageUsers");
            if (!isOpen)
            {
                var manageUsers = new ManageUsers(); 
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_RoleName != "admin")
            {
                ادارةالمستخدمينToolStripMenuItem.Visible = false;

            }
        }
    }
}
