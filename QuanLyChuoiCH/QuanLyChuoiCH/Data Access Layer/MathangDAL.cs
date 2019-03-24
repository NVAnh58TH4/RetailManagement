using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class MathangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public MathangDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllMH()
        {
            string sql = "SELECT * FROM vw_MatHang";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertMH(Mathang mh)
        {
            string sql = "INSERT INTO Mathang Values (@MaH, @TenH, @Dvitinh, @Gia)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = mh.MaH;
                scmd.Parameters.Add("@TenH", SqlDbType.NVarChar).Value = mh.TenH;
                scmd.Parameters.Add("@Dvitinh", SqlDbType.NVarChar).Value = mh.Dvitinh;
                scmd.Parameters.Add("@Gia", SqlDbType.Int).Value = mh.Gia;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateMH(Mathang mh)
        {
            string sql = "UPDATE Mathang SET TenH = @TenH, Dvitinh = @Dvitinh, Gia = @Gia WHERE MaH = @MaH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = mh.MaH;
                scmd.Parameters.Add("@TenH", SqlDbType.NVarChar).Value = mh.TenH;
                scmd.Parameters.Add("@Dvitinh", SqlDbType.NVarChar).Value = mh.Dvitinh;
                scmd.Parameters.Add("@Gia", SqlDbType.Int).Value = mh.Gia;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteMH(Mathang mh)
        {
            string sql = "DELETE FROM Mathang WHERE MaH = @MaH";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaH", SqlDbType.NVarChar).Value = mh.MaH;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable getSLBan(string val)
        {
            string sql = "Select * from fn_SP (N'" + val + "')";
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
