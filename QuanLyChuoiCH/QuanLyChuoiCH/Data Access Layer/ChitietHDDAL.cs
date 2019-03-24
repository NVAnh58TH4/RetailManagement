using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class ChitietHDDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public ChitietHDDAL()
        {
            dc = new DataConnection();
        }

        public SqlConnection SqlConnection { get; private set; }

        public DataTable getAllCTHD()
        {
            string sql = "SELECT * FROM vw_CTHD";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertCTHD(ChitietHD cthd)
        {
            string sql = "INSERT INTO ChitietHD VALUES (@MaHD, @MaH, @Soluong)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cthd.MaHD;
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = cthd.MaH;
                scmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = cthd.Soluong;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateCTHD(ChitietHD cthd)
        {
            string sql = "UPDATE ChitietHD SET Soluong = @Soluong WHERE MaHD = @MaHD and MaH = @MaH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cthd.MaHD;
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = cthd.MaH;
                scmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = cthd.Soluong;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteCTHD(ChitietHD cthd)
        {
            string sql = "DELETE FROM ChitietHD WHERE MaHD = @MaHD and MaH = @MaH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cthd.MaHD;
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = cthd.MaH;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable thongkeCTHD()
        {
            string sql = "EXEC sp_Thongkedaban_SL";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable MHchuamua()
        {
            string sql = "EXEC sp_SP_chuaban";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
