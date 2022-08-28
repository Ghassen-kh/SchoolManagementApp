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
    public partial class ManageLevelListing : Form
    {
        private readonly SchoolManagementEntities _db; 
        public ManageLevelListing()
        {
            InitializeComponent();
            _db = new SchoolManagementEntities();
        }

        private void ManageLevelListing_Load(object sender, EventArgs e)
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

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            var addEditLevel = new AddEditLevel(this);
            addEditLevel.MdiParent = this.MdiParent;
            addEditLevel.Show();
        }

        private void btnEditLevel_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvLevelList.SelectedRows[0].Cells["Id"].Value;
                var level = _db.Levels.FirstOrDefault(q => q.Id == id);
                var addEditLevel = new AddEditLevel(level, this);

                addEditLevel.MdiParent = this.MdiParent;
                addEditLevel.Show();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Index was out of range"))
                {
                MessageBox.Show($"خطا يرجى تحديد المستوى للتعديل");
                }
            }
        }

        private void btnDeleteLevel_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvLevelList.SelectedRows[0].Cells["Id"].Value;
                var level = _db.Levels.FirstOrDefault(q => q.Id == id);

                DialogResult dr = MessageBox.Show("هل أنت متاكد من مسح المستوى", "مسح", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    _db.Levels.Remove(level);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("An error occurred while updating the entries"))
                {
                MessageBox.Show($"خطا لا يمكن مسح مستوى مرتبط بتلميذ");
                }
            }
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        public void PopulateGrid()
        {
            var levels = _db.Levels
                .Select(q => new {
                    LevelName = q.SchoolLevel,
                    numberOfClasses = q.NbreOfClasses,
                    q.Id
                })
                .ToList();
            gvLevelList.DataSource = levels;
            gvLevelList.Columns[2].Visible = false;
            gvLevelList.Columns[0].HeaderText = "المستوى";
            gvLevelList.Columns[1].HeaderText = "عدد الأقسام";
        }
    }
}
