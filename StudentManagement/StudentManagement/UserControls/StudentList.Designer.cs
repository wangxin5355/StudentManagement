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
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_students
            // 
            this.grid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_students.Location = new System.Drawing.Point(0, 0);
            this.grid_students.Name = "grid_students";
            this.grid_students.RowTemplate.Height = 23;
            this.grid_students.Size = new System.Drawing.Size(759, 518);
            this.grid_students.TabIndex = 0;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_students);
            this.Name = "StudentList";
            this.Size = new System.Drawing.Size(759, 518);
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_students;
    }
}
