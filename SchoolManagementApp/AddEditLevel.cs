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
    public partial class AddEditLevel : Form
    {
        private readonly SchoolManagementEntities _db = new SchoolManagementEntities(); 
        private bool isEditMode;
        private ManageLevelListing _manageLevelListing;
        public AddEditLevel(ManageLevelListing manageLevelListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "إضافة مستوى";
            isEditMode = false;
            _manageLevelListing = manageLevelListing;
        }

        public AddEditLevel(Level level, ManageLevelListing manageLevelListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "تعديل مستوى";
            _manageLevelListing = manageLevelListing;

            if (level == null)
            {
                MessageBox.Show("يرجى التأكد من تحديد المستوى للتعديل");
                Close();
            }
            else
            {
                isEditMode = true;
                PopulateFields(level);
            }

        }

        private void PopulateFields(Level level)
        {
            lblId.Text = level.Id.ToString();
            tbLevel.Text = level.SchoolLevel;
            tbNumberOfClasses.Text = level.NbreOfClasses.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // added validation 
                if (string.IsNullOrWhiteSpace(tbLevel.Text) || string.IsNullOrWhiteSpace(tbNumberOfClasses.Text))
                {
                    MessageBox.Show("الرجاء التثبت من المعلومات المطلوبة");
                }
                else
                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblId.Text);
                        var level = _db.Levels.FirstOrDefault(q => q.Id == id);
                        level.NbreOfClasses = int.Parse(tbNumberOfClasses.Text);
                        level.SchoolLevel = tbLevel.Text;

                    }
                    else
                    {
                        var newLevel = new Level()
                        {
                            SchoolLevel = tbLevel.Text,
                            NbreOfClasses = int.Parse(tbNumberOfClasses.Text),
                        };
                        _db.Levels.Add(newLevel);

                    }
                    _db.SaveChanges();
                    _manageLevelListing.PopulateGrid();
                    Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

           
  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
