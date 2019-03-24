using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class CuahangBLL
    {
        CuahangDAL CHQuery;
        public CuahangBLL()
        {
            CHQuery = new CuahangDAL();
        }
        public DataTable getAllCH()
        {
            return CHQuery.getAllCH();
        }
        public bool insertCH(Cuahang ch)
        {
            return CHQuery.insertCH(ch);
        }
        public bool updateCH(Cuahang ch)
        {
            return CHQuery.updateCH(ch);
        }
        public bool deleteCH(Cuahang ch)
        {
            return CHQuery.deleteCH(ch);
        }
    }
}
