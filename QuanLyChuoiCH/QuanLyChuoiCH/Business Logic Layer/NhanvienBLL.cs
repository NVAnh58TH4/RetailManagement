using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class NhanvienBLL
    {
        NhanvienDAL NVQuery;
        public NhanvienBLL()
        {
            NVQuery = new NhanvienDAL();
        }
        public DataTable getAllNV()
        {
            return NVQuery.getAllNV();
        }
        public bool insertNV(Nhanvien nv)
        {
            return NVQuery.insertNV(nv);
        }
        public bool updateNV(Nhanvien nv)
        {
            return NVQuery.updateNV(nv);
        }
        public bool deleteNV(Nhanvien nv)
        {
            return NVQuery.deleteNV(nv);
        }
        public DataTable FindNV(string nv)
        {
            return NVQuery.FindNV(nv);
        }
    }
}
