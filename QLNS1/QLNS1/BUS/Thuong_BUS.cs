using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS1.DAL;

namespace QLNS1.BUS
{
    class Thuong_BUS
    {
        Data dt = new Data();
        public DataTable thuong()
        {
            DataTable da = null;
            String sql = "select Ma_ND,SoTien  from Thuong";
            da = dt.getTable(sql);
            return da;
        }

        // Lay Thuong
        public DataTable getThuong()
        {
            DataTable da = null;
            String sql = "SELECT * FROM Thuong ";
            da = dt.getTable(sql);
            return da;
        }
        //Lay combobox theo thang
        public DataTable getThangThuong()
        {
            DataTable da = null;
            String sql = "Select thang from thuong ";
            da = dt.getTable(sql);
            return da;
        }
        // lay thang theo Thuong
        public DataTable getThangSelect(int thang)
        {
            DataTable da = null;
            String sql = "SELECT * FROM Thuong where Thang = "+thang;
            da = dt.getTable(sql);
            return da;
        }

    }
}
