namespace SchoolManagementApp
{
    partial class ManageLevelListing
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
            this.gvLevelList = new System.Windows.Forms.DataGridView();
            this.lbManageLevels = new System.Windows.Forms.Label();
            this.btnAddLevel = new System.Windows.Forms.Button();
            this.btnEditLevel = new System.Windows.Forms.Button();
            this.btnDeleteLevel = new System.Windows.Forms.Button();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLevelList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLevelList
            // 
            this.gvLevelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLevelList.Location = new System.Drawing.Point(42, 67);
            this.gvLevelList.Name = "gvLevelList";
            this.gvLevelList.Size = new System.Drawing.Size(487, 150);
            this.gvLevelList.TabIndex = 0;
            // 
            // lbManageLevels
            // 
            this.lbManageLevels.AutoSize = true;
            this.lbManageLevels.Font = new System.Drawing.Font("Andalus", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManageLevels.Location = new System.Drawing.Point(172, 9);
            this.lbManageLevels.Name = "lbManageLevels";
            this.lbManageLevels.Size = new System.Drawing.Size(250, 41);
            this.lbManageLevels.TabIndex = 2;
            this.lbManageLevels.Text = "إدارة المستويات الدراسية";
            // 
            // btnAddLevel
            // 
            this.btnAddLevel.Location = new System.Drawing.Point(111, 235);
            this.btnAddLevel.Name = "btnAddLevel";
            this.btnAddLevel.Size = new System.Drawing.Size(108, 23);
            this.btnAddLevel.TabIndex = 3;
            this.btnAddLevel.Text = "إضافة مستوى";
            this.btnAddLevel.UseVisualStyleBackColor = true;
            this.btnAddLevel.Click += new System.EventHandler(this.btnAddLevel_Click);
            // 
            // btnEditLevel
            // 
            this.btnEditLevel.Location = new System.Drawing.Point(262, 235);
            this.btnEditLevel.Name = "btnEditLevel";
            this.btnEditLevel.Size = new System.Drawing.Size(88, 23);
            this.btnEditLevel.TabIndex = 4;
            this.btnEditLevel.Text = "تعديل مستوى";
            this.btnEditLevel.UseVisualStyleBackColor = true;
            this.btnEditLevel.Click += new System.EventHandler(this.btnEditLevel_Click);
            // 
            // btnDeleteLevel
            // 
            this.btnDeleteLevel.Location = new System.Drawing.Point(397, 235);
            this.btnDeleteLevel.Name = "btnDeleteLevel";
            this.btnDeleteLevel.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLevel.TabIndex = 5;
            this.btnDeleteLevel.Text = "مسح مستوى";
            this.btnDeleteLevel.UseVisualStyleBackColor = true;
            this.btnDeleteLevel.Click += new System.EventHandler(this.btnDeleteLevel_Click);
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(42, 38);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshGrid.TabIndex = 6;
            this.btnRefreshGrid.Text = "تحديث";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // ManageLevelListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 276);
            this.Controls.Add(this.btnRefreshGrid);
            this.Controls.Add(this.btnDeleteLevel);
            this.Controls.Add(this.btnEditLevel);
            this.Controls.Add(this.btnAddLevel);
            this.Controls.Add(this.lbManageLevels);
            this.Controls.Add(this.gvLevelList);
            this.Name = "ManageLevelListing";
            this.Text = "إدارة المستويات الدراسية";
            this.Load += new System.EventHandler(this.ManageLevelListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLevelList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLevelList;
        private System.Windows.Forms.Label lbManageLevels;
        private System.Windows.Forms.Button btnAddLevel;
        private System.Windows.Forms.Button btnEditLevel;
        private System.Windows.Forms.Button btnDeleteLevel;
        private System.Windows.Forms.Button btnRefreshGrid;
    }
}