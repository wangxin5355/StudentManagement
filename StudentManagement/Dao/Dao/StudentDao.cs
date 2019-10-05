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
        public  List<Student> GetAll()
        {
            string sql = "select * from t_student";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Query<Student>(sql).ToList();
            }
        }


        public Student GetStudentByID(int studentId)
        {
            string sql = "select * from t_student where id=@id";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.QueryFirst<Student>(sql,new {id= @studentId });
            }
        }

        /// <summary>
        /// 新增并返回id
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int Insert(Student student)
        {
            string sql = "insert into t_student(name,age,sex,birthday) values(@name,@age,@sex,@birthday);select @@IDENTITY";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.ExecuteScalar<int>(sql,new { name=student.Name,age=student.Age,sex=student.Sex, birthday=student.Birthday });
            }
        }

        //删除
        public int Delete(int studentID)
        {
            string sql = "delete from t_student where id=@id";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Execute(sql,new { id= studentID });
            }
        }


        //修改

        public int Update(Student student)
        {
            string sql = "update  t_student set name=@name,age=@age,sex=@sex,birthday=@birthday where id=@id";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Execute(sql, new { name = student.Name, age = student.Age, sex = student.Sex, birthday = student.Birthday,id=student.Id });
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public int UpdateName(string  studentName,int studentID)
        {
            string sql = "update  t_student set name=@name  where id=@id";
            using (IDbConnection conn = new MySqlConnection(ConnectionString.DB_Student))
            {
                return conn.Execute(sql, new {name= studentName, id = studentID });
            }
        }
    }
}
