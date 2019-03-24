using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class HoadonDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public HoadonDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllHD()
        {
            string sql = "SELECT * FROM vw_HoaDon";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertHD(Hoadon hd)
        {
            string sql = "INSERT INTO Hoadon Values (@MaHD, @MaKH, @MaCH, @Ngaylap)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = hd.MaHD;
                scmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hd.MaKH;
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = hd.MaCH;
                scmd.Parameters.Add("@Ngaylap", SqlDbType.SmallDateTime).Value = hd.Ngaylap;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateHD(Hoadon hd)
        {
            string sql = "UPDATE Hoadon SET MaKH = @MaKH, MaCH = @MaCH WHERE MaHD = @MaHD";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = hd.MaHD;
                scmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hd.MaKH;
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = hd.MaCH;
                scmd.Parameters.Add("@Ngaylap", SqlDbType.SmallDateTime).Value = hd.Ngaylap;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteHD(Hoadon hd)
        {
            string sql = "DELETE FROM Hoadon WHERE MaHD = @MaHD";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = hd.MaHD;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable KHChuamua()
        {
            string sql = "EXEC sp_KH_chuamua";
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
