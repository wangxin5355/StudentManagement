using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public static class ConnectionString
    {
        public static readonly string DB_Student= GetConnectionString("DB_Student");

        public static string GetConnectionString(string name)
        {
            if (ConfigurationManager.ConnectionStrings[name] == null)
            {
                return null;
            }
            var connStr = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            if (!string.IsNullOrWhiteSpace(connStr))
            {
                return connStr;
            }
            else
            {
                throw new Exception("不存在的数据库连接字符串");
            }

        }
    }
}
