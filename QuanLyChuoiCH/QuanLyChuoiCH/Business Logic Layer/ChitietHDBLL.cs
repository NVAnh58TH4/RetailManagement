using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class ChitietHDBLL
    {
        ChitietHDDAL CTHDQuery;
        public ChitietHDBLL()
        {
            CTHDQuery = new ChitietHDDAL();
        }
        public DataTable getAllCTHD()
        {
            return CTHDQuery.getAllCTHD();
        }
        public bool insertCTHD(ChitietHD ct)
        {
            return CTHDQuery.insertCTHD(ct);
        }
        public bool updateCTHD(ChitietHD ct)
        {
            return CTHDQuery.updateCTHD(ct);
        }
        public bool deleteCTHD(ChitietHD ct)
        {
            return CTHDQuery.deleteCTHD(ct);
        }
        public DataTable thongkeCTHD()
        {
            return CTHDQuery.thongkeCTHD();
        }
        public DataTable MHchuamua()
        {
            return CTHDQuery.MHchuamua();
        }
    }
}
