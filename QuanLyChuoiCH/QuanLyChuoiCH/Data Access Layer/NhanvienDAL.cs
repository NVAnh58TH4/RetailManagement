using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class NhanvienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand scmd;
        public NhanvienDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNV()
        {
            string sql = "SELECT * FROM vw_NhanVien";
            SqlConnection conn = dc.getConnect();
            da = new SqlDataAdapter(sql, conn);
            conn.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertNV(Nhanvien nv)
        {
            string sql = "INSERT INTO Nhanvien VALUES (@MaNV, @TenNV, @NgaySinh, @Gioitinh, @MaCH)";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                scmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                scmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = nv.NgaySinh;
                scmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = nv.MaCH;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool updateNV(Nhanvien nv)
        {
            string sql = "UPDATE Nhanvien SET TenNV = @TenNV, NgaySinh = @NgaySinh, Gioitinh = @Gioitinh, MaCH = @MaCH WHERE MaNV = @MaNV";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                scmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                scmd.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime).Value = nv.NgaySinh;
                scmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nv.Gioitinh;
                scmd.Parameters.Add("@MaCH", SqlDbType.NVarChar).Value = nv.MaCH;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool deleteNV(Nhanvien nv)
        {
            string sql = "DELETE FROM Nhanvien WHERE MaNV = @MaNV";
            SqlConnection conn = dc.getConnect();
            try
            {
                scmd = new SqlCommand(sql, conn);
                conn.Open();
                scmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                scmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable FindNV(string nv)
        {
            string sql = "EXEC sp_FindNV N'%" + nv + "%'";
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
