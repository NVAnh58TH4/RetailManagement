using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class CuahangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public CuahangDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllCH()
        {
            string sql = "SELECT * FROM vw_Cuahang";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertCH(Cuahang ch)
        {
            string sql = "INSERT INTO Cuahang VALUES (@MaCH, @TenCH, @Diachi)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = ch.MaCH;
                scmd.Parameters.Add("@TenCH", SqlDbType.NVarChar).Value = ch.TenCH;
                scmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = ch.Diachi;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateCH(Cuahang ch)
        {
            string sql = "UPDATE Cuahang SET TenCH = @TenCH, Diachi = @Diachi WHERE MaCH = @MaCH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = ch.MaCH;
                scmd.Parameters.Add("@TenCH", SqlDbType.NVarChar).Value = ch.TenCH;
                scmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = ch.Diachi;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteCH(Cuahang ch)
        {
            string sql = "DELETE FROM Cuahang WHERE MaCH = @MaCH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = ch.MaCH;
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