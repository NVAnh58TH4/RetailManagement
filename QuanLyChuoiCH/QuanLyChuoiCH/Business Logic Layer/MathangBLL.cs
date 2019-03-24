using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class MathangBLL
    {
        MathangDAL MHQuery;
        public MathangBLL()
        {
            MHQuery = new MathangDAL();
        }
        public DataTable getAllMH()
        {
            return MHQuery.getAllMH();
        }
        public bool insertMH(Mathang mh)
        {
            return MHQuery.insertMH(mh);
        }
        public bool updateMH(Mathang mh)
        {
            return MHQuery.updateMH(mh);
        }
        public bool deleteMH(Mathang mh)
        {
            return MHQuery.deleteMH(mh);
        }
        public DataTable getSLBan(string val)
        {
            return MHQuery.getSLBan(val);
        }
    }
}
