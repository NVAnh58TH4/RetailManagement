using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class HoadonBLL
    {
        HoadonDAL HDQuery;
        public HoadonBLL()
        {
            HDQuery = new HoadonDAL();
        }
        public DataTable getAllHD()
        {
            return HDQuery.getAllHD();
        }
        public bool insertHD(Hoadon hd)
        {
            return HDQuery.insertHD(hd);
        }
        public bool updateHD(Hoadon hd)
        {
            return HDQuery.updateHD(hd);
        }
        public bool deleteHD(Hoadon hd)
        {
            return HDQuery.deleteHD(hd);
        }
        public DataTable KHChuamua()
        {
            return HDQuery.KHChuamua();
        }
    }
}
