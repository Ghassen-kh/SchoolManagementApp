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
    public partial class AddEditStudent : Form
    {
        private bool isEditMode;
        private readonly SchoolManagementEntities _db = new SchoolManagementEntities();
        public AddEditStudent()
        {
            InitializeComponent();
            lblTitle.Text = "إضافة طالب";
            isEditMode = false;
            _db = new SchoolManagementEntities();
        }

        public AddEditStudent(Student studentToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "تعديل طالب";

            if (studentToEdit == null)
            {
                MessageBox.Show("يرجى التأكد من تحديد الطالب للتعديل");
                Close();
            }
            else
            {
                isEditMode = true;
                PopulateFields(studentToEdit);
            }
        }

        private void PopulateFields(Student studentToEdit)
        {
           tbStudentFirstName.Text = studentToEdit.studentFirstName;
           tbStudentLastName.Text = studentToEdit.studentLastName;
           dpDateOfBirth.Value = (DateTime)studentToEdit.dateOfBirth;
           tbAverage.Text = studentToEdit.lastYearAverage.ToString();
           lblStudentId.Text = studentToEdit.id.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string studentFirstName = tbStudentFirstName.Text;
                string studentLastName = tbStudentLastName.Text;
                var studentDateOfBirth = dpDateOfBirth.Value;
                string studentLevel = cbStudentLevel.Text;

                double studentLastYearAverage = Convert.ToDouble(tbAverage.Text);
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(studentFirstName) || string.IsNullOrWhiteSpace(studentLastName)|| string.IsNullOrWhiteSpace(studentLevel) )
                {
                    isValid = false;
                    errorMessage += "خطأ: الرجاء إدخال البيانات المفقودة \n\r";
                }

                if (studentDateOfBirth.Year > 2011)
                {
                    isValid = false;
                    errorMessage += "خطأ: اختيار تاريخ غير مسموح \n\r";
                }

                if (isValid)
                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblStudentId.Text);
                        var student = _db.Students.FirstOrDefault(q => q.id == id);
                        student.studentFirstName = studentFirstName;
                        student.studentLastName = studentLastName;
                        student.dateOfBirth = studentDateOfBirth;
                        student.lastYearAverage = (decimal)studentLastYearAverage;
                        student.studentLevelId = (int)cbStudentLevel.SelectedValue;
                        _db.SaveChanges();
                        MessageBox.Show(
                           $"تم تعديل بيانات الطالب بنجاح \n\r" +
                           $"إسم التلميذ {studentFirstName}" + " \n\r" +
                           $"لقب التلميذ {studentLastName}" + " \n\r" +
                           $"تاريخ الولادة {studentDateOfBirth}" + " \n\r" +
                           $"المستوى الدراسي {studentLevel}" + " \n\r" +
                           $"معدل السنة الفارطة {studentLastYearAverage}" + " \n\r");
                    }
                    else
                    {   
                        var student = new Student();
                        student.studentFirstName = studentFirstName;
                        student.studentLastName = studentLastName;
                        student.dateOfBirth = studentDateOfBirth;
                        student.lastYearAverage = (decimal)studentLastYearAverage;
                        student.studentLevelId = (int)cbStudentLevel.SelectedValue;

                        _db.Students.Add(student);
                        _db.SaveChanges();

                        MessageBox.Show(
                            $"تمت إضافة الطالب بنجاح \n\r" +
                            $"إسم التلميذ {studentFirstName}" + " \n\r" +
                            $"لقب التلميذ {studentLastName}" + " \n\r" +
                            $"تاريخ الولادة {studentDateOfBirth}" + " \n\r" +
                            $"المستوى الدراسي {studentLevel}" + " \n\r" +
                            $"معدل السنة الفارطة {studentLastYearAverage}" + " \n\r");
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                if (ex.Message.Contains("Input string was not in a correct format"))
                {
                    MessageBox.Show("الرجاء إدخال بيانات تتطابق مع المطلوب ");
                }
            }
        }

        private void lbShoolManagement_Load(object sender, EventArgs e)
        {
            var levels = _db.Levels
                .Select(q => new
                {
                    Id = q.Id,
                    Level = q.SchoolLevel
                })
                .ToList();
            cbStudentLevel.DisplayMember = "Level";
            cbStudentLevel.ValueMember = "Id";
            cbStudentLevel.DataSource = levels;
        }
    }
}
