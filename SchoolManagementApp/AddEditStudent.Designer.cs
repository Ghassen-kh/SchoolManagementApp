namespace SchoolManagementApp
{
    partial class AddEditStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbStudentFirstName = new System.Windows.Forms.TextBox();
            this.lbStudentFirstName = new System.Windows.Forms.Label();
            this.lbStudentLastName = new System.Windows.Forms.Label();
            this.tbStudentLastName = new System.Windows.Forms.TextBox();
            this.dpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.cbStudentLevel = new System.Windows.Forms.ComboBox();
            this.tbStudentLevel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbAverage = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Andalus", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(205, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إضافة طالب";
            // 
            // tbStudentFirstName
            // 
            this.tbStudentFirstName.Location = new System.Drawing.Point(337, 106);
            this.tbStudentFirstName.Name = "tbStudentFirstName";
            this.tbStudentFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentFirstName.TabIndex = 1;
            // 
            // lbStudentFirstName
            // 
            this.lbStudentFirstName.AutoSize = true;
            this.lbStudentFirstName.Location = new System.Drawing.Point(382, 90);
            this.lbStudentFirstName.Name = "lbStudentFirstName";
            this.lbStudentFirstName.Size = new System.Drawing.Size(56, 13);
            this.lbStudentFirstName.TabIndex = 2;
            this.lbStudentFirstName.Text = "إسم الطالب";
            // 
            // lbStudentLastName
            // 
            this.lbStudentLastName.AutoSize = true;
            this.lbStudentLastName.Location = new System.Drawing.Point(382, 157);
            this.lbStudentLastName.Name = "lbStudentLastName";
            this.lbStudentLastName.Size = new System.Drawing.Size(57, 13);
            this.lbStudentLastName.TabIndex = 4;
            this.lbStudentLastName.Text = " لقب الطالب";
            // 
            // tbStudentLastName
            // 
            this.tbStudentLastName.Location = new System.Drawing.Point(337, 173);
            this.tbStudentLastName.Name = "tbStudentLastName";
            this.tbStudentLastName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentLastName.TabIndex = 3;
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.Location = new System.Drawing.Point(39, 106);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dpDateOfBirth.TabIndex = 5;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(173, 90);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(64, 13);
            this.lbDateOfBirth.TabIndex = 6;
            this.lbDateOfBirth.Text = "تاريخ الولادة";
            // 
            // cbStudentLevel
            // 
            this.cbStudentLevel.FormattingEnabled = true;
            this.cbStudentLevel.Location = new System.Drawing.Point(119, 173);
            this.cbStudentLevel.Name = "cbStudentLevel";
            this.cbStudentLevel.Size = new System.Drawing.Size(121, 21);
            this.cbStudentLevel.TabIndex = 7;
            // 
            // tbStudentLevel
            // 
            this.tbStudentLevel.AutoSize = true;
            this.tbStudentLevel.Location = new System.Drawing.Point(192, 157);
            this.tbStudentLevel.Name = "tbStudentLevel";
            this.tbStudentLevel.Size = new System.Drawing.Size(47, 13);
            this.tbStudentLevel.TabIndex = 8;
            this.tbStudentLevel.Text = "المستوى";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(363, 236);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "إرسال";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(148, 211);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(92, 13);
            this.lbAverage.TabIndex = 10;
            this.lbAverage.Text = "معدل السنة الفارطة";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(140, 236);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(100, 20);
            this.tbAverage.TabIndex = 11;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(36, 243);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(0, 13);
            this.lblStudentId.TabIndex = 12;
            this.lblStudentId.Visible = false;
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 281);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.lbAverage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbStudentLevel);
            this.Controls.Add(this.cbStudentLevel);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.dpDateOfBirth);
            this.Controls.Add(this.lbStudentLastName);
            this.Controls.Add(this.tbStudentLastName);
            this.Controls.Add(this.lbStudentFirstName);
            this.Controls.Add(this.tbStudentFirstName);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEditStudent";
            this.Text = "إضافة طالب";
            this.Load += new System.EventHandler(this.lbShoolManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbStudentFirstName;
        private System.Windows.Forms.Label lbStudentFirstName;
        private System.Windows.Forms.Label lbStudentLastName;
        private System.Windows.Forms.TextBox tbStudentLastName;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.ComboBox cbStudentLevel;
        private System.Windows.Forms.Label tbStudentLevel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label lblStudentId;
    }
}

