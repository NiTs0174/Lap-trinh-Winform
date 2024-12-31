using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class Connection
    {
        public static string stringConnection = @"data source=DESKTOP-OJ42HN8;initial catalog=QLDoanhThu;integrated security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
