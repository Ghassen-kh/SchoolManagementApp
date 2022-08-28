namespace SchoolManagementApp
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.إدارةالفصولالدراسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضقائمةالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلبياناتالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ادارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةالفصولالدراسيةToolStripMenuItem,
            this.إدارةالطلابToolStripMenuItem,
            this.ادارةالمستخدمينToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // إدارةالفصولالدراسيةToolStripMenuItem
            // 
            this.إدارةالفصولالدراسيةToolStripMenuItem.Name = "إدارةالفصولالدراسيةToolStripMenuItem";
            this.إدارةالفصولالدراسيةToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.إدارةالفصولالدراسيةToolStripMenuItem.Text = "إدارة الفصول الدراسية";
            this.إدارةالفصولالدراسيةToolStripMenuItem.Click += new System.EventHandler(this.إدارةالفصولالدراسيةToolStripMenuItem_Click);
            // 
            // إدارةالطلابToolStripMenuItem
            // 
            this.إدارةالطلابToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةطالبToolStripMenuItem,
            this.عرضقائمةالطلابToolStripMenuItem,
            this.تعديلبياناتالطالبToolStripMenuItem});
            this.إدارةالطلابToolStripMenuItem.Name = "إدارةالطلابToolStripMenuItem";
            this.إدارةالطلابToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.إدارةالطلابToolStripMenuItem.Text = "إدارة الطلاب";
            // 
            // اضافةطالبToolStripMenuItem
            // 
            this.اضافةطالبToolStripMenuItem.Name = "اضافةطالبToolStripMenuItem";
            this.اضافةطالبToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.اضافةطالبToolStripMenuItem.Text = "اضافة طالب";
            this.اضافةطالبToolStripMenuItem.Click += new System.EventHandler(this.اضافةطالبToolStripMenuItem_Click);
            // 
            // عرضقائمةالطلابToolStripMenuItem
            // 
            this.عرضقائمةالطلابToolStripMenuItem.Name = "عرضقائمةالطلابToolStripMenuItem";
            this.عرضقائمةالطلابToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.عرضقائمةالطلابToolStripMenuItem.Text = "عرض قائمة الطلاب";
            this.عرضقائمةالطلابToolStripMenuItem.Click += new System.EventHandler(this.عرضقائمةالطلابToolStripMenuItem_Click);
            // 
            // تعديلبياناتالطالبToolStripMenuItem
            // 
            this.تعديلبياناتالطالبToolStripMenuItem.Name = "تعديلبياناتالطالبToolStripMenuItem";
            this.تعديلبياناتالطالبToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.تعديلبياناتالطالبToolStripMenuItem.Text = "تعديل بيانات الطالب";
            // 
            // ادارةالمستخدمينToolStripMenuItem
            // 
            this.ادارةالمستخدمينToolStripMenuItem.Name = "ادارةالمستخدمينToolStripMenuItem";
            this.ادارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.ادارةالمستخدمينToolStripMenuItem.Text = "ادارة المستخدمين";
            this.ادارةالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.ادارةالمستخدمينToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "نظام إدارة المدرسة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إدارةالفصولالدراسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إدارةالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضقائمةالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلبياناتالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ادارةالمستخدمينToolStripMenuItem;
    }
}