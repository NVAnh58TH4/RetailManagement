using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class KhachhangBLL
    {
        KhachhangDAL KHQuery;
        public KhachhangBLL()
        {
            KHQuery = new KhachhangDAL();
        }
        public DataTable getAllKH()
        {
            return KHQuery.getAllKH();
        }
        public bool insertKH(Khachhang kh)
        {
            return KHQuery.insertKH(kh);
        }
        public bool updateKH(Khachhang kh)
        {
            return KHQuery.updateKH(kh);
        }
        public bool deleteKH(Khachhang kh)
        {
            return KHQuery.deleteKH(kh);
        }
    }
}
