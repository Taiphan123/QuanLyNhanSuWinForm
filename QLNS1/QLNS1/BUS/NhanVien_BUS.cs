using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNS1.DAL;
using QLNS1.DTO;
namespace QLNS1.BUS
{
    class NhanVien_BUS
    {
        Data dt = new Data();
        // Lay nhân viên từ database ADIM
        public DataTable getNhanvien()
        {
            DataTable da = null;
            String sql = "Select * from NguoiDung ";
            da = dt.getTable(sql);
            return da;
        }
        // Lay nhân viên từ database user
        public DataTable getNhanvien1()
        {
            DataTable da = null;
            String sql = "SELECT Ma_ND,HoTen,GioiTinh,NgaySinh,DiaChi,Sdt,TrinhDo,Ma_CV,Ma_PB,Luong,Image FROM NguoiDung ";
            da = dt.getTable(sql);
            return da;
        }

        // Lay nhân viên theo condition
        NhanVien_DTO U = new NhanVien_DTO();
        Data da = new Data();
        public DataTable getCondition(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from NguoiDung where " + condition;
            dt = da.getTable(sql);
            return dt;
        }
        //thêm nhân viên
        public void insertNV(String Ma_ND, String HoTen, String MatKhau, String GioiTinh, String NgaySinh, String DiaChi, String Sdt, String trinhDo, String MaCV, String maPB,float Luong,String Img)
        {
            String sql = "  insert into NguoiDung values('"+ Ma_ND+"',N'+"+ HoTen+"','"+ MatKhau+" ',N'"+GioiTinh+" ',"+ NgaySinh+" ,N'"+ DiaChi +"','"+Sdt +" ',N'"+ trinhDo+"','"+ MaCV +"','"+maPB+"',"+ Luong +",'"+Img+"')";
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
        public void updateNV(String Ma_ND, String HoTen, String MatKhau, String GioiTinh, String NgaySinh, String DiaChi, String Sdt, String trinhDo, String MaCV, String maPB, float Luong, String Img)
        {
            String sql = "UPDATE NguoiDung set HoTen =N'" + HoTen + "',MatKhau='" + MatKhau + "',GioiTinh=N'" + GioiTinh + "',ngaysinh='" + NgaySinh + "',DiaChi=N'" + DiaChi + "',Sdt='" + Sdt + "',TrinhDo=N'" + trinhDo + "',Ma_CV='" + MaCV + "',Ma_PB='" + maPB + "',Luong='" + Luong + "',Image='" + Img +"' where Ma_ND='" + Ma_ND + "'";
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
        // xóa nhân viên
        public void deleteNV(String mand)
        {
            String sql = "delete NguoiDung where Ma_ND='" + mand + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
        // tìm kiếm gần đúng theo id và tên
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from NguoiDung where Ma_ND like N'%" + condi + "%' OR HoTen like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }

        // dem trinh do
        public DataTable trinhDo(String condi)
        {
            DataTable da = null;
            String sql = "SELECT COUNT(*) FROM NguoiDung Where TrinhDo like N'" + condi + "'";
            da = dt.getTable(sql);
            return da;
        }
        // bao cao luong nhan vien
        // dem trinh do
        public DataTable luong()
        {
            DataTable da = null;
            String sql = "select Ma_Nd,Luong from NguoiDung";
            da = dt.getTable(sql);
            return da;
        }
    }
}
