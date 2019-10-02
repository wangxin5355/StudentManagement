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

namespace StudentManagement.UserControls
{
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
            InitData();
        }

        public void InitData()
        {
            StudentDao studentDao = new StudentDao();
            List<Student> students= studentDao.GetAll();
            this.grid_students.DataSource = students;
        }


    }
}
