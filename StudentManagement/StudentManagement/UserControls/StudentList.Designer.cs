namespace StudentManagement.UserControls
{
    partial class StudentList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_students = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentbirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_students
            // 
            this.grid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.studentbirthday,
            this.studentage,
            this.studentsex,
            this.studentID});
            this.grid_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_students.Location = new System.Drawing.Point(0, 0);
            this.grid_students.Name = "grid_students";
            this.grid_students.RowTemplate.Height = 23;
            this.grid_students.Size = new System.Drawing.Size(779, 541);
            this.grid_students.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.HeaderText = "学生名称";
            this.StudentName.Name = "StudentName";
            // 
            // studentbirthday
            // 
            this.studentbirthday.DataPropertyName = "Birthday";
            this.studentbirthday.HeaderText = "学生生日";
            this.studentbirthday.Name = "studentbirthday";
            // 
            // studentage
            // 
            this.studentage.DataPropertyName = "Age";
            this.studentage.HeaderText = "学生年龄";
            this.studentage.Name = "studentage";
            // 
            // studentsex
            // 
            this.studentsex.DataPropertyName = "Sex";
            this.studentsex.HeaderText = "学生性别";
            this.studentsex.Name = "studentsex";
            // 
            // studentID
            // 
            this.studentID.DataPropertyName = "Id";
            this.studentID.HeaderText = "学生ID";
            this.studentID.Name = "studentID";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grid_students);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_update);
            this.splitContainer1.Panel2.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel2.Controls.Add(this.btn_add);
            this.splitContainer1.Size = new System.Drawing.Size(779, 597);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_update.Location = new System.Drawing.Point(304, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "修改学生";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(219, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除学生";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add.Location = new System.Drawing.Point(132, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "新增学生";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.splitContainer1);
            this.Name = "StudentList";
            this.Size = new System.Drawing.Size(779, 597);
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_students;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentbirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsex;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
    }
}
