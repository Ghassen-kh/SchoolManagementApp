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
    public partial class ManageUsers : Form
    {
        private readonly SchoolManagementEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new SchoolManagementEntities();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUsersList.SelectedRows[0].Cells["id"].Value;
                var user = _db.users.FirstOrDefault(q => q.id == id);
                var genericPassword = "Password@123";
                var hashed_password = Utils.HashPassword(genericPassword);
                user.password = hashed_password;
                _db.SaveChanges();
                MessageBox.Show($"{user.userName}  تم إعادة تعيين كلمة السر الخاصة ب")

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show($"خطا يرجى تحديد المستوى للتعديل");
                }
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvUsersList.SelectedRows[0].Cells["id"].Value;
                var user = _db.users.FirstOrDefault(q => q.id == id);
    
                user.isActive = user.isActive == true ? false : true;
                _db.SaveChanges();
                MessageBox.Show($"{user.userName}  تم تغيير الوضعية الخاصة ب")

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                    MessageBox.Show($"خطا يرجى تحديد المستوى للتعديل");
                }
            }
        }
    }
}
