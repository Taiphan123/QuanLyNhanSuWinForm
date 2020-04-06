using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNS1.DAL;

namespace QLNS1.BUS
{
    class ChucVu_BUS
    {
        // lay 1 cot chuc vu
        Data dt = new Data();
        public DataTable getMaChucVu()
        {
            DataTable da = null;
            String sql = "select ma_cv from ChucVu";
            da = dt.getTable(sql);
            return da;
        }
        // Lay chuc vu theo ma chuc vu
        public DataTable getChucVuChiTiet(String chucVu)
        {
            DataTable da = null;
            String sql = "  Select * from ChucVu where Ma_CV = '"+chucVu+"' ";
            da = dt.getTable(sql);
            return da;
        }
    }
}
