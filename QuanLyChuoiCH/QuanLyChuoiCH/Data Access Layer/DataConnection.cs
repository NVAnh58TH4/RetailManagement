using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class DataConnection
    {
        string connStr;
        public DataConnection()
        {
            connStr = "Data Source = REDHOOD\\MSSQLSERVER01; Initial Catalog = ChuoiCH; Integrated Security = true";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(connStr);
        }
    }
}
