using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DoAn
{
    class Connection
    {
        public static string strConnection = @"Data Source =DESKTOP-1SP23K9;Initial Catalog=QLThuChi;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }
    }
}
