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
    /// <summary>
    /// 学生数据访问层
    /// </summary>
    public class StudentDao
    {
        public static List<Student> GetAll()
        {
            string sql = "select * from t_student";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Query<Student>(sql).ToList();
            }
        }
    }
}
