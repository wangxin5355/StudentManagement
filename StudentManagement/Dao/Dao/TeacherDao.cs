using Dao.Entity;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Dao
{
    public class TeacherDao
    {
        public List<Teacher> GetAll()
        {
            string sql = "select * from t_teacher";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))            {
                return conn.Query<Teacher>(sql).ToList();
            }
        }

        public int Insert(Teacher teacher)
        {
            string sql = "insert into t_teacher(name,subjects) values(@name,@subjects)";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Execute(sql, new { name = teacher.Name, subjects=teacher.Subjects });
            }
        }

        //删除
        public int Delete(int teacherId)
        {
            string sql = "delete from t_teacher where id=@id";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Execute(sql, new { id = teacherId });
            }
        }
    }
}
