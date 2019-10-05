using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao.Dao;
using Dao.Entity;
using StudentManagement.ViewModels;

namespace StudentManagement.UserControls
{
    public partial class StudentList : UserControl
    {
        public BindingList<StudentViewModel> students;
        public StudentList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            StudentDao studentDao = new StudentDao();
             var studentslist= studentDao.GetAll();
           
            List<StudentViewModel> vieModels = new List<StudentViewModel>();
            foreach (Student student in studentslist)
            {
                StudentViewModel studentViewModel = new StudentViewModel(student);
                vieModels.Add(studentViewModel);
                //vieModels.Add(new StudentViewModel(student));
            }
            students = new BindingList<StudentViewModel>(vieModels);
            this.grid_students.DataSource = students;
        }

        /// <summary>
        /// 新增学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_add_Click(object sender, EventArgs e)
        {

            EditStudent editStudent = new EditStudent();
            editStudent.Text = "新增学生";
            editStudent.StartPosition = FormStartPosition.CenterParent;
            if(editStudent.ShowDialog()==DialogResult.OK)
            {
                students.Add(editStudent.student);
                this.grid_students.Refresh();
            }

        }

        /// <summary>
        /// 修改学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (this.grid_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要修改的行");
                return;
            }
            var selectRow = this.grid_students.SelectedRows[0];
            var studentId = (int)selectRow.Cells["studentID"].Value;
            var selectStudent = students.FirstOrDefault(x => x.Id == studentId);
            EditStudent editStudent = new EditStudent(selectStudent);
            editStudent.Text = "修改学生";
            editStudent.StartPosition = FormStartPosition.CenterParent;
            if (editStudent.ShowDialog() == DialogResult.OK)
            {
                this.grid_students.Refresh();
            }

        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (this.grid_students.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的行");
                return;
            }
            var selectRow = this.grid_students.SelectedRows[0];

            var studentId = (int)selectRow.Cells["studentID"].Value;
            StudentDao studentDao = new StudentDao();
            studentDao.Delete(studentId);
            //C# Linq 
            var selectStudent= students.FirstOrDefault(x=>x.Id==studentId);
            if (selectStudent != null)
            {
                students.Remove(selectStudent);
            }

        }


    }
}
