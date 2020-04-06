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
    class PhongBan_BUS
    {


        Data dt = new Data();
        public DataTable getMaPhongBan()
        {
            DataTable da = null;
            String sql = "Select ma_pb from PhongBan ";
            da = dt.getTable(sql);
            return da;
        }

        // Lay nhân viên từ database
        public DataTable getPhongBan()
        {
            DataTable da = null;
            String sql = "Select * from PhongBan ";
            da = dt.getTable(sql);
            return da;
        }


        // Lay chuc vu
        public DataTable getPhongBanChiTiet(String phongBan)
        {
            DataTable da = null;
            String sql = "  Select * from PhongBan where Ma_PB = '" + phongBan + "' ";
            da = dt.getTable(sql);
            return da;
        }

        //thêm phong ban
        public void insertPhongBan(String ma_PB, String tenPB)
        {
            String sql = "  insert into PhongBan values('" + ma_PB + "',N'+" + tenPB + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        // sửa nhân viên
        public void updatePhongBan(String ma_PB, String tenPB)
        {
            String sql = "UPDATE PhongBan set ten_pb = N'" + tenPB + "' where ma_PB = '"+ ma_PB +"'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
       
        // tìm kiếm gần đúng theo id và tên
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from PhongBan where Ma_PB like N'%" + condi + "%' OR Ten_PB like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }


    }
}
