using Dao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ViewModels
{
    public class StudentViewModel
    {
        public StudentViewModel(Student student)
        {
            this.Id = student.Id;
            this.Name = student.Name;
            this.Age = student.Age;
            this.Id = student.Id;
            this.Sex = student.Sex == 1 ? "男" : "女";
            this.Birthday = student.Birthday;
        }
        
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public DateTime Birthday { get; set; }
    }
}
