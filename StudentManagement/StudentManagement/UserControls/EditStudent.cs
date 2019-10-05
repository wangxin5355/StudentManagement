using Dao.Dao;
using Dao.Entity;
using StudentManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UserControls
{
    public partial class EditStudent : Form
    {
        public StudentViewModel student = null;
        public EditStudent()
        {
            InitializeComponent();
        }


        public EditStudent(StudentViewModel student)
        {
            InitializeComponent();
            this.student= student;
            this.txt_name.Text = this.student.Name;
            this.txt_age.Text = this.student.Age.ToString();
            if(this.student.Sex=="男")
            {
                this.radioButton_man.Checked = true;
            }
            else
            {
                this.radioButton_woman.Checked = true;
            }

            this.dateTimePicker_birthday.Value = this.student.Birthday;

        }
        /// <summary>
        /// 保存学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_save_Click(object sender, EventArgs e)
        {
            Student studentEntity = new Student();
            studentEntity.Name = this.txt_name.Text;
            int age;
            if(int.TryParse(this.txt_age.Text,out age))
            {
                if (age <= 0 || age > 100)
                {
                    MessageBox.Show("请输入正确的年龄！");
                    return;
                }
                studentEntity.Age = age;
            }
            else
            {
                MessageBox.Show("请输入正确的年龄！");
                this.txt_age.Text = "";
                return;
            }

            if(this.radioButton_man.Checked)
            {
                studentEntity.Sex = 1;
            }
            else
            {
                studentEntity.Sex = 2;
            }
            studentEntity.Birthday = this.dateTimePicker_birthday.Value.Date;

            //数据库操作
            StudentDao studentDao = new StudentDao();
            if (student == null)
            {
               var id= studentDao.Insert(studentEntity);
               studentEntity.Id = id;
               student = new StudentViewModel(studentEntity);
            }
            else
            {
                studentEntity.Id = student.Id;
                studentDao.Update(studentEntity);
                student.Name = studentEntity.Name;
                student.Age = studentEntity.Age;
                student.Sex = studentEntity.Sex==1?"男":"女";
                student.Birthday = studentEntity.Birthday;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
