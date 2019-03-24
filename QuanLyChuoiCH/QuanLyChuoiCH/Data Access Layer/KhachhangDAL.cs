using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class KhachhangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public KhachhangDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllKH()
        {
            string sql = "SELECT * FROM vw_KhachHang";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertKH(Khachhang kh)
        {
            string sql = "INSERT INTO Khachhang VALUES (@MaKH, @TenKH, @Diachi)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = kh.MaKH;
                scmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.TenKH;
                scmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = kh.Diachi;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateKH(Khachhang kh)
        {
            string sql = "UPDATE Khachhang SET TenKH = @TenKH, Diachi = @Diachi WHERE MaKH = @MaKH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = kh.MaKH;
                scmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.TenKH;
                scmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = kh.Diachi;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteKH(Khachhang kh)
        {
            string sql = "DELETE FROM Khachhang WHERE MaKH = @MaKH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = kh.MaKH;  
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
