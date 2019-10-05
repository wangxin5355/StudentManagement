using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Entity
{
    public class Teacher
    {
        public int Id { get; set; }

        /// <summary>
        ///老师名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 教的科目
        /// </summary>
        public string Subjects { get; set; }




    }


}
