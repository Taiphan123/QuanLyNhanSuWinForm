using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS1.DAL;

namespace QLNS1.BUS
{
    class BanChamCong_BUS
    {
        Data dt = new Data();
        public DataTable bccBieuDo(int thang)
        {
            DataTable da = null;
            String sql = " SELECT SUM(SoNgayCong) FROM BanChamCong where ThangCC ="+thang;
            da = dt.getTable(sql);
            return da;
        }

        public DataTable thangMaxBieuDo()
        {
            DataTable da = null;
            String sql = " Select MAX(thangcc) from BanChamCong";
            da = dt.getTable(sql);
            return da;
        }
    }
}
