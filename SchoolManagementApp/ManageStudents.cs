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
    public partial class ManageStudents : Form
    {
        private readonly SchoolManagementEntities _db;
        public ManageStudents()
        {
            InitializeComponent();
            _db = new SchoolManagementEntities();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addStudent = new AddEditStudent
            {
                MdiParent = this.MdiParent
            };
            addStudent.Show();  

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvStudentsList.SelectedRows[0].Cells["Id"].Value;
                var student = _db.Students.FirstOrDefault(q => q.id == id);
                var addEditStudent = new AddEditStudent(student);

                addEditStudent.MdiParent = this.MdiParent;
                addEditStudent.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show($"خطا يرجى تحديد الطالب للتعديل");
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvStudentsList.SelectedRows[0].Cells["Id"].Value;
                var student = _db.Students.FirstOrDefault(q => q.id == id);

                _db.Students.Remove(student);
                _db.SaveChanges();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا {ex.Message}");
            }
        }

        private void ManageStudents_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            var students = _db.Students
                .Select(q => new
                {
                    FirstName = q.studentFirstName,
                    LastName = q.studentLastName,
                    DateOfBirth = q.dateOfBirth,
                    LastYearAverage = q.lastYearAverage,
                    StudentLevel = q.Level.SchoolLevel,
                    Id = q.id
                })
                .ToList();

            gvStudentsList.DataSource = students;
            gvStudentsList.Columns[5].Visible = false;
            gvStudentsList.Columns[0].HeaderText = "الاسم";
            gvStudentsList.Columns[1].HeaderText = "اللقب"; 
            gvStudentsList.Columns[2].HeaderText = "تاريخ الولادة";
            gvStudentsList.Columns[3].HeaderText = "معدل السنة الفارطة";
            gvStudentsList.Columns[4].HeaderText = "القسم";
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
